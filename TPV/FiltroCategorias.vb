Imports ConexionBD.DatosTPV
Imports ConexionBD.DatosTPVTableAdapters
Public Class Categorias
    Private idCategory As Integer
    Private Sub Categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim categorias As New CategoryTableAdapter
        categorias.Fill(GestionesDataSet.Category)

        CategoryBindingSource.Filter = "Enabled = 'True'"
    End Sub

    Public Sub New()
        InitializeComponent()
        idCategory = 0
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        If Not String.IsNullOrEmpty(TBoxFiltrar.Text) Then
            Dim row() As CategoryRow = GestionesDataSet.Category.Select("Name like '%" & TBoxFiltrar.Text & "%' AND Enabled = 'True'")
            If row.Length > 0 Then
                CategoryBindingSource.Filter = "Name like '%" & TBoxFiltrar.Text & "%' AND Enabled = 'True'"
            Else
                row = GestionesDataSet.Category.Select("Description like '%" & TBoxFiltrar.Text & "%' AND Enabled = 'True'")
                If row.Length > 0 Then
                    CategoryBindingSource.Filter = "Description like '%" & TBoxFiltrar.Text & "%' AND Enabled = 'True'"
                Else
                    Try
                        row = GestionesDataSet.Category.Select("idCategory = " & TBoxFiltrar.Text & " AND Enabled = 'True'")
                        CategoryBindingSource.Filter = "idCategory = " & TBoxFiltrar.Text & " AND Enabled = 'True'"
                    Catch ex As Exception
                        MsgBox("Categoria no encontrada.")
                    End Try
                End If
            End If
        Else
            CategoryBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub CategoryDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles CategoryDataGridView.DoubleClick
        If GestionesDataSet.Category.Count Then
            idCategory = CategoryDataGridView.CurrentRow.Cells(0).Value
        End If
        Me.Close()
    End Sub

    Public Function getID() As Integer
        Return idCategory
    End Function

    Public Shared Widening Operator CType(v As ProcesosEmpresariales.Categorias) As Categorias
        Throw New NotImplementedException()
    End Operator

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class