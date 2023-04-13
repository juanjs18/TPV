Imports ConexionBD.DatosTPV
Imports ConexionBD.DatosTPVTableAdapters

Public Class CierresCaja
    Private lines As TicketRow()
    Private adapter As TicketTableAdapter
    Public Sub New(lines As TicketRow(), adapter As TicketTableAdapter)
        Me.lines = lines
        Me.adapter = adapter
    End Sub
    Public Sub cerrarTickets()
        For Each row As TicketRow In lines
            row.Closed = True
        Next
        adapter.Update(lines)
    End Sub
End Class
