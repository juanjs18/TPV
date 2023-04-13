Imports ConexionBD.DatosTPV
Imports ConexionBD.DatosTPVTableAdapters

Public Class DetalleTickets
    Implements GestionarDatos
    Private adapter As TicketDetailTableAdapter
    Public table As TicketDetailDataTable

    Public Sub New()
        adapter = New TicketDetailTableAdapter
        table = adapter.GetData
    End Sub

    Public Function save() As Boolean Implements GestionarDatos.save
        Return adapter.Update(table)
    End Function

    Sub delete(row As DataRowView) Implements GestionarDatos.delete
    End Sub

    Public Sub newRow() Implements GestionarDatos.addRow
        Dim row As TicketDetailRow = table.NewTicketDetailRow
        table.AddTicketDetailRow(row)
    End Sub
End Class
