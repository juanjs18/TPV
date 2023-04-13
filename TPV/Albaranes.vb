Imports ConexionBD.DatosTPV
Imports ConexionBD.DatosTPVTableAdapters
Public Class Albaranes
    Private idAlbaran As Integer = 0
    Private Const default_filter As String = ""

    Public Function getID() As Integer
        Return idAlbaran
    End Function

    Private Sub Albaranes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim albaranes = New AlbaranTableAdapter
        albaranes.Fill(GestionesDataSet.Albaran)
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub AlbaranDataGridView_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles AlbaranDataGridView.CellFormatting
        If e.ColumnIndex = 0 Then
            AlbaranDataGridView.Columns.Item(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
        If e.ColumnIndex = 2 Then
            AlbaranDataGridView.Columns.Item(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
        If e.ColumnIndex = 3 Then
            e.Value = Format(e.Value, "#,##0.00 €")
            AlbaranDataGridView.Columns.Item(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
    End Sub

    Private Sub AlbaranDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles AlbaranDataGridView.DoubleClick
        If GestionesDataSet.Albaran.Count > 0 Then
            idAlbaran = AlbaranDataGridView.CurrentRow.Cells(0).Value
        End If
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub TBoxFiltrar_TextChanged(sender As Object, e As EventArgs) Handles TBoxFiltrar.TextChanged
        If String.IsNullOrEmpty(TBoxFiltrar.Text) Then
            AlbaranBindingSource.RemoveFilter()
            TBoxFiltrar.Text = ""
        Else
            If RBtnAlbaran.Checked Then
                filtrarAlbaran()
            Else
                filtrarUsuario()
            End If
        End If
    End Sub

    Private Sub filtrarAlbaran()
        Dim albaranes() As AlbaranRow = GestionesDataSet.Albaran.Select("idAlbaran = " & TBoxFiltrar.Text)
        If albaranes.Count > 0 Then
            AlbaranBindingSource.Filter = "idAlbaran = " & TBoxFiltrar.Text
        Else
            MsgBox("ID Albaran no encontrado.")
            TBoxFiltrar.Text = ""
        End If
    End Sub

    Private Sub filtrarUsuario()
        Dim albaranes() As AlbaranRow = GestionesDataSet.Albaran.Select("idUser = " & TBoxFiltrar.Text)
        If albaranes.Count > 0 Then
            AlbaranBindingSource.Filter = "idUser = " & TBoxFiltrar.Text
        Else
            MsgBox("ID Usuario no encontrado.")
            TBoxFiltrar.Text = ""
        End If
    End Sub
End Class