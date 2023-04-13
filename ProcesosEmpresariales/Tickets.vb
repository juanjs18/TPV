Imports ConexionBD
Imports ConexionBD.DatosTPV
Imports ConexionBD.DatosTPVTableAdapters

Public Class Tickets
    Private Const formatLine As String = "|{0,-15}|{1,-7}|{2,-5}|{3,-7}|"
    Private Const formathead As String = " {0,-15} {1,-7} {2,-5} {3,-7} "
    Private Const formatDown As String = "{0,-20} {1,18}"

    ' Funcion que retorna un String con todo el contenido de un ticket
    Public Shared Function getTicketText(id As Integer, dataSet As DatosTPV, formaPago As Boolean) As String
        Dim ticket As TicketRow = dataSet.Ticket.FindByTicketCode(id)
        If ticket IsNot Nothing Then
            Dim conf As Configuracion = Configuracion.returnConfig
            Dim text As String = ""
            text += header()
            Try
                If Not IsDBNull(ticket.idUser) Then
                    text += client(dataSet, ticket.idUser)
                End If
            Catch ex As Exception
            End Try
            text += vbCrLf & String.Format(formatDown, "Num. Tick: " & ticket.TicketCode, "Fecha: " & ticket._Date.ToString("dd/MM/yyyy")) & vbCrLf
            Dim lines As TicketDetailRow() = dataSet.TicketDetail.Select("TicketCode = " & id)
            text += textLiniasTicket(lines)
            text += vbCrLf & String.Format(formatDown, "SubTotal: " & Format(ticket.TotalCost - ticket.TotalIVA, "0.00"), "% IVA: " & Format(conf.IVA * 100, "0.00")) & vbCrLf
            text += String.Format(formatDown, "Total: " & Format(ticket.TotalCost, "0.00"), "IVA: " & Format(ticket.TotalIVA, "0.00")) & vbCrLf
            If formaPago Then
                If ticket.Efectivo Then
                    text += "Cobrado en efectivo." & vbCrLf
                Else
                    text += "Cobrado en tarjeta." & vbCrLf
                End If
            End If
            text += vbCrLf & vbCrLf & lineHead("***Gracias por su visita***")
            Return text
        End If
        Return Nothing
    End Function
    ' Devuelve el texto con el detalle de las linias de ticket
    Public Shared Function textLiniasTicket(lines As TicketDetailRow()) As String
        Dim text As String = ""
        text += vbCrLf & String.Format(formathead, "Producto", "Precio", "Unid.", "Total") & vbCrLf
        text += "---------------------------------------" & vbCrLf
        For Each row As TicketDetailRow In lines
            Dim proName = row.NameProduct
            If proName.Length > 15 Then
                proName = proName.Substring(0, 15)
            End If
            text += String.Format(formatLine, proName, Format(row.IndvPrice, "0.00"), row.Amount, Format(row.TotalPrice, "0.00")) & vbCrLf
        Next
        text += "---------------------------------------" & vbCrLf
        Return text
    End Function

    ' Retorna el texto del ticket con la información del cliente asociado
    Private Shared Function client(dataSet As DatosTPV, idClient As Integer) As String
        Dim cliente As ClientesRow = dataSet.Clientes.FindByidUser(idClient)
        Dim text As String = ""
        If cliente IsNot Nothing Then
            text += vbCrLf & "Información cliente" & vbCrLf
            text += "---------------------------------------" & vbCrLf
            text += "N.I.F: " & cliente.nif & vbCrLf
            text += "Nombre: " & cliente.name & vbCrLf
            text += "Población: " + cliente.nameCity & ", " & cliente.postalCode & vbCrLf
            text += "Calle: " + cliente.street & vbCrLf
            text += "---------------------------------------" & vbCrLf
        End If
        Return text
    End Function

    ' Retorna el texto del encabezado del ticket
    Public Shared Function header() As String
        Dim conf As Configuracion = Configuracion.returnConfig
        Dim text As String = ""
        text += lineHead(conf.City) & vbCrLf
        text += lineHead(conf.PC) & vbCrLf
        text += lineHead(conf.Street + ", " + conf.Door) & vbCrLf
        text += lineHead("Telf.: " & conf.Telefono) & vbCrLf
        text += lineHead("NIF: " & conf.NIF) & vbCrLf

        Return text
    End Function

    ' Retorna el titulo del ticket
    Public Shared Function textEmpresa(empresa As String) As String
        Dim lados As Integer = (20 - empresa.Length) \ 2
        Return String.Format("{0," & lados & "}{1," & empresa.Length & "}" & "{2," & lados & "}", "", empresa, "") & vbCrLf
    End Function

    ' Centra un string segun los caracteres del ticket
    Public Shared Function lineHead(value As String) As String
        Dim lados As Integer = (40 - value.Length) \ 2
        Return String.Format("{0," & lados & "}{1," & value.Length & "}" & "{2," & lados & "}", "", value, "")
    End Function

    ' Funcion que guarda o actualiza un ticket en la base de datos con sus respectivas linias
    Public Shared Sub newTickets(bst As BindingSource, bsdt As BindingSource, adaptert As TicketTableAdapter, adapterd As TicketDetailTableAdapter, ds As DatosTPV, parado As Boolean, price As Double, client As Integer, efectivo As Boolean)
        Dim conf As Configuracion = Configuracion.returnConfig
        bsdt.EndEdit()
        CType(bst.Current, DataRowView).Row.Item(8) = efectivo
        If client > 0 Then
            CType(bst.Current, DataRowView).Row.Item(7) = client
        End If
        CType(bst.Current, DataRowView).Row.Item(2) = price
        CType(bst.Current, DataRowView).Row.Item(3) = CType(bst.Current, DataRowView).Row.Item(2) * conf.IVA
        CType(bst.Current, DataRowView).Row.Item(4) = parado
        CType(bst.Current, DataRowView).Row.Item(6) = False
        'If Not parado Then

        'End If
        bst.EndEdit()
        adaptert = New TicketTableAdapter
        adapterd = New TicketDetailTableAdapter
        adaptert.Update(ds.Ticket)
        Dim id As Integer = CType(ds.Ticket.Rows.Item(ds.Ticket.Rows.Count - 1), TicketRow).TicketCode
        setID(ds.TicketDetail, id)
        setRegularizaciones(ds, id)
        adapterd.Update(ds.TicketDetail)
    End Sub

    ' Funcion que pone las ID a las linias de ticket
    Public Shared Sub setID(dt As TicketDetailDataTable, id As Integer)
        For Each linia As TicketDetailRow In dt.Select("TicketCode < 0")
            linia.TicketCode = id
        Next
    End Sub

    Public Shared Sub setRegularizaciones(ds As DatosTPV, id As Integer)
        Dim td As TicketDetailRow() = ds.TicketDetail.Select("TicketCode = " & id)
        Dim adapterR As New RegularizacionTableAdapter
        Dim regul As New Regularizacion(ds)
        For Each row As TicketDetailRow In td
            regul.regularizar(Constantes.REGULARIZACION_VENTA, row.ProductCode, row.Amount, Today)
        Next
        adapterR.Update(ds.Regularizacion)
    End Sub

    ' Funcion para actualizar una linia de ticket
    Public Shared Sub updateTicket(bst As BindingSource, adaptert As TicketTableAdapter, ds As DatosTPV)
        adaptert = New TicketTableAdapter
        bst.EndEdit()
        adaptert.Update(ds.Ticket)
    End Sub
End Class