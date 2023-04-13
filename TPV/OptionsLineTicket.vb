Imports ProcesosEmpresariales

Public Class OptionsLineTicket
    Private row As DataRowView
    Public Sub New(row As DataRowView)
        InitializeComponent()
        Me.row = row
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim cantidad As Integer = InputBox(Constantes.INPUT_AMOUNT, , row.Row.Item(4))
            If cantidad <> 0 Then
                TPVForm.totalPrice -= row.Row.Item(3) * row.Row.Item(4)
                row.Row.Item(4) = cantidad
                row.Row.Item(5) = cantidad * row.Row.Item(3)
                TPVForm.totalPrice += row.Row.Item(5)
                TPVForm.totalView.Text = Format(TPVForm.totalPrice, Constantes.FORMAT_PRICE)
                TPVForm.TicketDetailBindingSource.ResetBindings(False)
            Else
                MsgBox(Constantes.ERROR_AMOUNT)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TPVForm.totalPrice -= row.Row.Item(3) * row.Row.Item(4)
        TPVForm.totalView.Text = Format(TPVForm.totalPrice, Constantes.FORMAT_PRICE)
        TPVForm.TicketDetailBindingSource.Remove(row)
        Me.Close()
    End Sub
End Class