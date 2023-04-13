Imports ConexionBD
Imports ConexionBD.DatosTPV
Imports ConexionBD.DatosTPVTableAdapters
Imports ProcesosEmpresariales

Public Class CierreCaja
    Public lines As List(Of TicketDetailRow)
    Private nuevo As Boolean
    Public totalD As Double
    Public totalIVAD As Double
    Public totalEfectivoD As Double
    Public totalTarjetaD As Double
    Public caja As Integer
    Private config As Configuracion
    Private id As Integer

    Public Sub New(ds As DatosTPV, nuevo As Boolean, id As Integer)
        InitializeComponent()
        DatosTPV = ds
        CierreCajaBindingSource.DataSource = ds
        Me.nuevo = nuevo
        Me.id = id
    End Sub

    Private Sub CierreCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        config = Configuracion.returnConfig
        If nuevo Then
            CierreCajaBindingSource.AddNew()
            CierreCajaBindingSource.MoveLast()
            lines = New List(Of TicketDetailRow)
            Dim load As New CargarCierreCaja(Me)
            load.ShowDialog()
            If load.cancel Then
                Me.Close()
                MsgBox(Constantes.MESSAGE_NO_TICKET, , Constantes.WARNING_DELETE)
            Else
                leerCaja()
                TicketDetailBindingSource.DataSource = lines
                setInfo()
            End If
        Else
            CierreCajaBindingSource.Position = CierreCajaBindingSource.Find("idCierre", id)
            Dim rows As TicketDetailRow() = DatosTPV.TicketDetail.Select("TicketCode >= " & CType(CierreCajaBindingSource.Current, DataRowView).Row.Item(7) & " AND TicketCode <= " & CType(CierreCajaBindingSource.Current, DataRowView).Row.Item(8))
            lines = New List(Of TicketDetailRow)
            lines.AddRange(rows.ToList)
            TicketDetailBindingSource.DataSource = lines
        End If
    End Sub

    Private Sub leerCaja()
        Dim correcto As Boolean = False
        While Not correcto
            Try
                caja = InputBox("Introduce el dinero que hay en la caja: ")
                correcto = True
            Catch ex As Exception
            End Try
        End While
    End Sub

    Private Sub setInfo()
        Total.Text = Format(totalD, "0.00 €")
        Label12.Text = Format(totalIVAD, "0.00 €")
        TotalEfectivo.Text = Format(totalEfectivoD, "0.00 €")
        TotalTarjeta.Text = Format(totalTarjetaD, "0.00 €")
        TicketInicial.Text = lines.First.TicketCode
        TicketFinal.Text = lines.Last.TicketCode
        Fecha.Text = Now
        TotalCaja.Text = caja
        Try
            AnteriorCaja.Text = DatosTPV.CierresCaja.Last.CajaAnterior
        Catch ex As Exception
            AnteriorCaja.Text = 0
        End Try
        IVA.Text = config.IVA * 100
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If nuevo Then
            Dim row As DataRowView = CierreCajaBindingSource.Current
            Dim adapter As New CierresCajaTableAdapter
            row.Row.Item(1) = totalD
            row.Row.Item(2) = totalEfectivoD
            row.Row.Item(3) = totalTarjetaD
            row.Row.Item(4) = caja
            Try
                row.Row.Item(5) = DatosTPV.CierresCaja.Last.CajaAnterior
            Catch ex As Exception
                row.Row.Item(5) = 0
            End Try
            row.Row.Item(6) = Date.Parse(Fecha.Text)
            row.Row.Item(7) = lines.First.TicketCode
            row.Row.Item(8) = lines.Last.TicketCode
            row.Row.Item(9) = totalIVAD
            row.Row.Item(10) = config.IVA * 100
            row.EndEdit()
            adapter.Update(DatosTPV.CierresCaja)
            Dim cerrar As New ProcesosEmpresariales.CierresCaja(DatosTPV.Ticket.Select("TicketCode >= " & row.Row.Item(7) & " AND TicketCode <= " & row.Row.Item(8)), New TicketTableAdapter)
            cerrar.cerrarTickets()
        End If
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim row As CierresCajaRow = DatosTPV.CierresCaja.FindByidCierre(CType(CierreCajaBindingSource.Current, DataRowView).Row.Item(0))
        Dim ticket As New TicketCierreCaja(row, lines)
        Dim printFont As Font = New Font("Lucida Console", 8, FontStyle.Regular)
        e.Graphics.DrawString(ticket.ticket, printFont, Brushes.Black, 10, 10)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class