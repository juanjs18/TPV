Imports ConexionBD
Imports ConexionBD.DatosTPV
Imports ConexionBD.DatosTPVTableAdapters

Public Class Regularizacion
    Implements GestionarDatos
    Private ds As DatosTPV
    Private adapter As RegularizacionTableAdapter

    Public Sub New(ds As DatosTPV)
        Me.ds = ds
        adapter = New RegularizacionTableAdapter
    End Sub

    Public Sub delete(row As DataRowView) Implements GestionarDatos.delete
        Dim rowRe As RegularizacionRow = ds.Regularizacion.FindByIDRegularizacion(row.Row.Item(0))
        Dim adapterP As New ProductTableAdapter
        Dim productRow As ProductRow = ds.Product.FindByProductCode(rowRe.ProductCode)
        productRow.Stock -= rowRe.Cantidad
        adapterP.Update(productRow)
        rowRe.Delete()
        adapter.Update(ds.Regularizacion)
    End Sub

    Public Sub addRow() Implements GestionarDatos.addRow
        Throw New NotImplementedException()
    End Sub
    Public Function modify(id As Integer) As Boolean
        Dim row As RegularizacionRow = ds.Regularizacion.FindByIDRegularizacion(id)
        Return guardar(row)
    End Function
    Private Function guardar(row As RegularizacionRow) As Boolean
        Dim adapterP As New ProductTableAdapter
        Dim productRow As ProductRow = ds.Product.FindByProductCode(row.ProductCode)
        Try
            productRow.Stock += row.Cantidad
        Catch ex As Exception
            cantidad(row, productRow)
            productRow.Stock = row.Inventario
        End Try
        adapterP.Update(ds.Product)
        Return adapter.Update(ds.Regularizacion)
    End Function
    Public Function save() As Boolean Implements GestionarDatos.save
        Dim row As RegularizacionRow = ds.Regularizacion.Last
        Return guardar(row)
    End Function
    Private Sub cantidad(row As RegularizacionRow, productRow As ProductRow)
        If productRow.Stock > row.Inventario Then
            row.Cantidad = productRow.Stock - row.Inventario
        Else
            row.Cantidad = row.Inventario - productRow.Stock
        End If
    End Sub
    Public Sub regularizar(motivo As String, productCode As String, cantidad As Integer, fecha As Date)
        Dim productRow As ProductRow = ds.Product.FindByProductCode(productCode)
        Dim adapterP As New ProductTableAdapter
        Dim row As RegularizacionRow = ds.Regularizacion.NewRegularizacionRow
        row.Motivo = motivo
        row.ProductCode = productCode
        row.Cantidad = 0 - cantidad
        row.Fecha = fecha
        row.Manual = False
        productRow.Stock += row.Cantidad
        ds.Regularizacion.AddRegularizacionRow(row)
        adapterP.Update(productRow)
        adapter.Update(ds.Regularizacion)
    End Sub
End Class