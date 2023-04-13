Imports ConexionBD.DatosTPV
Imports ConexionBD.DatosTPVTableAdapters
Public Class FiltradorFacturasRealizadas

    Private idFactura As Integer = 0

    Public Function getID() As Integer
        Return idFactura
    End Function

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub FiltradorFacturasRealizadas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim facturas As New FacturasTableAdapter
        facturas.Fill(GestionesDataSet.Facturas)
    End Sub

    Private Sub RBtnFactura_Click(sender As Object, e As EventArgs) Handles RBtnFactura.Click
        TBoxFiltrar.Enabled = True
        DateTimePicker1.Enabled = False
    End Sub

    Private Sub RBtnFecha_Click(sender As Object, e As EventArgs) Handles RBtnFecha.Click
        TBoxFiltrar.Enabled = False
        DateTimePicker1.Enabled = True
    End Sub

    Private Sub RBtnNif_Click(sender As Object, e As EventArgs) Handles RBtnNif.Click
        TBoxFiltrar.Enabled = True
        DateTimePicker1.Enabled = False
    End Sub

    Private Sub TBoxFiltrar_TextChanged(sender As Object, e As EventArgs) Handles TBoxFiltrar.TextChanged
        If Not String.IsNullOrEmpty(TBoxFiltrar.Text) Then
            If RBtnFactura.Checked Then
                FacturasBindingSource.Filter = "idFactura = " & TBoxFiltrar.Text
            Else
                FacturasBindingSource.Filter = "nif like '%" & TBoxFiltrar.Text & "%'"
            End If
        Else
            FacturasBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        FacturasBindingSource.Filter = "fecha = '" & DateTimePicker1.Value.ToShortDateString & "'"
    End Sub

    Private Sub BtnQuitarFiltro_Click(sender As Object, e As EventArgs) Handles BtnQuitarFiltro.Click
        DateTimePicker1.Value = Today
        TBoxFiltrar.Text = ""
        FacturasBindingSource.RemoveFilter()
    End Sub

    Private Sub FacturasDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles FacturasDataGridView.DoubleClick
        If GestionesDataSet.Facturas.Count > 0 Then
            idFactura = FacturasDataGridView.CurrentRow.Cells(0).Value
        End If
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class