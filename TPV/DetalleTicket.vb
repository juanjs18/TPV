Imports ConexionBD
Imports ProcesosEmpresariales

Public Class DetalleTicket
    Private ticket As DataRowView
    Private ds As DatosTPV

    Public Sub New(ticket As DataRowView, ds As DatosTPV)
        InitializeComponent()
        Me.ticket = ticket
        Me.ds = ds
    End Sub

    Private Sub DetalleTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TicketBindingSource.DataSource = ds.Ticket
        TicketDetailBindingSource.DataSource = ds.TicketDetail
        TicketDetailBindingSource.Filter = "TicketCode = " & ticket.Row.Item(0)
        TicketBindingSource.Filter = "TicketCode = " & ticket.Row.Item(0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim text As String = Tickets.getTicketText(CType(TicketBindingSource.Current, DataRowView).Row.Item(0), ds, True)
        Dim printFont As Font = New Font("Lucida Console", 8, FontStyle.Regular)
        Dim title As Font = New Font("Lucida Console", 17, FontStyle.Regular)
        Dim empresa As String = Configuracion.returnConfig.Empresa
        e.Graphics.DrawString(Tickets.textEmpresa(empresa), title, Brushes.Black, 10, 10)
        e.Graphics.DrawString(vbCrLf & vbCrLf & vbCrLf & text, printFont, Brushes.Black, 10, 10)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class