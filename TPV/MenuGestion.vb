Public Class MenuGestion
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        GestionProductos.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        GestionCategorias.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub MenuGestion_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        MenuPrincipal.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Ventas.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Dim gest As New ListadoCierres
        gest.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        GestionClientes.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub BtnProductosInhabilitados_Click(sender As Object, e As EventArgs) Handles BtnProductosInhabilitados.Click
        DisabledProducts.Show()
        Me.Hide()
    End Sub
End Class