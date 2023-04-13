Imports System.ComponentModel
Imports ConexionBD.DatosTPV
Imports ConexionBD.DatosTPVTableAdapters
Public Class FacturasRealizadas
    Private id As Integer
    Private Sub FacturasRealizadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim facturas As New FacturasTableAdapter
        facturas.Fill(GestionesDataSet.Facturas)

        Dim lineasFacturas As New LineaFacturaTableAdapter
        lineasFacturas.Fill(GestionesDataSet.LineaFactura)

        Dim ubicacion As New DataTable1TableAdapter
        ubicacion.Fill(GestionesDataSet.DataTable1)

        If id <> 0 Then
            FacturasBindingSource.Position = FacturasBindingSource.Find("idFactura", id)
        End If

        If GestionesDataSet.Facturas.Count = 0 Then
            MsgBox("No se hay facturas realizadas.")
            Me.Close()
        End If
    End Sub
    Public Sub New(id As Integer)
        InitializeComponent()
        Me.id = id
    End Sub
    Private Sub FacturasBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles FacturasBindingSource.PositionChanged
        Dim current As DataRowView = FacturasBindingSource.Current
        If current IsNot Nothing Then
            DataTable1BindingSource.Filter = "idPC = " & current.Row.Item(6)
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Close()
    End Sub

    Private Sub FacturasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles FacturasBindingNavigatorSaveItem.Click
        Dim facturas As New FiltradorFacturasRealizadas
        facturas.ShowDialog()
        FacturasBindingSource.Position = FacturasBindingSource.Find("idFactura", facturas.getID)
    End Sub

    Private Sub FacturasRealizadas_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If id = 0 Then
            Facturar.Show()
        End If
    End Sub
End Class