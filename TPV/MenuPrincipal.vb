Imports System.Data.Common
Imports ConexionBD
Imports ProcesosEmpresariales

Public Class MenuPrincipal
    Private Sub ButtonSell_Click(sender As Object, e As EventArgs) Handles ButtonSell.Click
        Me.Hide()
        TPVForm.Show()
    End Sub

    Private Sub ButtonGestion_Click(sender As Object, e As EventArgs) Handles ButtonGestion.Click
        Me.Hide()
        MenuGestion.Show()
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Me.Close()
    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileManagement.haveDirectories()
        Dim data As New LoadData(DatosTPV1)
        data.ShowDialog()
        reset()
    End Sub

    Private Sub ButtonConfig_Click(sender As Object, e As EventArgs) Handles ButtonConfig.Click
        Config.Show()
        Me.Hide()
    End Sub

    Public Sub reset()
        Me.BackColor = My.Settings.ColorP
        ButtonExit.BackColor = My.Settings.ColorS
        ButtonConfig.BackColor = My.Settings.ColorS
        ButtonGestion.BackColor = My.Settings.ColorS
        ButtonSell.BackColor = My.Settings.ColorS
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MenuFacturacion.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GestionClientes.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MenuInventario.Show()
        Me.Hide()
    End Sub
End Class
