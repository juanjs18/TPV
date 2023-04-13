Imports System.Globalization
Imports ConexionBD.DatosTPVTableAdapters
Imports ProcesosEmpresariales

Public Class Config

    Private Sub Config_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MenuPrincipal.Show()
    End Sub

    Private Sub setConfig()
        Dim filter As String = "idCountry = {0} AND idCity = {1} AND idPC = {2}"
        Dim config As Configuracion = Configuracion.returnConfig()
        txtConfiguracionEmpresa.Text = config.Empresa
        txtConfiguracionTelefono.Text = config.Telefono
        txtConfiguracionNIF.Text = config.NIF
        txtConfiguracionIVA.Text = (config.IVA * 100).ToString
        TextBox1.Text = config.Street
        TextBox2.Text = config.Door
        LblUbicacion.Text = config.ruta
        If config.idPC > 0 Then
            DataTable1BindingSource.Filter = String.Format(filter, config.idCountry, config.idCity, config.idPC)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim row As DataRowView = DataTable1BindingSource.Current
            If Me.ValidateChildren Then
                Dim config As New Configuracion(txtConfiguracionEmpresa.Text, txtConfiguracionTelefono.Text, txtConfiguracionNIF.Text, Double.Parse(txtConfiguracionIVA.Text.Replace(".", ",")) / 100, row.Row.Item(1), row.Row.Item(3), row.Row.Item(5), row.Row.Item(2), row.Row.Item(0), row.Row.Item(4), TextBox1.Text, TextBox2.Text, LblUbicacion.Text)
                config.saveConfig()
                My.Settings.Save()
                MenuPrincipal.reset()
                Me.Close()
            Else
                MsgBox(Constantes.MESSAGE_ERROR_CONFIG)
            End If
        Catch ex As Exception
            MsgBox(Constantes.ERROR_CONFIG)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        My.Settings.Reload()
        Me.Close()
    End Sub

    Private Sub Config_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatosTPV = MenuPrincipal.DatosTPV1
        DataTable1BindingSource.DataSource = DatosTPV.DataTable1
        setConfig()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim list As New DirectionList(True, DatosTPV, 0)
        list.ShowDialog()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim list As New DirectionList(False, DatosTPV, CType(DataTable1BindingSource.Current, DataRowView).Row.Item(1))
        list.ShowDialog()
        If list.row IsNot Nothing Then
            DataTable1BindingSource.Filter = "idPC = " & list.row.Row.Item(0) & " AND idCity = " & list.row.Row.Item(1) & " AND idCountry = " & list.row.Row.Item(3)
        End If
    End Sub
    Private Sub validateObligatoryFields(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtConfiguracionEmpresa.Validating, txtConfiguracionNIF.Validating, txtConfiguracionTelefono.Validating
        If String.IsNullOrEmpty(CType(sender, TextBox).Text) Then
            ErrorProvider1.SetError(sender, Constantes.MESSAGE_OBLIGATORY_FIELD)
            e.Cancel = True
        End If
        If Not e.Cancel Then
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub
    Private Sub txtConfiguracionIVA_Validating(sender As Control, e As System.ComponentModel.CancelEventArgs) Handles txtConfiguracionIVA.Validating
        If String.IsNullOrEmpty(txtConfiguracionIVA.Text) Then
            ErrorProvider1.SetError(sender, Constantes.MESSAGE_OBLIGATORY_FIELD)
            e.Cancel = True
        Else
            Try
                Dim iva As Double = txtConfiguracionIVA.Text
                If (iva < 0 Or iva > 99) Then
                    ErrorProvider1.SetError(sender, Constantes.MESSAGE_NO_VALID_IVA)
                    e.Cancel = True
                End If
            Catch ex As Exception
                ErrorProvider1.SetError(sender, Constantes.MESSAGE_NO_VALID_IVA)
                e.Cancel = True
            End Try
        End If
        If Not e.Cancel Then
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            My.Settings.ColorP = ColorDialog1.Color
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            Global.TPV.My.MySettings.Default.ColorS = ColorDialog1.Color
        End If
    End Sub

    Private Sub BtnBuscarRuta_Click(sender As Object, e As EventArgs) Handles BtnBuscarRuta.Click
        Dim a As New FolderBrowserDialog

        If a.ShowDialog() = DialogResult.OK Then
            LblUbicacion.Text = a.SelectedPath
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Global.TPV.My.MySettings.Default.Reset()
        Me.Close()
    End Sub

    Private Sub BtnBuscarRuta_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles BtnBuscarRuta.Validating
        If String.IsNullOrEmpty(LblRuta.Text) Then
            e.Cancel = True
            ErrorProvider1.SetError(sender, Constantes.MESSAGE_OBLIGATORY_FIELD)
        End If
        If Not e.Cancel Then
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub
End Class