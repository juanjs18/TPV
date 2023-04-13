Imports ConexionBD
Imports ConexionBD.DatosTPV
Imports ConexionBD.DatosTPVTableAdapters

Public Class Users
    Implements GestionarDatos
    Private ds As DatosTPV
    Private adapter As UsersTableAdapter

    Public Sub New(ds As DatosTPV)
        Me.ds = ds
        adapter = New UsersTableAdapter
    End Sub

    Public Sub delete(row As DataRowView) Implements GestionarDatos.delete
        Dim albaranes() As AlbaranRow = ds.Albaran.Select("idUser  = " & row.Row.Item(0) & " AND facturada = 'False'")
        Dim tickets() As TicketRow = ds.Ticket.Select("idUser = " & row.Row.Item(0) & " AND Parada = 'False'")
        If albaranes.Count = 0 And tickets.Count = 0 Then
            ds.Users.FindByidUser(row.Row.Item(0)).Delete()
            save()
        Else
            MsgBox("Debe eliminar o cobrar los tickets/albaranes pendientes antes de eliminar un usuario.")
        End If
    End Sub

    Public Sub addRow() Implements GestionarDatos.addRow
        Throw New NotImplementedException()
    End Sub

    Public Function save() As Boolean Implements GestionarDatos.save
        adapter.Update(ds.Users)
    End Function
End Class
