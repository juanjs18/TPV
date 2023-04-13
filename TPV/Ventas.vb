Imports ConexionBD.DatosTPVTableAdapters
Imports ProcesosEmpresariales

Public Class Ventas
    Private tickets As TicketTableAdapter

    Private Sub Ventas_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        MenuFacturacion.Show()
    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatosTPV = MenuPrincipal.DatosTPV1
        TicketBindingSource.DataSource = DatosTPV.Ticket
        ToolStripComboBox1.SelectedIndex = 0
        DateTimePicker1.Value = Today
    End Sub

    Private Sub TicketDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TicketDataGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim detail As New DetalleTicket(TicketBindingSource.Current, DatosTPV)
            detail.ShowDialog()
            ToolStripComboBox1_Changed(Nothing, Nothing)
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)
        If TicketBindingSource.Count > 0 Then
            If MsgBox(Constantes.MESSAGE_DELETE_PRODUCT, vbOKCancel, Constantes.WARNING_DELETE) = MsgBoxResult.Ok Then
                TicketBindingSource.RemoveCurrent()
                TicketBindingSource.EndEdit()
                tickets.Update(DatosTPV.Ticket)
            End If
        End If
    End Sub

    Private Sub ToolStripComboBox1_Changed(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        If ToolStripComboBox1.SelectedIndex = 0 Then
            TicketBindingSource.Filter = "Parada = 'False' AND Closed = 'False'"
        Else
            TicketBindingSource.Filter = "Parada = 'False' AND Closed = 'True'"
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.KeyCode.Enter Then
            Try
                ToolStripComboBox1_Changed(Nothing, Nothing)
                TicketBindingSource.Filter += " AND TicketCode = " & Integer.Parse(TextBox1.Text)
            Catch ex As Exception
                ToolStripComboBox1_Changed(Nothing, Nothing)
                MsgBox(Constantes.NO_RESOULT)
            End Try
            If TicketBindingSource.Count = 0 Then
                ToolStripComboBox1_Changed(Nothing, Nothing)
                MsgBox(Constantes.NO_RESOULT)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ToolStripComboBox1_Changed(Nothing, Nothing)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DateTimePicker1.Value = Today
        ToolStripComboBox1_Changed(Nothing, Nothing)
    End Sub

    Private Sub DateTimePicker1_CloseUp(sender As Object, e As EventArgs) Handles DateTimePicker1.CloseUp
        ToolStripComboBox1_Changed(Nothing, Nothing)
        TicketBindingSource.Filter += " AND (Date >= '" & DateTimePicker1.Value & "'" & " AND Date < '" & DateTimePicker1.Value.AddDays(1) & "')"
        If TicketBindingSource.Count = 0 Then
            ToolStripComboBox1_Changed(Nothing, Nothing)
            MsgBox(Constantes.NO_RESOULT)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class