Imports System.ComponentModel
Imports ConexionBD.DatosTPVTableAdapters

Public Class ListaCompras
    Private idCompra As Integer
    Public Function getID() As Integer
        Return idCompra
    End Function
    Private Sub ListaCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapter As New ComprasTableAdapter
        adapter.Fill(DatosTPV.Compras)
        idCompra = 0
    End Sub
    Private Sub TboxFiltrar_TextChanged(sender As Object, e As EventArgs) Handles TboxFiltrar.TextChanged
        If IsNumeric(TboxFiltrar.Text) Then
            ComprasBindingSource.Filter = "IDCompra = " & TboxFiltrar.Text
        Else
            TboxFiltrar.Text = ""
            ComprasBindingSource.RemoveFilter()
        End If
    End Sub
    Private Sub ComprasDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ComprasDataGridView.CellClick
        If e.RowIndex >= 0 Then
            idCompra = ComprasDataGridView.Rows(e.RowIndex).Cells(0).Value
            Me.Close()
        End If
    End Sub
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
    Private Sub TboxFiltrar_KeyDown(sender As Object, e As KeyEventArgs) Handles TboxFiltrar.KeyDown
        If e.KeyCode = Keys.Delete Then
            e.Handled = False
        End If
    End Sub
End Class