Imports ConexionBD.DatosTPV
Imports ConexionBD.DatosTPVTableAdapters
Public Class Empresa
    Private idUser As Integer = 0

    Public Function getID() As Integer
        Return idUser
    End Function

    Public Sub setID(idUser)
        Me.idUser = idUser
    End Sub
    Public Sub New()
        InitializeComponent()
        Me.idUser = 0
    End Sub

    Private Sub Empresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim empresa As New UsersTableAdapter
        empresa.Fill(GestionesDataSet.Users)
    End Sub

    Private Sub UsersDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles UsersDataGridView.DoubleClick
        If GestionesDataSet.Users.Count Then
            idUser = UsersDataGridView.CurrentRow.Cells(0).Value
        End If
        Me.Close()
    End Sub

    Private Sub filtrar()
        If Not String.IsNullOrEmpty(TBoxFiltrar.Text) Then
            Dim row() As UsersRow = GestionesDataSet.Users.Select("name like '%" & TBoxFiltrar.Text & "%'")
            If row.Length > 0 Then
                UsersBindingSource.Filter = "name like '%" & TBoxFiltrar.Text & "%'"
            Else
                row = GestionesDataSet.Users.Select("nif like '%" & TBoxFiltrar.Text & "%'")
                If row.Length > 0 Then
                    UsersBindingSource.Filter = "nif like '%" & TBoxFiltrar.Text & "%'"
                Else
                    MsgBox("Empresa no encontrada.")
                    TBoxFiltrar.Text = ""
                    UsersBindingSource.RemoveFilter()
                End If
            End If
        Else
            UsersBindingSource.RemoveFilter()
        End If
    End Sub

    Private Sub BtnFiltrar_Click(sender As Object, e As EventArgs) Handles BtnFiltrar.Click
        filtrar()
    End Sub

    Private Sub TBoxFiltrar_KeyUp(sender As Object, e As KeyEventArgs) Handles TBoxFiltrar.KeyUp
        filtrar()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class