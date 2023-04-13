Imports System.ComponentModel
Imports ConexionBD.DatosTPV
Imports ConexionBD.DatosTPVTableAdapters
Imports ProcesosEmpresariales

Public Class Compras

    Private adaptadorCompras As ComprasTableAdapter
    Private adaptadorLineasCompra As LineaCompraTableAdapter
    Private adaptadorProductos As ProductTableAdapter
    Private motivoComprar As String = "Compra hecha"
    Private motivoEliminar As String = "Compra devuelta"
    Private movitvoModificarCompra As String = "Compra modificada"
    Private modificaciones As List(Of ProductoCantidadRegularizar)

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Compras_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MenuInventario.Show()
    End Sub

    Private Sub Compras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        adaptadorCompras = New ComprasTableAdapter
        adaptadorCompras.Fill(DatosTPV.Compras)

        adaptadorLineasCompra = New LineaCompraTableAdapter
        adaptadorLineasCompra.Fill(DatosTPV.LineaCompra)

        adaptadorProductos = New ProductTableAdapter
        adaptadorProductos.Fill(DatosTPV.Product)

        modificaciones = new List(Of ProductoCantidadRegularizar)

        If DatosTPV.Compras.Count = 0 Then
            BindingNavigatorDeleteItem.Enabled = False
            ComprasBindingNavigatorSaveItem.Enabled = False
            BtnList.Enabled = False
            BtnCancel.Enabled = False
            BtnModify.Enabled = False
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        DatosTPV.Compras.BeginLoadData()
        Deshabilitar()
        ComprasBindingSource.AddNew()
        ComprasBindingSource.MoveLast()
    End Sub

    Private Sub Deshabilitar()
        FechaDateTimePicker.Enabled = True
        PictureBox1.Enabled = False

        ComprasBindingNavigator.MoveFirstItem = Nothing
        ComprasBindingNavigator.MovePreviousItem = Nothing
        ComprasBindingNavigator.PositionItem = Nothing
        BindingNavigatorMoveFirstItem.Enabled = False
        BindingNavigatorMovePreviousItem.Enabled = False
        BindingNavigatorMoveNextItem.Enabled = False
        BindingNavigatorMoveLastItem.Enabled = False
        BindingNavigatorAddNewItem.Enabled = False
        BindingNavigatorDeleteItem.Enabled = False
        BtnModify.Enabled = False
        ComprasBindingNavigatorSaveItem.Enabled = True
        BtnList.Enabled = False
        BtnCancel.Enabled = True

        LineaCompraDataGridView.ReadOnly = False
        LineaCompraDataGridView.AllowUserToAddRows = True
        LineaCompraDataGridView.AllowUserToDeleteRows = True
        LineaCompraDataGridView.Columns.Item(1).Visible = True
        LineaCompraDataGridView.Columns.Item(2).ReadOnly = True
        LineaCompraDataGridView.Columns.Item(6).ReadOnly = True
    End Sub

    Private Sub habilitar()
        FechaDateTimePicker.Enabled = False
        PictureBox1.Enabled = True

        ComprasBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem
        ComprasBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem
        ComprasBindingNavigator.PositionItem = BindingNavigatorPositionItem
        BindingNavigatorMoveFirstItem.Enabled = True
        BindingNavigatorMovePreviousItem.Enabled = True
        BindingNavigatorMoveNextItem.Enabled = True
        BindingNavigatorMoveLastItem.Enabled = True
        BindingNavigatorAddNewItem.Enabled = True
        BindingNavigatorDeleteItem.Enabled = True
        BtnModify.Enabled = True
        ComprasBindingNavigatorSaveItem.Enabled = False
        BtnList.Enabled = True
        BtnCancel.Enabled = False

        LineaCompraDataGridView.ReadOnly = True
        LineaCompraDataGridView.AllowUserToAddRows = False
        LineaCompraDataGridView.AllowUserToDeleteRows = False
        LineaCompraDataGridView.Columns.Item(1).Visible = False
        LineaCompraDataGridView.Columns.Item(6).Visible = False
    End Sub

    Private Sub LineaCompraDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles LineaCompraDataGridView.CellClick
        If e.ColumnIndex = 1 Then
            Dim producto As New FiltroProductos(1)
            producto.ShowDialog()

            Dim rows() As ProductRow = DatosTPV.Product.Select("ProductCode like '" & producto.getID & "'")
            If rows.Length > 0 Then
                Dim lineaActual As DataRowView = LineaCompraBindingSource.Current
                lineaActual.Row.Item(1) = producto.getID
                LineaCompraDataGridView.CurrentCell = LineaCompraDataGridView.Rows(LineaCompraDataGridView.CurrentRow.Index).Cells(LineaCompraDataGridView.CurrentCell.ColumnIndex + 1)
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        LineaCompraBindingSource.CancelEdit()
        ComprasBindingSource.CancelEdit()
        'ComprasBindingSource.RemoveFilter()
        adaptadorLineasCompra.Fill(DatosTPV.LineaCompra)
        For Each dr As LineaCompraRow In DatosTPV.LineaCompra.Select("IDLineaCompra < 0")
            dr.Delete()
        Next
        habilitar()
    End Sub

    Private Sub BtnModify_Click(sender As Object, e As EventArgs) Handles BtnModify.Click
        Deshabilitar()
        modificaciones = New List(Of ProductoCantidadRegularizar)
        For Each dr As LineaCompraRow In DatosTPV.LineaCompra.Select("IDCompra = " & ComprasBindingSource.Current.Row.Item(0))
            modificaciones.Add(New ProductoCantidadRegularizar(dr.ProductCode, dr.Cantidad))
        Next
    End Sub

    Private Sub ComprasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ComprasBindingNavigatorSaveItem.Click
        Try
            If Me.ValidateChildren Then
                Dim current As DataRowView = ComprasBindingSource.Current
                current.Row.Item(2) = FechaDateTimePicker.Value
                verificarTotal()

                ComprasBindingSource.EndEdit()
                adaptadorCompras.Update(DatosTPV.Compras)

                Dim compras() As ComprasRow = DatosTPV.Compras.Select()

                LineaCompraBindingSource.EndEdit()

                Dim regularizacion As New Regularizacion(DatosTPV)

                If modificaciones.Count = 0 Then
                    For Each dr As LineaCompraRow In DatosTPV.LineaCompra.Select("IDCompra < 0")
                        dr.IDCompra = DatosTPV.Compras.Rows.Item(compras.Length - 1).Item(0)
                        dr.Total = dr.Cantidad * dr.PrecioCompra
                        'Para agregar al stock toca enviar la cantidad en negativo 😁
                        regularizacion.regularizar(motivoComprar, dr.ProductCode, 0 - dr.Cantidad, compras(compras.Length - 1).Fecha)
                    Next
                Else
                    For Each dr As LineaCompraRow In DatosTPV.LineaCompra.Select("IDCompra = " & ComprasBindingSource.Current.Row.item(0))
                        'Para eliminar, en positivo 👍
                        Dim encontrado = modificaciones.Find(Function(x) x.productCode.Equals(dr.ProductCode))
                        dr.Total = dr.Cantidad * dr.PrecioCompra

                        If Not IsNothing(encontrado) Then
                            regularizacion.regularizar(movitvoModificarCompra, encontrado.productCode, encontrado.compareTo(dr.Cantidad), ComprasBindingSource.Current.Row.item(2))
                            modificaciones.Remove(encontrado)
                        ElseIf IsNothing(encontrado) Then
                            regularizacion.regularizar(movitvoModificarCompra, dr.ProductCode, 0 - dr.Cantidad, ComprasBindingSource.Current.Row.item(2))
                        End If
                    Next
                    For Each dr As ProductoCantidadRegularizar In modificaciones
                        regularizacion.regularizar(movitvoModificarCompra, dr.productCode, dr.getQuantityDeleted, ComprasBindingSource.Current.Row.item(2))
                    Next
                    modificaciones.Clear()
                End If

                adaptadorLineasCompra.Update(DatosTPV.LineaCompra)
                MsgBox("Guardado.")

                habilitar()
            End If
        Catch ex As Exception
            MsgBox("Error al guardar. Revisa que todos los campos sean correctos.")
        End Try
    End Sub

    Private Sub LineaCompraDataGridView_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles LineaCompraDataGridView.CellValidating
        If e.ColumnIndex = 3 Then
            Try
                If Double.Parse(e.FormattedValue) < 0 Then
                    e.Cancel = True
                    ErrorProvider1.SetError(sender, "Número invalido")
                Else
                    ErrorProvider1.SetError(sender, "")
                End If
            Catch ex As Exception
                e.Cancel = True
                ErrorProvider1.SetError(sender, "Número invalido")
            End Try
        ElseIf e.ColumnIndex = 5 Then
            Try
                If Double.Parse(e.FormattedValue) < 0 Then
                    e.Cancel = True
                    ErrorProvider1.SetError(sender, "Número invalido")
                Else
                    ErrorProvider1.SetError(sender, "")
                End If
            Catch ex As Exception
                e.Cancel = True
                ErrorProvider1.SetError(sender, "Número invalido")
            End Try
        End If
    End Sub

    Private Sub verificarTotal()
        If LineaCompraBindingSource.Current.Row.Item(0) < 0 Then
            Dim res As Double
            Dim lineaActual As DataRowView = ComprasBindingSource.Current
            For Each dr As LineaCompraRow In DatosTPV.LineaCompra.Select("IDCompra = " & lineaActual.Row.Item(0))
                res += dr.Cantidad * dr.PrecioCompra
                dr.Total = dr.Cantidad * dr.PrecioCompra
            Next

            lineaActual.Row.Item(1) = res
            TotalCompraTextBox.Text = Format(res, "0.00 €")
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        If MsgBox("Seguro que quieres eliminar?", vbYesNo, "Precaución") = vbYes Then
            Dim current As DataRowView = ComprasBindingSource.Current
            Dim regularizacion As New Regularizacion(DatosTPV)
            For Each dr As LineaCompraRow In DatosTPV.LineaCompra.Select("IDCompra = " & current.Row.Item(0))
                regularizacion.regularizar(motivoEliminar, dr.ProductCode, dr.Cantidad, Today)
            Next
            ComprasBindingSource.RemoveCurrent()
            ComprasBindingSource.EndEdit()
            adaptadorCompras.Update(DatosTPV.Compras)
        End If
        If DatosTPV.Compras.Count = 0 Then
            BindingNavigatorDeleteItem.Enabled = False
            BtnModify.Enabled = False
        End If
    End Sub

    Private Sub LineaCompraDataGridView_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles LineaCompraDataGridView.RowValidating
        Dim current As DataRowView = LineaCompraBindingSource.Current
        If Not IsNothing(current) Then
            If Not IsDBNull(current.Row.Item(2)) And Not IsDBNull(current.Row.Item(4)) Then
                current.Row.Item(5) = current.Row.Item(2) * current.Row.Item(4)
            End If
        End If
    End Sub

    Private Sub LineaCompraDataGridView_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles LineaCompraDataGridView.UserDeletingRow
        modificaciones.Item(e.Row.Index).setProductDeleted()
    End Sub

    Private Sub BtnList_Click(sender As Object, e As EventArgs) Handles BtnList.Click
        Dim listaCompra As New ListaCompras
        listaCompra.ShowDialog()

        If listaCompra.getID > 0 Then
            ComprasBindingSource.Position = ComprasBindingSource.Find("IDCompra", listaCompra.getID)
        End If
    End Sub
End Class