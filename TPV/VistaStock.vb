Public Class VistaStock
    Private Sub VistaStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProductBindingSource.DataSource = MenuPrincipal.DatosTPV1.Product
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class