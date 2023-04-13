Public Class ListaRegularizaciones
    Public id As DataGridViewRow = Nothing

    Public Sub New(ds As ConexionBD.DatosTPV)
        InitializeComponent()
        DatosTPV = ds
        RegularizacionBindingSource.DataSource = DatosTPV
        RegularizacionBindingSource.DataMember = "Regularizacion"
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub RegularizacionDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles RegularizacionDataGridView.CellClick
        If e.RowIndex >= 0 Then
            id = RegularizacionDataGridView.Rows.Item(e.RowIndex)
            Me.Close()
        End If
    End Sub
End Class