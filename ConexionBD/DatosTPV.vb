Imports System.ComponentModel
Imports ConexionBD.DatosTPVTableAdapters

Partial Class DatosTPV

    Partial Public Class ProductDataTable

    End Class

    Public Sub getData(w As BackgroundWorker)
        Dim adapterT As New TicketTableAdapter
        adapterT.Fill(Me.Ticket)
        w.ReportProgress(1, "Cargando tickets.")
        Dim adapterTD As New TicketDetailTableAdapter
        adapterTD.Fill(Me.TicketDetail)
        w.ReportProgress(1, "Cargando linias ticket.")
        Dim adapterP As New ProductTableAdapter
        adapterP.Fill(Me.Product)
        w.ReportProgress(1, "Cargando productos.")
        Dim adapterD As New CategoryTableAdapter
        adapterD.Fill(Me.Category)
        w.ReportProgress(1, "Cargando categorias.")
        Dim adapterCierre As New CierresCajaTableAdapter
        adapterCierre.Fill(Me.CierresCaja)
        w.ReportProgress(1, "Cargando cierres de caja.")
        Dim adapterClientes As New ClientesTableAdapter
        adapterClientes.Fill(Me.Clientes)
        w.ReportProgress(1, "Cargando Clientes")
        Dim adapterUsuarios As New UsersTableAdapter
        adapterUsuarios.Fill(Me.Users)
        w.ReportProgress(1, "Cargando usuarios.")
        Dim adapterCiudades As New CiudadesTableAdapter
        adapterCiudades.Fill(Me.Ciudades)
        w.ReportProgress(1, "Cargando ciudades.")
        Dim adapterCountries As New CountriesTableAdapter
        adapterCountries.Fill(Me.Countries)
        w.ReportProgress(1, "Cargando paises.")
        Dim adapterDT1 As New DataTable1TableAdapter
        adapterDT1.Fill(Me.DataTable1)
        w.ReportProgress(1, "Cargando direcciones.")
    End Sub
End Class
