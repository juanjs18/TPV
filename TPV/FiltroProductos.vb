Imports ConexionBD.DatosTPV
Imports ConexionBD.DatosTPVTableAdapters

Public Class FiltroProductos
    Private idProducto As String = Nothing
    Private idCat As Integer
    Private opcion As Integer
    Private filtro_enabled = "Enabled = 'True'"
    Private filtro_stockable = "Stockable = 'True'"
    Private filtro_no_stockable = "Stockable = 'False'"
    Private filtro_vendible = "Vendible = 'True'"
    Private filtro_no_vendible = "Vendible = 'False'"
    Private filtro_id As String
    Private filtro_name As String
    Private filtro_category As String
    Private default_filter = filtro_enabled + " AND " + filtro_stockable + " AND " + filtro_vendible
    Private vendible_noStockable = filtro_enabled + " AND " + filtro_vendible + " AND " + filtro_no_stockable
    Private stockable_noVendible = filtro_enabled + " AND " + filtro_stockable + " AND " + filtro_no_vendible
    Private noVendible_noStockable = filtro_enabled + " AND " + filtro_no_stockable + " AND " + filtro_no_vendible

    Public Function getID() As String
        Return idProducto
    End Function

    Public Sub New(opcion As Integer)
        InitializeComponent()
        filtro_id = "ProductCode like '%" + TBoxProductos.Text + "%'"
        filtro_name = "Name like '%" + TBoxProductos.Text + "%'"
        filtro_category = "idCategory = " & idCat
        Me.opcion = opcion
    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim productos = New ProductTableAdapter
        productos.Fill(GestionesDataSet.Product)

        ProductBindingSource.Filter = default_filter

        'Opción 0 = Todo. Opción 1 = Stockables. Opción 2 = Vendibles
        If opcion = 1 Then
            RBtnNoStockable.Enabled = False
            RBtnStockable.Enabled = False
        ElseIf opcion = 2 Then
            RBtnVendible.Enabled = False
            RBtnNoVendible.Enabled = False
        End If
    End Sub

    Private Sub ProductDataGridView_DoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductDataGridView.CellClick
        If e.RowIndex >= 0 Then
            idProducto = ProductDataGridView.CurrentRow.Cells(0).Value
            Me.Close()
        End If
    End Sub

    Private Sub BtnCategorias_Click(sender As Object, e As EventArgs) Handles BtnCategorias.Click
        Dim cat As New TPV.Categorias
        cat.ShowDialog()
        idCat = cat.getID
        Dim filtroUtilizado As String = ""
        filtro_category = "idCategory = " & idCat

        If idCat <> 0 Then
            Dim rows() As ProductRow

            If RBtnStockable.Checked And RBtnVendible.Checked Then
                rows = GestionesDataSet.Product.Select(filtro_category + " AND " + default_filter)
                filtroUtilizado = filtro_category + " AND " + default_filter
            ElseIf RBtnStockable.Checked And RBtnNoVendible.Checked Then
                rows = GestionesDataSet.Product.Select(filtro_category + " AND " + stockable_noVendible)
                filtroUtilizado = filtro_category + " AND " + stockable_noVendible
            ElseIf RBtnNoStockable.Checked And RBtnVendible.Checked Then
                rows = GestionesDataSet.Product.Select(filtro_category + " AND " + vendible_noStockable)
                filtroUtilizado = filtro_category + " AND " + vendible_noStockable
            ElseIf RBtnNoVendible.Checked And RBtnNoStockable.Checked Then
                rows = GestionesDataSet.Product.Select(filtro_category + " AND " + noVendible_noStockable)
                filtroUtilizado = filtro_category + " AND " + noVendible_noStockable
            End If

            If rows.Length > 0 Then
                ProductBindingSource.Filter = filtroUtilizado
            Else
                MsgBox("No hay productos en esta categoria.")
            End If
        End If
    End Sub

    Private Sub FilterNoCategory()
        If RBtnID.Checked And RBtnStockable.Checked And RBtnVendible.Checked Then
            ProductBindingSource.Filter = default_filter + " AND " + filtro_id
        ElseIf RBtnNombre.Checked And RBtnStockable.Checked And RBtnVendible.Checked Then
            ProductBindingSource.Filter = default_filter + " AND " + filtro_name
        ElseIf RBtnID.Checked And RBtnVendible.Checked And RBtnNoStockable.Checked Then
            ProductBindingSource.Filter = vendible_noStockable + " AND " + filtro_id
        ElseIf RBtnNombre.Checked And RBtnVendible.Checked And RBtnNoStockable.Checked Then
            ProductBindingSource.Filter = vendible_noStockable + " AND " + filtro_name
        ElseIf RBtnID.Checked And RBtnNoVendible.Checked And RBtnStockable.Checked Then
            ProductBindingSource.Filter = stockable_noVendible + " AND " + filtro_id
        ElseIf RBtnNombre.Checked And RBtnNoVendible.Checked And RBtnStockable.Checked Then
            ProductBindingSource.Filter = stockable_noVendible + " AND " + filtro_name
        ElseIf RBtnID.Checked And RBtnNoVendible.Checked And RBtnNoStockable.Checked Then
            ProductBindingSource.Filter = noVendible_noStockable + " AND " + filtro_id
        ElseIf RBtnNombre.Checked And RBtnNoVendible.Checked And RBtnNoStockable.Checked Then
            ProductBindingSource.Filter = noVendible_noStockable + " AND " + filtro_name
        End If
    End Sub

    Private Sub FilterCategory()
        If RBtnID.Checked And RBtnStockable.Checked And RBtnVendible.Checked Then
            ProductBindingSource.Filter = default_filter + " AND " + filtro_id + " AND " + filtro_category
        ElseIf RBtnNombre.Checked And RBtnStockable.Checked And RBtnVendible.Checked Then
            ProductBindingSource.Filter = default_filter + " AND " + filtro_name + " AND " + filtro_category
        ElseIf RBtnID.Checked And RBtnVendible.Checked And RBtnNoStockable.Checked Then
            ProductBindingSource.Filter = vendible_noStockable + " AND " + filtro_id + " AND " + filtro_category
        ElseIf RBtnNombre.Checked And RBtnVendible.Checked And RBtnNoStockable.Checked Then
            ProductBindingSource.Filter = vendible_noStockable + " AND " + filtro_name + " AND " + filtro_category
        ElseIf RBtnID.Checked And RBtnNoVendible.Checked And RBtnStockable.Checked Then
            ProductBindingSource.Filter = stockable_noVendible + " AND " + filtro_id + " AND " + filtro_category
        ElseIf RBtnNombre.Checked And RBtnNoVendible.Checked And RBtnStockable.Checked Then
            ProductBindingSource.Filter = stockable_noVendible + " AND " + filtro_name + " AND " + filtro_category
        ElseIf RBtnID.Checked And RBtnNoVendible.Checked And RBtnNoStockable.Checked Then
            ProductBindingSource.Filter = noVendible_noStockable + " AND " + filtro_id + " AND " + filtro_category
        ElseIf RBtnNombre.Checked And RBtnNoVendible.Checked And RBtnNoStockable.Checked Then
            ProductBindingSource.Filter = noVendible_noStockable + " AND " + filtro_name + " AND " + filtro_category
        End If
    End Sub

    Private Sub BtnProductos_Click(sender As Object, e As EventArgs) Handles BtnProductos.Click
        If Not String.IsNullOrEmpty(TBoxProductos.Text) Then
            If idCat = 0 Then
                FilterNoCategory()
            Else
                FilterCategory()
            End If
        Else
            ProductBindingSource.RemoveFilter()
            If RBtnStockable.Checked And RBtnVendible.Checked Then
                ProductBindingSource.Filter = default_filter
            ElseIf RBtnStockable.Checked And RBtnNoVendible.Checked Then
                ProductBindingSource.Filter = stockable_noVendible
            ElseIf RBtnNoStockable.Checked And RBtnVendible.Checked Then
                ProductBindingSource.Filter = vendible_noStockable
            ElseIf RBtnNoStockable.Checked And RBtnNoVendible.Checked Then
                ProductBindingSource.Filter = noVendible_noStockable
            End If
        End If
    End Sub

    Private Sub BtnCancelarFiltro_Click(sender As Object, e As EventArgs) Handles BtnCancelarFiltro.Click
        ProductBindingSource.Filter = default_filter
        RBtnStockable.Checked = True
        RBtnVendible.Checked = True
        RBtnID.Checked = True
        idCat = 0
        filtro_category = "idCategory = " & idCat
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub RBtnVendible_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnVendible.CheckedChanged
        If RBtnStockable.Checked Then
            ProductBindingSource.Filter = default_filter
        Else
            ProductBindingSource.Filter = filtro_enabled + " AND " + filtro_no_stockable + " AND " + filtro_vendible
        End If
    End Sub

    Private Sub RBtnStockable_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnStockable.CheckedChanged
        If RBtnVendible.Checked Then
            ProductBindingSource.Filter = default_filter
        Else
            ProductBindingSource.Filter = filtro_enabled + " AND " + filtro_stockable + " AND " + filtro_no_vendible
        End If
    End Sub

    Private Sub RBtnNoVendible_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnNoVendible.CheckedChanged
        If RBtnStockable.Checked Then
            ProductBindingSource.Filter = filtro_enabled + " AND " + filtro_stockable + " AND " + filtro_no_vendible
        Else
            ProductBindingSource.Filter = filtro_enabled + " AND " + filtro_no_stockable + " AND " + filtro_no_vendible
        End If
    End Sub

    Private Sub RBtnNoStockable_CheckedChanged(sender As Object, e As EventArgs) Handles RBtnNoStockable.CheckedChanged
        If RBtnVendible.Checked Then
            ProductBindingSource.Filter = filtro_enabled + " AND " + filtro_no_stockable + " AND " + filtro_vendible
        Else
            ProductBindingSource.Filter = filtro_enabled + " AND " + filtro_no_stockable + " AND " + filtro_no_vendible
        End If
    End Sub
End Class