Public Class ProductoCantidadRegularizar
    Property productCode As String
    Property cantidad As Integer
    Public Sub New(productCode As String, cantidad As Integer)
        Me.productCode = productCode
        Me.cantidad = cantidad
    End Sub

    Public Function compareTo(cantidad As Integer) As Integer
        Return Me.cantidad - cantidad
    End Function

    Public Function getQuantityDeleted() As Integer
        Return 0 - Me.cantidad
    End Function

    Public Sub setProductDeleted()
        Me.cantidad = 0 - Me.cantidad
    End Sub
End Class
