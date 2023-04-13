Imports System.ComponentModel

Public Class MenuFacturacion
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Ventas.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListadoCierres.Show()
        Me.Hide()
    End Sub

    Private Sub MenuFacturacion_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MenuPrincipal.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Albaran.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Facturar.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        TotalesVentasProductos.Show()
    End Sub
End Class