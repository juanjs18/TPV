Public Class TicketsParados
    Public row As DataGridViewRow

    Public Sub New(dt As ConexionBD.DatosTPV)
        InitializeComponent()
        DatosTPV = dt
        Me.TicketBindingSource.DataSource = Me.DatosTPV.Ticket
    End Sub

    Private Sub TicketDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TicketDataGridView.CellClick
        If e.RowIndex >= 0 Then
            row = TicketDataGridView.Rows.Item(e.RowIndex)
        End If
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class