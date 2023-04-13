Imports ConexionBD.DatosTPV
Imports ConexionBD.DatosTPVTableAdapters

Public Class Categorias
    Implements GestionarDatos
    Private adapter As CategoryTableAdapter
    Public table As CategoryDataTable

    Public Sub New()
        adapter = New CategoryTableAdapter
        table = adapter.GetData
    End Sub

    Public Function save() As Boolean Implements GestionarDatos.save
        Return adapter.Update(table)
    End Function

    Public Sub delete(row As DataRowView) Implements GestionarDatos.delete
        row.Row.Item(4) = False
    End Sub

    Public Sub newRow() Implements GestionarDatos.addRow
        Dim row As CategoryRow = table.NewCategoryRow
        table.AddCategoryRow(row)
    End Sub
End Class
