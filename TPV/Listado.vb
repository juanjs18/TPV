Imports ConexionBD.DatosTPV
Imports ProcesosEmpresariales

Public Class Listado
    Private data As DataTable
    Public row As DataGridViewRow

    Public Sub New(data As DataTable)
        InitializeComponent()
        Me.data = data
    End Sub
    Private Sub Listado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindingSource1.DataSource = data
        If TypeOf data Is ProductDataTable Then
            DatosTPV_ProductDataTableDataGridView1.Visible = True
            DatosTPV_ProductDataTableDataGridView.Visible = False
            DatosTPV_ProductDataTableBindingSource.DataSource = CType(data, ProductDataTable)
            DatosTPV_ProductDataTableBindingSource.Filter = Constantes.FILTER
        Else
            DatosTPV_ProductDataTableDataGridView1.Visible = False
            DatosTPV_ProductDataTableDataGridView.Visible = True
            DatosTPV_CategoryRowBindingSource.DataSource = data
            DatosTPV_CategoryRowBindingSource.Filter = Constantes.FILTER
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DatosTPV_ProductDataTableDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles DatosTPV_ProductDataTableDataGridView.DoubleClick
        If DatosTPV_ProductDataTableDataGridView.RowCount > 0 Then
            Try
                row = DatosTPV_ProductDataTableDataGridView.SelectedRows(0)
            Catch ex As Exception
                row = DatosTPV_ProductDataTableDataGridView.Rows.Item(0)
            End Try
        End If
        Me.Close()
    End Sub

    Private Sub DatosTPV_ProductDataTableDataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DatosTPV_ProductDataTableDataGridView1.DoubleClick
        If DatosTPV_ProductDataTableDataGridView1.RowCount > 0 Then
            Try
                row = DatosTPV_ProductDataTableDataGridView1.SelectedRows(0)
            Catch ex As Exception
                row = DatosTPV_ProductDataTableDataGridView1.Rows.Item(0)
            End Try
        End If
        Me.Close()
    End Sub

End Class