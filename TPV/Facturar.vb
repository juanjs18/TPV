Imports ConexionBD.DatosTPV
Imports ConexionBD.DatosTPVTableAdapters
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Globalization
Imports System.IO
Imports ProcesosEmpresariales
Imports System.ComponentModel

Public Class Facturar
    Public Shared empresas As New Empresa
    Private removingFilter As Boolean
    Private especificacion As String = "N"
    Private cul As CultureInfo = CultureInfo.CreateSpecificCulture("es-ES")
    Private documento As Document
    Private lineaFacturaAdapter As LineaFacturaTableAdapter
    Private facturas As FacturasTableAdapter
    Private totalFactura As Double
    Public Shared usuarioAHacerFactura As Integer
    Private datatable As New DataTable2TableAdapter
    Private albaranes As New AlbaranTableAdapter
    Public Shared configuracionUsuario As Configuracion
    Public Shared codigosPostales As PostalCodeTableAdapter
    Public Shared ciudades As CitiesTableAdapter
    Private Sub Facturar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim usuarios As New UsersTableAdapter
        usuarios.Fill(GestionesDataSet.Users)

        codigosPostales = New PostalCodeTableAdapter
        codigosPostales.Fill(GestionesDataSet.PostalCode)

        ciudades = New CitiesTableAdapter
        ciudades.Fill(GestionesDataSet.Cities)

        datatable = New DataTable2TableAdapter
        datatable.Fill(GestionesDataSet.DataTable2)

        albaranes = New AlbaranTableAdapter
        albaranes.Fill(GestionesDataSet.Albaran)

        Dim ordenes As New OrdersTableAdapter
        ordenes.Fill(GestionesDataSet.Orders)

        Dim ubicacion As New DataTable1TableAdapter
        ubicacion.Fill(GestionesDataSet.DataTable1)

        facturas = New FacturasTableAdapter
        facturas.Fill(GestionesDataSet.Facturas)

        lineaFacturaAdapter = New LineaFacturaTableAdapter
        lineaFacturaAdapter.Fill(GestionesDataSet.LineaFactura)

        If GestionesDataSet.DataTable2.Count = 0 Then
            desahabilitarTodo()
        End If

        UsersBindingSource.Filter = "idUser = 0"

        configuracionUsuario = Configuracion.returnConfig

        'DataTable2BindingSource.Filter = "facturada = 'False'"
        'Dim r() As DataTable2Row = GestionesDataSet.DataTable2.Select("facturada = 'False'")

        'If r.Length = 0 Then
        '    MsgBox("Todos los albaranes han sido facturados!")
        'End If
    End Sub

    Private Sub BtnBuscarEmpresa_Click(sender As Object, e As EventArgs) Handles BtnBuscarEmpresa.Click
        empresas = New Empresa
        empresas.ShowDialog()

        If empresas.getID = 0 Then
            UsersBindingSource.Filter = "idUser = 0"
            DataTable2BindingSource.RemoveFilter()
        Else
            UsersBindingSource.Filter = "idUser = " & empresas.getID
            If FechaInicio.Value.ToShortDateString <> Today.ToShortDateString And FechaFinal.Value.ToShortDateString <> Today.ToShortDateString Then
                DataTable2BindingSource.Filter = "date >= '" & FechaInicio.Value & "' AND date <= '" & FechaFinal.Value & "' AND idUser = " & empresas.getID
            Else
                DataTable2BindingSource.Filter = "idUser = " & empresas.getID
            End If
        End If
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        filtrarBtnFiltrar()
    End Sub

    Private Sub filtrarBtnFiltrar()
        If empresas.getID <> 0 Then
            DataTable2BindingSource.Filter = "date >= '" & FechaInicio.Value & "' AND date <= '" & FechaFinal.Value & "' AND idUser = " & empresas.getID
        Else
            DataTable2BindingSource.Filter = "date >= '" & FechaInicio.Value & "' AND date <= '" & FechaFinal.Value & "'"
        End If
    End Sub

    Private Sub BtnQuitarFiltro_Click(sender As Object, e As EventArgs) Handles BtnQuitarFiltro.Click
        quitarFiltro()
    End Sub

    Private Sub quitarFiltro()
        DataTable2BindingSource.RemoveFilter()
        removingFilter = True
        UsersBindingSource.Filter = "idUser = 0"
        FechaInicio.Value = Today
        FechaFinal.Value = Today
        empresas.setID(0)
    End Sub

    Private Sub FechaInicio_TextChanged(sender As Object, e As EventArgs) Handles FechaInicio.TextChanged
        If FechaInicio.Value <> Today Then
            If empresas.getID = 0 Then
                DataTable2BindingSource.Filter = "date >= '" & FechaInicio.Value & "' AND date <= '" & FechaFinal.Value & "'"
            Else
                DataTable2BindingSource.Filter = "date >= '" & FechaInicio.Value & "' AND date <= '" & FechaFinal.Value & "' AND idUser = " & empresas.getID
            End If
        End If
    End Sub

    Private Sub FechaFinal_TextChanged(sender As Object, e As EventArgs) Handles FechaFinal.TextChanged
        If Not removingFilter Then
            If empresas.getID = 0 Then
                DataTable2BindingSource.Filter = "date >= '" & FechaInicio.Value & "' AND date <= '" & FechaFinal.Value & "'"
            Else
                DataTable2BindingSource.Filter = "date >= '" & FechaInicio.Value & "' AND date <= '" & FechaFinal.Value & "' AND idUser = " & empresas.getID
            End If
        End If
        removingFilter = False
    End Sub

    Public Class PageEventHelper
        Inherits PdfPageEventHelper

        Public Overrides Sub OnEndPage(writer As PdfWriter, document As Document)
            MyBase.OnEndPage(writer, document)

            Dim table As New PdfPTable(1)
            table.WidthPercentage = 100
            table.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin
            table.DefaultCell.Border = Rectangle.NO_BORDER

            Dim pageNumberFont As Font = FontFactory.GetFont(FontFactory.HELVETICA, 10)
            Dim pageNumberCell As New PdfPCell(New Phrase("Página " & writer.PageNumber, pageNumberFont))
            pageNumberCell.HorizontalAlignment = Element.ALIGN_RIGHT
            pageNumberCell.Border = Rectangle.NO_BORDER
            table.AddCell(pageNumberCell)

            table.WriteSelectedRows(0, -1, document.LeftMargin, document.BottomMargin, writer.DirectContent)

        End Sub

        Public Overrides Sub OnStartPage(writer As PdfWriter, document As Document)
            MyBase.OnStartPage(writer, document)

            Dim cb As PdfContentByte = writer.DirectContent
            cb.Rectangle(document.PageSize.Left + 10, document.PageSize.Bottom + 10, document.PageSize.Width - 20, document.PageSize.Height - 20)
            cb.Stroke()

            Dim r() As UsersRow = GestionesDataSet.Users.Select("idUser = " & usuarioAHacerFactura)
            Dim ubi() As DataTable1Row = GestionesDataSet.DataTable1.Select("idPC = " & r(0).idPostalCode)

            Dim table As New PdfPTable(1)
            table.WidthPercentage = 100
            table.DefaultCell.Border = Rectangle.NO_BORDER

            'Titulo del albaran + fuente
            Dim fontTitle As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18)
            Dim f() As FacturasRow = GestionesDataSet.Facturas.Select()
            Dim title As New PdfPCell(New Phrase("FACTURA ALBARÁN #" & f(f.Length - 1).idFactura, fontTitle))
            title.Border = Rectangle.NO_BORDER
            title.HorizontalAlignment = Element.ALIGN_CENTER
            table.AddCell(title)
            document.Add(table)
            'document.Add(Chunk.NEWLINE)

            ''Implementar empresa utilizando el albaran

            table = New PdfPTable(2)
            table.WidthPercentage = 100
            table.DefaultCell.Border = Rectangle.NO_BORDER
            'Cliente
            Dim fontClient As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)
            Dim client As New PdfPCell(New Phrase("CLIENTE:", fontClient))
            client.Border = Rectangle.NO_BORDER
            table.AddCell(client)
            client = New PdfPCell(New Phrase(configuracionUsuario.Empresa, fontClient))
            client.Border = Rectangle.NO_BORDER
            client.HorizontalAlignment = Element.ALIGN_RIGHT
            table.AddCell(client)
            'document.Add(client)
            'document.Add(Chunk.NEWLINE)

            'Datos del cliente
            Dim clientInfo As New PdfPCell(New Phrase("Nombre: " & r(0).name, FontFactory.GetFont(FontFactory.HELVETICA, 12)))
            clientInfo.Border = Rectangle.NO_BORDER
            table.AddCell(clientInfo)
            clientInfo = New PdfPCell(New Phrase(""))
            clientInfo.Border = Rectangle.NO_BORDER
            table.AddCell(clientInfo)

            clientInfo = New PdfPCell(New Phrase("Domicilio: " & r(0).street, FontFactory.GetFont(FontFactory.HELVETICA, 12)))
            clientInfo.Border = Rectangle.NO_BORDER
            table.AddCell(clientInfo)
            clientInfo = New PdfPCell(New Phrase(configuracionUsuario.Street, FontFactory.GetFont(FontFactory.HELVETICA, 12)))
            clientInfo.Border = Rectangle.NO_BORDER
            clientInfo.HorizontalAlignment = Element.ALIGN_RIGHT
            table.AddCell(clientInfo)

            clientInfo = New PdfPCell(New Phrase("Codigo postal: " & ubi(0).postalCode, FontFactory.GetFont(FontFactory.HELVETICA, 12)))
            clientInfo.Border = Rectangle.NO_BORDER
            table.AddCell(clientInfo)
            Dim codigos() As PostalCodeRow = GestionesDataSet.PostalCode.Select("idPC = " & configuracionUsuario.idPC)
            clientInfo = New PdfPCell(New Phrase(codigos(0).postalCode, FontFactory.GetFont(FontFactory.HELVETICA, 12)))
            clientInfo.Border = Rectangle.NO_BORDER
            clientInfo.HorizontalAlignment = Element.ALIGN_RIGHT
            table.AddCell(clientInfo)

            clientInfo = New PdfPCell(New Phrase("Ciudad: " & ubi(0).nameCity, FontFactory.GetFont(FontFactory.HELVETICA, 12)))
            clientInfo.Border = Rectangle.NO_BORDER
            table.AddCell(clientInfo)
            Dim raw() As CitiesRow = GestionesDataSet.Cities.Select("idCity = " & configuracionUsuario.idCity)
            clientInfo = New PdfPCell(New Phrase(raw(0).nameCity, FontFactory.GetFont(FontFactory.HELVETICA, 12)))
            clientInfo.Border = Rectangle.NO_BORDER
            clientInfo.HorizontalAlignment = Element.ALIGN_RIGHT
            table.AddCell(clientInfo)

            clientInfo = New PdfPCell(New Phrase("NIF: " & r(0).nif, FontFactory.GetFont(FontFactory.HELVETICA, 12)))
            clientInfo.Border = Rectangle.NO_BORDER
            table.AddCell(clientInfo)
            clientInfo = New PdfPCell(New Phrase(configuracionUsuario.NIF, FontFactory.GetFont(FontFactory.HELVETICA, 12)))
            clientInfo.Border = Rectangle.NO_BORDER
            clientInfo.HorizontalAlignment = Element.ALIGN_RIGHT
            table.AddCell(clientInfo)

            document.Add(table)
            'document.Add(Chunk.NEWLINE)
        End Sub

    End Class

    Private Sub agregarFactura(usuario() As UsersRow, facturaActual As DataRowView)
        facturaActual.Row.Item(3) = usuario(0).name
        facturaActual.Row.Item(4) = usuario(0).street
        facturaActual.Row.Item(5) = usuario(0).nif
        facturaActual.Row.Item(6) = usuario(0).idPostalCode
        facturaActual.Row.Item(1) = Today
        facturaActual.Row.Item(7) = usuario(0).idUser
    End Sub

    Private Sub facturarTodo(filtrado As Boolean)

        Dim hecho As Boolean = False
        If filtrado Then
            While Not hecho

                usuarioAHacerFactura = empresas.getID
                Dim filter() As DataTable2Row
                If usuarioAHacerFactura = 0 And FechaInicio.Value.ToShortDateString = Today.ToShortDateString And FechaFinal.Value.ToShortDateString = Today.ToShortDateString Then
                    filter = GestionesDataSet.DataTable2.Select()
                ElseIf usuarioAHacerFactura <> 0 And FechaInicio.Value.ToShortDateString = Today.ToShortDateString And FechaFinal.Value.ToShortDateString = Today.ToShortDateString Then
                    filter = GestionesDataSet.DataTable2.Select("idUser = " & usuarioAHacerFactura)
                ElseIf usuarioAHacerFactura <> 0 Then
                    filter = GestionesDataSet.DataTable2.Select("date >= '" & FechaInicio.Value & "' AND date <= '" & FechaFinal.Value & "' AND idUser = " & usuarioAHacerFactura)
                Else
                    filter = GestionesDataSet.DataTable2.Select("date >= '" & FechaInicio.Value & "' AND date <= '" & FechaFinal.Value & "'")
                End If

                If filter.Length = 0 Then
                    hecho = True
                Else

                    Dim usuariosPendientes() As AlbaranRow = GestionesDataSet.Albaran.Select("idUser = " & filter(0).idUser)
                    Dim usuario() As UsersRow = GestionesDataSet.Users.Select("idUser = " & usuariosPendientes(0).idUser)
                    FacturasBindingSource.AddNew()
                    FacturasBindingSource.MoveLast()
                    Dim facturaActual As DataRowView = FacturasBindingSource.Current
                    agregarFactura(usuario, facturaActual)
                    Dim amount As Double = 0

                    For Each albaranesNoFacturados As AlbaranRow In GestionesDataSet.Albaran.Select("idUser = " & usuariosPendientes(0).idUser)
                        For Each orders As OrdersRow In GestionesDataSet.Orders.Select("idAlbaran = " & albaranesNoFacturados.idAlbaran)
                            LineaFacturaBindingSource.AddNew()
                            LineaFacturaBindingSource.MoveLast()
                            Dim lineaFactura As DataRowView = LineaFacturaBindingSource.Current

                            lineaFactura.Row.Item(2) = usuariosPendientes(0)._date
                            lineaFactura.Row.Item(3) = orders.descriptionsProduct
                            lineaFactura.Row.Item(4) = orders.Quantity
                            lineaFactura.Row.Item(5) = orders.UnitPrice
                            lineaFactura.Row.Item(6) = orders.amountOrders
                            lineaFactura.Row.Item(1) = -1

                        Next
                        amount += albaranesNoFacturados.amount
                    Next
                    facturaActual.Row.Item(2) = amount
                    facturaActual.EndEdit()
                    facturas.Update(GestionesDataSet.Facturas)
                    Dim fa() As FacturasRow = GestionesDataSet.Facturas.Select()
                    LineaFacturaBindingSource.EndEdit()

                    For Each lineaFactura As LineaFacturaRow In GestionesDataSet.LineaFactura.Select("idLineaFactura < 0")
                        lineaFactura.idFactura = fa(fa.Length - 1).idFactura
                    Next
                    lineaFacturaAdapter.Update(GestionesDataSet.LineaFactura)

                    For Each orders As OrdersRow In GestionesDataSet.Orders.Select("idAlbaran = " & usuariosPendientes(0).idAlbaran)

                        usuarioAHacerFactura = usuariosPendientes(0).idUser
                        creacionPDF()
                    Next

                    datatable = New DataTable2TableAdapter
                    datatable.Fill(GestionesDataSet.DataTable2)
                    If GestionesDataSet.DataTable2.Count = 0 Then
                        MsgBox("Todos los albaranes han sido facturados.")
                        desahabilitarTodo()
                    End If

                End If


            End While

        Else

            While Not hecho
                Dim usuariosPendientes() As AlbaranRow = GestionesDataSet.Albaran.Select("facturada = 'false'")
                If usuariosPendientes.Length = 0 Then
                    hecho = True
                Else
                    Dim usuario() As UsersRow = GestionesDataSet.Users.Select("idUser = " & usuariosPendientes(0).idUser)
                    FacturasBindingSource.AddNew()
                    FacturasBindingSource.MoveLast()
                    Dim facturaActual As DataRowView = FacturasBindingSource.Current
                    agregarFactura(usuario, facturaActual)
                    Dim amount As Double = 0

                    For Each albaranesNoFacturados As AlbaranRow In GestionesDataSet.Albaran.Select("idUser = " & usuariosPendientes(0).idUser)
                        For Each orders As OrdersRow In GestionesDataSet.Orders.Select("idAlbaran = " & albaranesNoFacturados.idAlbaran)
                            LineaFacturaBindingSource.AddNew()
                            LineaFacturaBindingSource.MoveLast()
                            Dim lineaFactura As DataRowView = LineaFacturaBindingSource.Current

                            lineaFactura.Row.Item(2) = usuariosPendientes(0)._date
                            lineaFactura.Row.Item(3) = orders.descriptionsProduct
                            lineaFactura.Row.Item(4) = orders.Quantity
                            lineaFactura.Row.Item(5) = orders.UnitPrice
                            lineaFactura.Row.Item(6) = orders.amountOrders
                            lineaFactura.Row.Item(1) = -1

                        Next
                        amount += albaranesNoFacturados.amount
                    Next
                    facturaActual.Row.Item(2) = amount
                    facturaActual.EndEdit()
                    facturas.Update(GestionesDataSet.Facturas)
                    Dim fa() As FacturasRow = GestionesDataSet.Facturas.Select()

                    For Each lineaFactura As LineaFacturaRow In GestionesDataSet.LineaFactura.Select("idLineaFactura < 0")
                        lineaFactura.idFactura = fa(fa.Length - 1).idFactura
                    Next
                    lineaFacturaAdapter.Update(GestionesDataSet.LineaFactura)

                    For Each orders As OrdersRow In GestionesDataSet.Orders.Select("idAlbaran = " & usuariosPendientes(0).idAlbaran)

                        usuarioAHacerFactura = usuariosPendientes(0).idUser
                        creacionPDF()

                    Next

                End If

            End While
        End If

    End Sub

    Private Function pdfTableDetallesAlbaran(seleccion As Integer, cant As Integer) As PdfPTable
        Dim detallesAlbaranTabla As New PdfPTable(cant)
        Dim fontDetailsCells As Font = FontFactory.GetFont(FontFactory.HELVETICA, 10)
        If seleccion = 0 Then

            Dim albaran() As DataTable2Row = GestionesDataSet.DataTable2.Select("idUser = " & usuarioAHacerFactura)
            Dim fontDetails As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)

            Dim details As New PdfPCell(New Phrase(" ", fontDetails))
            details.Border = Rectangle.NO_BORDER
            detallesAlbaranTabla.AddCell(details)

            details = New PdfPCell(New Phrase("Detalles del albarán", fontDetails))
            details.Border = Rectangle.NO_BORDER
            detallesAlbaranTabla.AddCell(details)

            details = New PdfPCell(New Phrase(" ", fontDetails))
            details.Border = Rectangle.NO_BORDER
            detallesAlbaranTabla.AddCell(details)

        ElseIf seleccion = 1 Then

            detallesAlbaranTabla.WidthPercentage = 100
            detallesAlbaranTabla.DefaultCell.Border = Rectangle.NO_BORDER
            detallesAlbaranTabla.AddCell(New Phrase("ID Albaran", fontDetailsCells))
            detallesAlbaranTabla.AddCell(New Phrase("Fecha", fontDetailsCells))
            detallesAlbaranTabla.AddCell(New Phrase("Producto", fontDetailsCells))
            detallesAlbaranTabla.AddCell(New Phrase("Cantidad", fontDetailsCells))
            detallesAlbaranTabla.AddCell(New Phrase("Precio Unitario", fontDetailsCells))
            detallesAlbaranTabla.AddCell(New Phrase("Total", fontDetailsCells))

        ElseIf seleccion = 2 Then

            detallesAlbaranTabla.WidthPercentage = 100
            detallesAlbaranTabla.DefaultCell.Border = Rectangle.NO_BORDER
            totalFactura = 0.0

            'Agregar los detalles del albaran
            For Each row As AlbaranRow In GestionesDataSet.Albaran.Select("idUser = " & usuarioAHacerFactura)
                Dim celda As New PdfPCell(New Phrase(row.idAlbaran, fontDetailsCells))
                celda.HorizontalAlignment = Element.ALIGN_RIGHT
                celda.Border = Rectangle.NO_BORDER
                detallesAlbaranTabla.AddCell(celda)
                detallesAlbaranTabla.AddCell(New Phrase(row._date, fontDetailsCells))
                detallesAlbaranTabla.AddCell(New Phrase("", fontDetailsCells))
                detallesAlbaranTabla.AddCell(New Phrase("", fontDetailsCells))
                detallesAlbaranTabla.AddCell(New Phrase("", fontDetailsCells))
                celda = New PdfPCell(New Phrase(row.amount.ToString(especificacion, cul) & " €", fontDetailsCells))
                celda.HorizontalAlignment = Element.ALIGN_RIGHT
                celda.Border = Rectangle.NO_BORDER
                detallesAlbaranTabla.AddCell(celda)
                totalFactura += row.amount

                detallesAlbaranTabla.AddCell(New Phrase(" ", fontDetailsCells))
                detallesAlbaranTabla.AddCell(New Phrase(" ", fontDetailsCells))
                detallesAlbaranTabla.AddCell(New Phrase(" ", fontDetailsCells))
                detallesAlbaranTabla.AddCell(New Phrase(" ", fontDetailsCells))
                detallesAlbaranTabla.AddCell(New Phrase(" ", fontDetailsCells))
                detallesAlbaranTabla.AddCell(New Phrase(" ", fontDetailsCells))

                For Each orders As OrdersRow In GestionesDataSet.Orders.Select("idAlbaran = " & row.idAlbaran)
                    detallesAlbaranTabla.AddCell(New Phrase("", fontDetailsCells))
                    detallesAlbaranTabla.AddCell(New Phrase("", fontDetailsCells))
                    detallesAlbaranTabla.AddCell(New Phrase(orders.descriptionsProduct, fontDetailsCells))
                    celda = New PdfPCell(New Phrase(orders.Quantity, fontDetailsCells))
                    celda.HorizontalAlignment = Element.ALIGN_RIGHT
                    celda.Border = Rectangle.NO_BORDER
                    detallesAlbaranTabla.AddCell(celda)
                    celda = New PdfPCell(New Phrase(orders.UnitPrice.ToString(especificacion, cul), fontDetailsCells))
                    celda.HorizontalAlignment = Element.ALIGN_RIGHT
                    celda.Border = Rectangle.NO_BORDER
                    detallesAlbaranTabla.AddCell(celda)
                    celda = New PdfPCell(New Phrase(orders.amountOrders.ToString(especificacion, cul) & " €", fontDetailsCells))
                    celda.HorizontalAlignment = Element.ALIGN_RIGHT
                    celda.Border = Rectangle.NO_BORDER
                    detallesAlbaranTabla.AddCell(celda)
                Next

                detallesAlbaranTabla.AddCell(New Phrase("______________", fontDetailsCells))
                detallesAlbaranTabla.AddCell(New Phrase("______________", fontDetailsCells))
                detallesAlbaranTabla.AddCell(New Phrase("______________", fontDetailsCells))
                detallesAlbaranTabla.AddCell(New Phrase("______________", fontDetailsCells))
                detallesAlbaranTabla.AddCell(New Phrase("______________", fontDetailsCells))
                detallesAlbaranTabla.AddCell(New Phrase("______________", fontDetailsCells))
                row.facturada = "True"
                albaranes.Update(GestionesDataSet.Albaran)
            Next

        End If

        Return detallesAlbaranTabla
    End Function

    Private Sub creacionPDF()
        Dim headerHeight As Single = 150
        Dim conf As Configuracion
        conf = Configuracion.returnConfig

        especificacion = "N"
        cul = CultureInfo.CreateSpecificCulture("es-ES")

        'Crear pdf
        documento = New Document()

        Dim ff() As FacturasRow = GestionesDataSet.Facturas.Select()
        documento.SetPageSize(New Rectangle(595, 842 - headerHeight))
        Dim writer As PdfWriter = PdfWriter.GetInstance(documento, New FileStream(conf.ruta & "\Factura#" & ff(ff.Length - 1).idFactura & ".pdf", FileMode.Create))
        Dim helper As New PageEventHelper()
        writer.PageEvent = helper

        documento.Open()

        'Imprimir literalmente "detalles albaran"
        documento.Add(pdfTableDetallesAlbaran(0, 1))

        'Imprimir encabezado de la tabla
        documento.Add(pdfTableDetallesAlbaran(1, 6))

        Dim fontDetails As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)
        Dim linea As New Paragraph("______________________________________________________________________________", fontDetails)
        documento.Add(linea)

        linea = New Paragraph(" ")
        documento.Add(linea)

        'Imprimir lineas de la factura
        documento.Add(pdfTableDetallesAlbaran(2, 6))

        Dim iva As Double = (21 * totalFactura) / 100
        Dim total As New Paragraph("Total: " & totalFactura.ToString(especificacion, cul) & " €" & vbNewLine & "Total IVA: " & iva.ToString(especificacion, cul) & " €" & vbNewLine & "IVA: 21,00%", fontDetails)
        total.Alignment = Element.ALIGN_RIGHT
        documento.Add(total)

        documento.Close()
        writer.Close()
    End Sub

    Private Sub BtnFiltrado_Click(sender As Object, e As EventArgs) Handles BtnFiltrado.Click

        facturarTodo(True)
        MsgBox("Hecho")
        quitarFiltro()
        datatable = New DataTable2TableAdapter
        datatable.Fill(GestionesDataSet.DataTable2)
        Dim conf = Configuracion.returnConfig
        Dim proceso As New Process
        proceso.StartInfo.FileName = "explorer.exe"
        proceso.StartInfo.Arguments = conf.ruta
        proceso.Start()
        If GestionesDataSet.DataTable2.Count = 0 Then
            MsgBox("Todo ha sido cobrado")
            desahabilitarTodo()
        End If

    End Sub

    Private Sub BtnTodo_Click(sender As Object, e As EventArgs) Handles BtnTodo.Click
        facturarTodo(False)
        MsgBox("Hecho")
        datatable = New DataTable2TableAdapter
        datatable.Fill(GestionesDataSet.DataTable2)
        Dim conf = Configuracion.returnConfig
        Dim proceso As New Process
        proceso.StartInfo.FileName = "explorer.exe"
        proceso.StartInfo.Arguments = conf.ruta
        proceso.Start()
        desahabilitarTodo()
    End Sub

    Private Sub desahabilitarTodo()
        BtnFiltrado.Enabled = False
        BtnTodo.Enabled = False
        BtnBuscarEmpresa.Enabled = False
        BtnFiltrar.Enabled = False
        BtnQuitarFiltro.Enabled = False
        FechaInicio.Enabled = False
        FechaFinal.Enabled = False
    End Sub
    Private Sub BtnFacturados_Click(sender As Object, e As EventArgs) Handles BtnFacturados.Click
        Me.Hide()
        Dim form As New FacturasRealizadas(0)
        form.Show()
    End Sub

    Private Sub Facturar_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MenuFacturacion.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class