Imports ConexionBD.DatosTPVTableAdapters

Public Class ListadoCierres
    ' Filtra los cierres de caja cuando se cambia el valor del timepicker
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim fecha As Date = DateTimePicker1.Value
        CierresCajaBindingSource.Filter = "Fecha >= '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "' AND Fecha < '" & fecha.AddDays(1).ToString("yyyy-MM-dd") & "'"
    End Sub
    ' Carga los datos del dataset
    Private Sub ListadoCierres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adapterT As New TicketTableAdapter
        adapterT.Fill(DatosTPV.Ticket)
        Dim adapterTD As New TicketDetailTableAdapter
        adapterTD.Fill(DatosTPV.TicketDetail)
        Dim adapterC As New CierresCajaTableAdapter
        adapterC.Fill(DatosTPV.CierresCaja)
    End Sub

    Private Sub ListadoCierres_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MenuFacturacion.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DateTimePicker1.Value = Today
        CierresCajaBindingSource.RemoveFilter()
    End Sub
    ' Se abre la pantalla con el detalla del cierre de caja
    Private Sub CierresCajaDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CierresCajaDataGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim detalle As New CierreCaja(DatosTPV, False, CType(CierresCajaBindingSource.Current, DataRowView).Row.Item(0))
            detalle.ShowDialog()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class