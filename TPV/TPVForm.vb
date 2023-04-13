Imports ConexionBD.DatosTPV
Imports ConexionBD.DatosTPVTableAdapters
Imports ProcesosEmpresariales

Public Class TPVForm
    Public totalPrice As Double
    Private ticketsA As TicketTableAdapter
    Private detailTicket As TicketDetailTableAdapter
    Private estaClick As Boolean
    Private x As Integer
    Private y As Integer
    Private client As Integer
    Private formaPago As Boolean

    Private Sub TPVForm_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        If TicketDetailBindingSource.Count > 0 Then
            Tickets.newTickets(TicketBindingSource, TicketDetailBindingSource, ticketsA, detailTicket, DatosTPV, True, totalPrice, client, rbtTPVEfectivo.Checked)
        End If
        MenuPrincipal.Show()
    End Sub
    ' Se carga el data set y muestra las categorias
    Private Sub TPVForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatosTPV = MenuPrincipal.DatosTPV1
        TicketBindingSource.DataSource = DatosTPV
        TicketBindingSource.DataMember = "Ticket"
        ClientesBindingSource.DataSource = TicketBindingSource
        ClientesBindingSource.DataMember = "Ticket_Clientes"
        TicketDetailBindingSource.DataSource = TicketBindingSource
        TicketDetailBindingSource.DataMember = "FK_TicketDetail_Ticket"
        For Each row As CategoryRow In DatosTPV.Category.Select(Constantes.FILTER)
            Categories.Controls.Add(New Item(row))
        Next
        newBindingTicket()
    End Sub
    ' Funcion que añade un nuevo ticket
    Private Sub newBindingTicket()
        If TicketDetailBindingSource.Count = 0 And TicketBindingSource.Count <> 0 Then
            Return
        End If
        TicketBindingSource.AddNew()
        TicketBindingSource.MoveLast()
        Dim line As DataRowView = TicketBindingSource.Current
        line.Row.Item(2) = 0
        line.Row.Item(3) = 0
        line.Row.Item(4) = True
        line.Row.Item(1) = Today
        TicketBindingSource.ResetBindings(False)
        totalPrice = 0
    End Sub
    ' Funcion para dibujar un producto
    Public Sub setProducts(id As Integer)
        Products.Controls.Clear()
        Dim rows As ProductRow() = DatosTPV.Product.Select("idCategory = " & id & " AND " & Constantes.FILTER)
        For Each row As ProductRow In rows
            If row.Vendible Then
                Products.Controls.Add(New Item(row))
            End If
        Next
    End Sub
    ' Funcion que al dar clic a un producto lo añade al ticket
    Public Sub setDetailTicket(row As ProductRow)
        Dim repetir As Boolean = False
        For Each linia As DataRowView In TicketDetailBindingSource
            If (linia.Row.Item(2) = row.ProductCode And linia.Row.Item(3) = row.Price) Then
                linia.Row.Item(4) += 1
                linia.Row.Item(5) = row.Price * linia.Row.Item(4)
                totalPrice += row.Price
                repetir = True
                Exit For
            End If
        Next
        If Not repetir Then
            TicketDetailBindingSource.AddNew()
            TicketDetailBindingSource.MoveLast()
            Dim rowV As DataRowView = TicketDetailBindingSource.Current
            rowV.Row.Item(2) = row.ProductCode
            rowV.Row.Item(3) = row.Price
            rowV.Row.Item(4) = 1
            rowV.Row.Item(5) = row.Price
            rowV.Row.Item(6) = row.Name
            totalPrice += rowV.Row.Item(5)
        End If
        totalView.Text = Format(totalPrice, Constantes.FORMAT_PRICE)
        TicketDetailBindingSource.ResetBindings(False)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TicketDetailBindingSource.Count > 0 Then
            Dim r As MsgBoxResult = MsgBox(Constantes.MESSAGE_PRINT, MessageBoxButtons.YesNoCancel, Constantes.WARNING_DELETE)
            If r = MsgBoxResult.Yes Then
                Tickets.newTickets(TicketBindingSource, TicketDetailBindingSource, ticketsA, detailTicket, DatosTPV, False, totalPrice, client, rbtTPVEfectivo.Checked)
                formaPago = True
                PrintDocument1.Print()
                newBindingTicket()
            ElseIf r = MsgBoxResult.No Then
                Tickets.newTickets(TicketBindingSource, TicketDetailBindingSource, ticketsA, detailTicket, DatosTPV, False, totalPrice, client, rbtTPVEfectivo.Checked)
                newBindingTicket()
            End If
        Else
            MsgBox(Constantes.NO_ITEMS)
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If (e.RowIndex >= 0) Then
            Dim config As New OptionsLineTicket(TicketDetailBindingSource.Current)
            config.ShowDialog()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TicketDetailBindingSource.Count > 0 Then
            TicketBindingSource.RemoveCurrent()
            Tickets.updateTicket(TicketBindingSource, ticketsA, DatosTPV)
            newBindingTicket()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim text As String = Tickets.getTicketText(CType(TicketBindingSource.Current, DataRowView).Row.Item(0), DatosTPV, formaPago)
        Dim printFont As Font = New Font("Lucida Console", 8, FontStyle.Regular)
        Dim title As Font = New Font("Lucida Console", 17, FontStyle.Regular)
        Dim empresa As String = Configuracion.returnConfig.Empresa
        e.Graphics.DrawString(Tickets.textEmpresa(empresa), title, Brushes.Black, 10, 10)
        e.Graphics.DrawString(vbCrLf & vbCrLf & vbCrLf & text, printFont, Brushes.Black, 10, 10)
    End Sub

    Private Sub Categories_MouseMove(sender As Object, e As MouseEventArgs) Handles Categories.MouseMove
        If estaClick Then
            If (x = 0 And y = 0) Then
                x = e.X
                y = e.Y
            Else
                If x > e.X Then
                    Try
                        Categories.HorizontalScroll.Value -= 3
                    Catch ex As Exception
                    End Try
                ElseIf x < e.X Then
                    Try
                        Categories.HorizontalScroll.Value += 3
                    Catch ex As Exception
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub Categories_Mousedown(sender As Object, e As MouseEventArgs) Handles Categories.MouseDown
        estaClick = True
        x = 0
        y = 0
    End Sub

    Private Sub Categories_MouseUp(sender As Object, e As MouseEventArgs) Handles Categories.MouseUp
        estaClick = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TicketDetailBindingSource.Count > 0 Then
            formaPago = False
            Tickets.newTickets(TicketBindingSource, TicketDetailBindingSource, ticketsA, detailTicket, DatosTPV, True, totalPrice, client, rbtTPVEfectivo.Checked)
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim list As New TicketsParados(DatosTPV)
        list.ShowDialog()
        If list.row IsNot Nothing Then
            If TicketDetailBindingSource.Count > 0 Then
                Tickets.newTickets(TicketBindingSource, TicketDetailBindingSource, ticketsA, detailTicket, DatosTPV, True, totalPrice, client, rbtTPVEfectivo.Checked)
            Else
                TicketBindingSource.RemoveCurrent()
            End If
            TicketBindingSource.Position = TicketBindingSource.Find("TicketCode", list.row.Cells.Item(0).Value)
            totalPrice = list.row.Cells.Item(2).Value
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim list As New ListaClientes(DatosTPV)
        list.ShowDialog()
        If list.row IsNot Nothing Then
            client = list.row.Row.Item(0)
            NameLabel1.Text = list.row.Row.Item(1)
        End If
    End Sub

    Private Sub TicketBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles TicketBindingSource.CurrentChanged
        Try
            If Not IsDBNull(CType(TicketBindingSource.Current, DataRowView).Item(7)) Then
                client = CType(TicketBindingSource.Current, DataRowView).Item(7)
            Else
                client = 0
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If DatosTPV.Ticket.Select("Parada = 'True'").Count = 0 Then
            Dim cierre As New CierreCaja(DatosTPV, True, 0)
            cierre.ShowDialog()
        Else
            MsgBox(Constantes.MESSAGE_TICKETS_PARADOS, , Constantes.WARNING_DELETE)
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If TicketDetailBindingSource.Count > 0 Then
            Tickets.newTickets(TicketBindingSource, TicketDetailBindingSource, ticketsA, detailTicket, DatosTPV, True, totalPrice, client, rbtTPVEfectivo.Checked)
            newBindingTicket()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class