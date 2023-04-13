Imports System.ComponentModel
Imports ConexionBD
Imports ConexionBD.DatosTPV
Imports ConexionBD.DatosTPVTableAdapters
Imports ProcesosEmpresariales

Public Class Albaran
    Private albaran As AlbaranTableAdapter
    Private usuarios As UsersTableAdapter
    Private productos As ProductTableAdapter
    Private orders As OrdersTableAdapter
    Private postalCodes As PostalCodeTableAdapter
    Private p As New FiltroProductos(2)
    Private a As New Albaranes
    Private ee As New Empresa
    Private modificaciones As List(Of ProductoCantidadRegularizar)
    Private Const motivoAlbaran As String = "Venta producto albaran"
    Private Const motivoModificarAlbaran As String = "Modificación venta producto albaran"

    Private Sub Albaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        albaran = New AlbaranTableAdapter
        albaran.Fill(GestionesDataSet.Albaran)
        usuarios = New UsersTableAdapter
        usuarios.Fill(GestionesDataSet.Users)
        productos = New ProductTableAdapter
        productos.Fill(GestionesDataSet.Product)
        orders = New OrdersTableAdapter
        orders.Fill(GestionesDataSet.Orders)
        postalCodes = New PostalCodeTableAdapter
        postalCodes.Fill(GestionesDataSet.PostalCode)

        modificaciones = New List(Of ProductoCantidadRegularizar)

        Dim rr As DataRowView = UsersBindingSource.Current
        If rr IsNot Nothing Then
            PostalCodeBindingSource.Position = PostalCodeBindingSource.Find("idPC", rr.Row.Item(3))
        End If

        If GestionesDataSet.Albaran.Count = 0 Then
            UsersBindingSource.Filter() = "idUser = 0"
            BindingNavigatorModifyItem.Enabled = False
            PostalCodeBindingSource.Filter() = "idPC = 0"
            BindingNavigatorDeleteItem.Enabled = False
            BindingNavigatorListItem.Enabled = False
        End If

        DateDateTimePicker.Value = Today
    End Sub

    Private Sub AlbaranBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles AlbaranBindingSource.PositionChanged
        Dim row As DataRowView = AlbaranBindingSource.Current
        If row IsNot Nothing Then
            If Not IsDBNull(row.Row.Item(2)) Then
                UsersBindingSource.Filter = "idUser = " & row.Row.Item(2)
            End If
        End If
        row = UsersBindingSource.Current
        If row IsNot Nothing Then
            PostalCodeBindingSource.Filter = "idPC = " & row.Row.Item(3)
            'PostalCodeBindingSource.Position = PostalCodeBindingSource.Find("idPC", rr.Row.Item(3))
        End If
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles BttnAtras.Click
        Me.Close()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        UsersBindingSource.Filter() = "idUser = 0"
        PostalCodeBindingSource.Filter() = "idPC = 0"
        If GestionesDataSet.Users.Count > 0 Then

            deshabilitar()

        Else
            MsgBox("No hay empresas a quién hacer albaran.")
            Me.Close()
        End If
    End Sub

    Private Sub deshabilitar()
        BttnBuscarEmpresa.Enabled = True
        DateDateTimePicker.Enabled = True
        BttnAtras.Enabled = False
        BtnCancelar.Enabled = True

        AlbaranBindingNavigator.MoveFirstItem = Nothing
        AlbaranBindingNavigator.MovePreviousItem = Nothing
        AlbaranBindingNavigator.PositionItem = Nothing
        BindingNavigatorMoveFirstItem.Enabled = False
        BindingNavigatorMovePreviousItem.Enabled = False
        BindingNavigatorMoveNextItem.Enabled = False
        BindingNavigatorMoveLastItem.Enabled = False
        BindingNavigatorAddNewItem.Enabled = False
        BindingNavigatorDeleteItem.Enabled = False
        BindingNavigatorModifyItem.Enabled = False
        AlbaranBindingNavigatorSaveItem.Enabled = True
        BindingNavigatorListItem.Enabled = False

        OrdersDataGridView.ReadOnly = False
        OrdersDataGridView.Columns.Item(3).ReadOnly = True
        OrdersDataGridView.Columns.Item(5).ReadOnly = False
        OrdersDataGridView.Columns.Item(1).Visible = True

        OrdersDataGridView.Columns.Item(1).ReadOnly = False
        OrdersDataGridView.Columns.Item(4).ReadOnly = False
        OrdersDataGridView.AllowUserToAddRows = True
        OrdersDataGridView.AllowUserToDeleteRows = True
    End Sub

    Private Sub OrdersDataGridView_RowValidated(sender As Object, e As DataGridViewCellEventArgs) Handles OrdersDataGridView.RowValidated
        Dim res As Double
        For Each dr As OrdersRow In GestionesDataSet.Orders.Select("idAlbaran = " & IdAlbaranTextBox.Text)
            res += dr.Quantity * dr.UnitPrice
        Next

        'Dim rr As DataRowView = AlbaranBindingSource.Current
        'rr.Row.Item(3) = res
        AmountTextBox.Text = Format(res, "0.00 €")

        'AmountTextBox.Text = Format(res, "#,##0.00 €")
    End Sub

    Private Sub OrdersDataGridView_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles OrdersDataGridView.CellValidating
        If e.ColumnIndex = 4 Then
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

    'Private Sub buscarProductos()
    '    If GestionesDataSet.Product.Count > 0 Then
    '        If IsDBNull(OrdersDataGridView.CurrentRow.Cells(1).Value) Then
    '            Dim dgvc As DataGridViewCell = OrdersDataGridView.CurrentCell
    '            OrdersDataGridView.ClearSelection()
    '            OrdersDataGridView.Select()
    '        Else
    '            Dim rows() As ProductRow = GestionesDataSet.Product.Select("ProductCode = " & OrdersDataGridView.CurrentRow.Cells(1).Value)
    '            If rows.Length > 0 Then
    '                OrdersDataGridView.CurrentRow.Cells(3).Value = rows(0).Name
    '                OrdersDataGridView.CurrentRow.Cells(5).Value = rows(0).Price
    '                OrdersDataGridView.CurrentRow.Cells(6).Value = IdAlbaranTextBox.Text
    '            Else
    '                MsgBox("Producto no encontrado.")
    '                OrdersDataGridView.CurrentRow.Cells(1).Value = Nothing
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub AlbaranBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AlbaranBindingNavigatorSaveItem.Click
        Try
            If Me.ValidateChildren Then
                Dim drv As DataRowView = AlbaranBindingSource.Current
                drv.Row.Item(3) = Double.Parse(AmountTextBox.Text.Split(" ")(0))
                drv.Row.Item(1) = DateDateTimePicker.Value
                drv.Row.Item(4) = False
                Dim ar As DataRowView = UsersBindingSource.Current
                drv.Row.Item(2) = ar.Row.Item(0)
                'drv.Row().Item(1) = Today
                AlbaranBindingSource.EndEdit()
                albaran.Update(GestionesDataSet.Albaran)

                Dim rows() As AlbaranRow = GestionesDataSet.Albaran.Select()

                'Dim rows As Integer
                'rows = GestionesDataSet.Albaran.Rows.Count - 1

                Try
                    OrdersBindingSource.EndEdit()
                Catch ex As Exception
                    OrdersBindingSource.CancelEdit()
                End Try

                Dim regularizacion As New Regularizacion(GestionesDataSet)

                If modificaciones.Count = 0 Then
                    For Each dr As OrdersRow In GestionesDataSet.Orders.Select("idAlbaran < 0")
                        dr.idAlbaran = GestionesDataSet.Albaran.Rows.Item(rows.Length - 1).Item(0)
                        dr.amountOrders = dr.Quantity * dr.UnitPrice
                        regularizacion.regularizar(motivoAlbaran, dr.idProduct, dr.Quantity, rows(rows.Length - 1)._date)
                    Next
                Else
                    For Each dr As OrdersRow In GestionesDataSet.Orders.Select("idAlbaran = " & AlbaranBindingSource.Current.Row.item(0))

                        Dim encontrado = modificaciones.Find(Function(x) x.productCode.Equals(dr.idProduct))
                        dr.amountOrders = dr.Quantity * dr.UnitPrice

                        If Not IsNothing(encontrado) Then
                            regularizacion.regularizar(motivoModificarAlbaran, encontrado.productCode, 0 - encontrado.compareTo(dr.Quantity), AlbaranBindingSource.Current.Row.item(1))
                            modificaciones.Remove(encontrado)
                        ElseIf IsNothing(encontrado) Then
                            regularizacion.regularizar(motivoModificarAlbaran, dr.idProduct, dr.Quantity, AlbaranBindingSource.Current.Row.Item(1))
                        End If
                    Next
                    For Each dr As ProductoCantidadRegularizar In modificaciones
                        regularizacion.regularizar(motivoModificarAlbaran, dr.productCode, dr.getQuantityDeleted, AlbaranBindingSource.Current.Row.item(1))
                    Next
                    modificaciones.Clear()
                End If


                orders.Update(GestionesDataSet.Orders)
                MsgBox("Datos actualizados.")

                habilitar()
            End If
        Catch ex As Exception
            MsgBox("Error al guardar. Revisa que todos los campos sean correctos.")
        End Try
    End Sub

    Private Sub habilitar()

        BttnBuscarEmpresa.Enabled = False
        BttnAtras.Enabled = True
        DateDateTimePicker.Enabled = False
        BtnCancelar.Enabled = False

        AlbaranBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        AlbaranBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        AlbaranBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        BindingNavigatorMoveFirstItem.Enabled = True
        BindingNavigatorMovePreviousItem.Enabled = True
        BindingNavigatorAddNewItem.Enabled = True
        AlbaranBindingNavigatorSaveItem.Enabled = False

        If GestionesDataSet.Albaran.Count > 0 Then
            BindingNavigatorModifyItem.Enabled = True
            BindingNavigatorListItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = True
        Else
            BindingNavigatorModifyItem.Enabled = False
            BindingNavigatorListItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False
        End If

        OrdersDataGridView.ReadOnly = True
        OrdersDataGridView.AllowUserToAddRows = False
        OrdersDataGridView.AllowUserToDeleteRows = False
        OrdersDataGridView.Columns.Item(1).Visible = False
    End Sub

    Private Sub OrdersDataGridView_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles OrdersDataGridView.DataError
        MsgBox(e.Exception.ToString)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles BindingNavigatorModifyItem.Click

        OrdersDataGridView.ReadOnly = False

        OrdersDataGridView.Columns.Item(3).ReadOnly = True
        OrdersDataGridView.Columns.Item(5).ReadOnly = False
        OrdersDataGridView.Columns.Item(1).Visible = True

        OrdersDataGridView.Columns.Item(1).ReadOnly = False
        OrdersDataGridView.Columns.Item(4).ReadOnly = False
        OrdersDataGridView.AllowUserToAddRows = True
        OrdersDataGridView.AllowUserToDeleteRows = True

        DateDateTimePicker.Enabled = True
        BtnCancelar.Enabled = True

        If GestionesDataSet.Users.Count > 0 Then
            BttnBuscarEmpresa.Enabled = True
        End If
        AlbaranBindingNavigator.MoveFirstItem = Nothing
        AlbaranBindingNavigator.MovePreviousItem = Nothing
        BindingNavigatorMoveFirstItem.Enabled = False
        BindingNavigatorMovePreviousItem.Enabled = False
        BindingNavigatorPositionItem.Enabled = False
        BindingNavigatorMoveNextItem.Enabled = False
        BindingNavigatorMoveLastItem.Enabled = False
        BindingNavigatorAddNewItem.Enabled = False
        BindingNavigatorDeleteItem.Enabled = False
        BindingNavigatorModifyItem.Enabled = False
        AlbaranBindingNavigatorSaveItem.Enabled = True
        BindingNavigatorListItem.Enabled = False

        modificaciones = New List(Of ProductoCantidadRegularizar)
        For Each dr As OrdersRow In GestionesDataSet.Orders.Select("idAlbaran = " & AlbaranBindingSource.Current.Row.Item(0))
            modificaciones.Add(New ProductoCantidadRegularizar(dr.idProduct, dr.Quantity))
        Next
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        If MsgBox("Seguro que quieres eliminar?", vbYesNo, "Precaución") = vbYes Then
            Dim rows() As AlbaranRow
            rows = GestionesDataSet.Albaran.Select
            If rows.Length > 0 Then
                AlbaranBindingSource.RemoveCurrent()
                AlbaranBindingSource.EndEdit()
                albaran.Update(GestionesDataSet.Albaran)
            End If
        End If
        If GestionesDataSet.Albaran.Count = 0 Then
            BindingNavigatorDeleteItem.Enabled = False
            BindingNavigatorModifyItem.Enabled = False
        End If
    End Sub

    Private Sub OrdersDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles OrdersDataGridView.CellClick
        If OrdersDataGridView.CurrentCell IsNot Nothing Then
            If OrdersDataGridView.CurrentCell.ColumnIndex = 1 Then
                p.ShowDialog()
                If GestionesDataSet.Product.Count > 0 Then
                    Dim rows() As ProductRow = GestionesDataSet.Product.Select("ProductCode like '" & p.getID & "'")
                    If rows.Length > 0 Then
                        Dim albaranActual As DataRowView = AlbaranBindingSource.Current
                        Dim ordenActual As DataRowView = OrdersBindingSource.Current
                        ordenActual.Row.Item(1) = p.getID
                        ordenActual.Row.Item(2) = rows(0).Name
                        'ordenActual.Row.Item(3) = 1
                        ordenActual.Row.Item(4) = rows(0).Price
                        OrdersDataGridView.CurrentCell = OrdersDataGridView.Rows(OrdersDataGridView.CurrentRow.Index).Cells(OrdersDataGridView.CurrentCell.ColumnIndex + 1)
                        'ordenActual.Row.Item(5) = albaranActual.Row.Item(0)
                        'ordenActual.Row.Item(6) = ordenActual.Row.Item(3) * ordenActual.Row.Item(4)
                        'ordenActual.Row.Item(7) = IdAlbaranTextBox.Text
                        'OrdersDataGridView.CurrentRow.Cells(1).Value = p.idProducto
                        'OrdersDataGridView.CurrentRow.Cells(3).Value = rows(0).Name
                        'OrdersDataGridView.CurrentRow.Cells(4).Value = 1
                        'OrdersDataGridView.CurrentRow.Cells(5).Value = rows(0).Price
                        'OrdersDataGridView.CurrentRow.Cells(6).Value = 1 * rows(0).Price
                        'OrdersDataGridView.CurrentRow.Cells(7).Value = IdAlbaranTextBox.Text
                        'OrdersBindingSource.ResetBindings(False)
                    End If
                End If

            End If
        End If
    End Sub

    Private Sub BindingNavigatorListItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorListItem.Click
        a.ShowDialog()

        If GestionesDataSet.Albaran.Count > 0 Then
            AlbaranBindingSource.Position = AlbaranBindingSource.Find("idAlbaran", a.getID)

            'Dim res As Double
            'res = AmountTextBox.Text
            'AmountTextBox.Text = Format(res, "#,##0.00 €")
        End If

    End Sub

    Private Sub BttnBuscarEmpresa_Click(sender As Object, e As EventArgs) Handles BttnBuscarEmpresa.Click
        ee = New Empresa
        ee.ShowDialog()
        If GestionesDataSet.Users.Count > 0 Then
            Dim rows() As UsersRow = GestionesDataSet.Users.Select("idUser = " & ee.getID)
            If rows.Length > 0 Then
                UsersBindingSource.Filter = "idUser = " & ee.getID
                IdUserTextBox.Text = ee.getID
                'NameTextBox.Text = rows(0).name
                'StreetTextBox.Text = rows(0).street
                'NifTextBox.Text = rows(0).nif
                PostalCodeBindingSource.Filter = "idPC = " & rows(0).idPostalCode
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        OrdersBindingSource.CancelEdit()
        AlbaranBindingSource.CancelEdit()
        AlbaranBindingSource.RemoveFilter()
        orders.Fill(GestionesDataSet.Orders)
        For Each dr As OrdersRow In GestionesDataSet.Orders.Select("idOrders < 0")
            dr.Delete()
        Next
        habilitar()
        ErrorProvider1.SetError(OrdersDataGridView, "")
    End Sub

    Private Sub OrdersDataGridView_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles OrdersDataGridView.RowValidating
        Dim ordenActual As DataRowView = OrdersBindingSource.Current
        If ordenActual IsNot Nothing Then
            If Not IsDBNull(ordenActual.Row.Item(3)) And Not IsDBNull(ordenActual.Row.Item(4)) Then
                ordenActual.Row.Item(5) = ordenActual.Row.Item(3) * ordenActual.Row.Item(4)
            End If
        End If
    End Sub

    Private Sub IdUserTextBox_Validating(sender As Object, e As CancelEventArgs) Handles IdUserTextBox.Validating
        If String.IsNullOrEmpty(IdUserTextBox.Text) Then
            e.Cancel = True
            ErrorProvider1.SetError(sender, "Seleccione una empresa")
        Else
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub OrdersDataGridView_Validating(sender As Object, e As CancelEventArgs) Handles OrdersDataGridView.Validating
        If Not String.IsNullOrEmpty(IdUserTextBox.Text) Then
            Try
                If OrdersDataGridView.Rows(0).Cells(3).Value Is Nothing And OrdersDataGridView.RowCount = 1 Then
                    e.Cancel = True
                    ErrorProvider1.SetError(sender, "Seleccione productos")
                Else
                    ErrorProvider1.SetError(sender, "")
                    If OrdersDataGridView.Rows(0).Cells(3).Value Is Nothing Then
                        e.Cancel = True
                        ErrorProvider1.SetError(sender, "Seleccione una cantidad")
                    Else
                        ErrorProvider1.SetError(sender, "")
                    End If
                End If
            Catch ex As Exception
                e.Cancel = True
                ErrorProvider1.SetError(sender, "Seleccione productos")
            End Try
        End If
    End Sub

    Private Sub Albaran_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MenuFacturacion.Show()
    End Sub

    Private Sub OrdersDataGridView_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles OrdersDataGridView.UserDeletingRow
        modificaciones.Item(e.Row.Index).setProductDeleted()
    End Sub
End Class