Imports ConexionBD

Public Class NavigatorHandlers
    ' Event per el binding navigator per guardar els canvis
    Public Shared Sub Save(sender As Object, e As EventArgs)
        Dim data As BindingNavigator = CType(sender, ToolStripButton).Owner
        Dim viewdata As BindingSource = data.BindingSource
        If viewdata.Count > 0 Then
            Dim row As DataRowView = viewdata.Current
            Try
                row.EndEdit()
                Dim a As GestionarDatos = CType(sender, ToolStripButton).Tag
                a.save()
            Catch ex As Exception
                MsgBox(Constantes.MESSAGE_ERROR_UPDATE & vbCrLf & ex.Message, , Constantes.ERROR_TITLE)
            End Try
        End If
    End Sub

    ' Handler per el binding navigator per afegir un nou element
    Public Shared Sub AddRow(sender As Object, e As EventArgs)
        Dim button As ToolStripButton = sender
        Dim navigator As BindingNavigator = button.Owner
        Dim binding As BindingSource = navigator.BindingSource
        Dim a As GestionarDatos = CType(sender, ToolStripButton).Tag
        a.addRow()
        binding.MoveLast()
    End Sub
    ' Event per el binding navigator per eliminar un element
    Public Shared Sub Delete(sender As Object, e As EventArgs)
        Dim a As GestionarDatos = CType(sender, ToolStripButton).Tag
        Dim data As BindingNavigator = CType(sender, ToolStripButton).Owner
        Dim viewdata As BindingSource = data.BindingSource
        If viewdata.Count > 0 Then
            If MsgBox(Constantes.MESSAGE_DELETE_PRODUCT, vbOKCancel, Constantes.WARNING_DELETE) = MsgBoxResult.Ok Then
                a.delete(viewdata.Current)
                viewdata.EndEdit()
                If TypeOf a IsNot Regularizacion Then
                    a.save()
                End If
            End If
        End If
    End Sub
End Class