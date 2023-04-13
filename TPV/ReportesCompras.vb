Imports ConexionBD.DatosTPVTableAdapters

Public Class ReportesCompras
    Private Sub ReportesCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New ComprasTableAdapter
        adapter.Fill(DatosTPV.Compras)
        ComprasBindingSource.DataSource = DatosTPV.Compras
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class