Imports System.ComponentModel
Imports ConexionBD.DatosTPV
Imports ConexionBD.DatosTPVTableAdapters
Public Class DisabledProducts

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles pbxDisabledProductsBack.Click
        Me.Close()
    End Sub

    Private Sub DisabledProducts_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MenuGestion.Show()
    End Sub

    Private Sub btnDisabledProductsHabilitar_Click(sender As Object, e As EventArgs) Handles btnDisabledProductsHabilitar.Click
        If ProductBindingSource.Count > 0 Then
            CType(ProductBindingSource.Current, DataRowView).Row.Item(6) = True
            ProductBindingSource.EndEdit()
            Dim adapter As New ProductTableAdapter
            adapter.Update(DatosTPV.Product)
        End If
    End Sub

    Private Sub DisabledProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatosTPV = MenuPrincipal.DatosTPV1
        ProductBindingSource.DataSource = DatosTPV
        ProductBindingSource.DataMember = "Product"
    End Sub
End Class