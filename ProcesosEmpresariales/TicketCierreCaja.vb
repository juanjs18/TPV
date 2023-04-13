Imports ConexionBD.DatosTPV

Public Class TicketCierreCaja
    Private row As CierresCajaRow
    Private linias As List(Of TicketDetailRow)

    Public Sub New(row As CierresCajaRow, linias As List(Of TicketDetailRow))
        Me.row = row
        Me.linias = linias
    End Sub

    ' Funcion que saca el ticket de cierre de caja
    Public Function ticket() As String
        Dim text As String = ""
        text += head() & vbCrLf
        text += "---------------------------------------" & vbCrLf & vbCrLf
        text += totales() & vbCrLf
        text += "---------------------------------------" & vbCrLf & vbCrLf
        text += "Detalle linias: " & vbCrLf & vbCrLf & Tickets.textLiniasTicket(linias.ToArray) & vbCrLf
        text += "---------------------------------------" & vbCrLf & vbCrLf
        text += bottom() & vbCrLf
        Return text
    End Function
    ' Retorna un string con el encabezado del cierre de caja
    Private Function head() As String
        Dim text As String = ""
        text += "Cierre - " & row.Fecha & vbCrLf
        text += "Ticket Inicial: " & row.TicketIni & vbCrLf
        text += "Ticket Final: " & row.TicketFin & vbCrLf
        Return text
    End Function
    ' Retorna un string con el detalle de los totales de cierre de caja
    Private Function totales() As String
        Dim text As String = ""
        text += "Total: " & Format(row.Total, Constantes.FORMAT_PRICE) & vbCrLf
        text += "Total IVA: " & Format(row.TotalIVA, Constantes.FORMAT_PRICE) & vbCrLf
        text += "IVA: " & Format(row.IVA, "0.00") & vbCrLf & vbCrLf
        text += "---------------------------------------" & vbCrLf & vbCrLf
        text += "Total efectivo: " & Format(row.TotalEfectivo, Constantes.FORMAT_PRICE) & vbCrLf
        text += "Total tarjeta: " & Format(row.TotalTarjeta, Constantes.FORMAT_PRICE) & vbCrLf
        Return text
    End Function
    ' Retorna un string con el pie del cierre de caja
    Private Function bottom() As String
        Dim text As String = ""
        text += "Caja: " & Format(row.CajaActual, Constantes.FORMAT_PRICE) & vbCrLf
        text += "Caja anterior: " & Format(row.CajaAnterior, Constantes.FORMAT_PRICE) & vbCrLf
        Return text
    End Function
End Class
