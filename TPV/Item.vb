Imports ConexionBD.DatosTPV

Public Class Item
    Private dataRow As DataRow

    Public Sub New(dataRow As DataRow)
        InitializeComponent()
        If TypeOf dataRow Is ProductRow Then
            Dim a As ProductRow = dataRow
            Try
                Picture.Image = Image.FromFile(a.Picture)
            Catch ex As Exception
                Picture.Image = My.Resources.no_image
            End Try
            NameItem.Text = a.Name
        Else
            Dim a As CategoryRow = dataRow
            Try
                Picture.Image = Image.FromFile(a.Picture)
            Catch ex As Exception
                Picture.Image = My.Resources.no_image
            End Try
            NameItem.Text = a.Name
        End If
        Me.dataRow = dataRow
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Item_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.Click, Picture.Click, NameItem.Click
        If e.Button = MouseButtons.Left Then
            Scale(0.9, 0.9)
            If TypeOf dataRow Is CategoryRow Then
                TPVForm.setProducts(CType(dataRow, CategoryRow).idCategory)
            Else
                TPVForm.setDetailTicket(CType(dataRow, ProductRow))
            End If
            Scale(1.11, 1.11)
        End If
    End Sub
End Class
