Imports ConexionBD.DatosTPV
Imports ConexionBD.DatosTPVTableAdapters

Public Class Productos
    Implements GestionarDatos
    Private adapter As ProductTableAdapter
    Public table As ProductDataTable

    Public Sub New(dt As DataTable)
        adapter = New ProductTableAdapter
        table = dt
    End Sub

    Public Function save() As Boolean Implements GestionarDatos.save
        adapter.Update(table)
    End Function

    Public Sub delete(row As DataRowView) Implements GestionarDatos.delete
        row.Row.Item(6) = False
    End Sub

    Public Sub addRow() Implements GestionarDatos.addRow
        Dim row As ProductRow = table.NewProductRow
        row.Enabled = True
        row.Price = 0
        row.idCategory = 1
        row.ProductCode = -1
        row.Name = ""
        table.AddProductRow(row)
    End Sub
End Class