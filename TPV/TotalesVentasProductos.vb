Imports ConexionBD.DatosTPVTableAdapters

Public Class TotalesVentasProductos
    Private Sub TotalesVentasProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New TotalesVentasProductosTableAdapter
        adapter.Fill(DatosTPV.TotalesVentasProductos)
        TotalesVentasProductosBindingSource.DataSource = DatosTPV.TotalesVentasProductos
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class