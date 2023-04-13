Public Class ListaClientes
    Public row As DataRowView
    Public Sub New(dt As ConexionBD.DatosTPV)
        InitializeComponent()
        DatosTPV = dt
        ClientesBindingSource.DataSource = DatosTPV
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.KeyCode.Enter Then
            Dim filter As String = "name LIKE '*{0}*' OR nif LIKE '*{1}*'"
            ClientesBindingSource.Filter = String.Format(filter, TextBox1.Text, TextBox1.Text)
        End If
    End Sub

    Private Sub ClientesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ClientesDataGridView.CellClick
        If e.RowIndex >= 0 Then
            row = ClientesBindingSource.Current
            Me.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClientesBindingSource.RemoveFilter()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class