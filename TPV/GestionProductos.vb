Imports System.ComponentModel
Imports System.IO
Imports ConexionBD.DatosTPV
Imports ProcesosEmpresariales

Public Class GestionProductos
    Private productos As Productos
    Private categorias As ProcesosEmpresariales.Categorias
    Private anteriorCode As String
    Private Sub GestionCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        productos = New Productos(MenuPrincipal.DatosTPV1.Product)
        categorias = New ProcesosEmpresariales.Categorias
        DatosTPV_ProductDataTableBindingSource.DataSource = productos.table
        DatosTPV_ProductDataTableBindingSource.Filter = Constantes.FILTER
        ToolStripButton1.Tag = productos
        ToolStripButton3.Tag = productos
        BindingNavigatorDeleteItem1.Tag = productos
        BindingNavigatorAddNewItem1.Tag = productos
        AddHandler ToolStripButton1.Click, AddressOf NavigatorHandlers.Save
        AddHandler BindingNavigatorDeleteItem1.Click, AddressOf NavigatorHandlers.Delete
    End Sub

    Private Sub setRead()
        CheckBox1.Enabled = False
        CheckBox2.Enabled = False
        Button2.Enabled = False
        NameTextBox.Enabled = False
        DescriptionTextBox.Enabled = False
        PriceTextBox.Enabled = False
        ProductCodeTextBox.Enabled = False
        ButtonPicture.Enabled = False
        ToolStripButton1.Enabled = False
        ToolStripButton2.Enabled = True
        ToolStripButton3.Enabled = True
        ToolStripButton5.Enabled = False
        ToolStripTextBox1.Enabled = True
        ToolStripButton4.Enabled = True
        BindingNavigatorPositionItem1.Enabled = True
        BindingNavigator1.PositionItem = BindingNavigatorPositionItem1
        BindingNavigatorDeleteItem1.Enabled = True
        BindingNavigatorAddNewItem1.Enabled = True
        BindingNavigator1.MoveFirstItem = BindingNavigatorMoveFirstItem1
        BindingNavigator1.MoveLastItem = BindingNavigatorMoveLastItem1
        BindingNavigator1.MoveNextItem = BindingNavigatorMoveNextItem1
        BindingNavigator1.MovePreviousItem = BindingNavigatorMovePreviousItem1
        BindingNavigatorAddNewItem1.Enabled = True
        setPreview()
    End Sub

    Private Sub setModify()
        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
        Button2.Enabled = True
        NameTextBox.Enabled = True
        DescriptionTextBox.Enabled = True
        PriceTextBox.Enabled = True
        ButtonPicture.Enabled = True
        ToolStripButton1.Enabled = True
        ToolStripButton3.Enabled = False
        ToolStripButton5.Enabled = True
        ToolStripButton2.Enabled = False
        ProductCodeTextBox.Enabled = True
        ToolStripTextBox1.Enabled = False
        ToolStripButton4.Enabled = False
        BindingNavigator1.PositionItem = Nothing
        BindingNavigatorPositionItem1.Enabled = False
        BindingNavigator1.MoveFirstItem = Nothing
        BindingNavigator1.MoveLastItem = Nothing
        BindingNavigator1.MoveNextItem = Nothing
        BindingNavigator1.MovePreviousItem = Nothing
        BindingNavigatorMoveFirstItem1.Enabled = False
        BindingNavigatorMoveFirstItem1.ForeColor = Color.Gray
        BindingNavigatorMoveNextItem1.Enabled = False
        BindingNavigatorMoveNextItem1.ForeColor = Color.Gray
        BindingNavigatorMoveLastItem1.Enabled = False
        BindingNavigatorMoveLastItem1.ForeColor = Color.Gray
        BindingNavigatorMovePreviousItem1.Enabled = False
        BindingNavigatorMovePreviousItem1.ForeColor = Color.Gray
        BindingNavigatorDeleteItem1.Enabled = False
        BindingNavigatorAddNewItem1.Enabled = False
    End Sub

    Private Sub ButtonPicture_Click(sender As Object, e As EventArgs) Handles ButtonPicture.Click
        Dim file As New OpenFileDialog
        file.Filter = "Archivos de imagen (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png"
        file.FilterIndex = 2
        file.RestoreDirectory = True
        Dim result As DialogResult = file.ShowDialog()
        If (result = DialogResult.OK) Then
            If (Not FileManagement.copyFile(Constantes.PATH_PRODUCTS, file.FileName)) Then
                MsgBox(Constantes.ERROR_COPY, , Constantes.ERROR_TITLE)
            Else
                Dim a As DataRowView = DatosTPV_ProductDataTableBindingSource.Current
                a.Row.Item(5) = Constantes.PATH_PRODUCTS & Path.GetFileName(file.FileName)
                Item1.Picture.Image = Image.FromFile(a.Row.Item(5))
            End If
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem1_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem1.Click
        setModify()
        reloadSearch()
        Label3.Text = ""
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If Me.Validate And Me.ValidateChildren Then
            Dim row As DataRowView = DatosTPV_ProductDataTableBindingSource.Current
            If CheckBox1.Checked Then
                row.Row.Item(8) = True
            Else
                row.Row.Item(8) = False
            End If
            If CheckBox2.Checked Then
                row.Row.Item(9) = True
            Else
                row.Row.Item(9) = False
            End If
            If row IsNot Nothing Then
                row.Row.Item(6) = True
                row.Row.Item(7) = 0
                setRead()
            End If
        End If
    End Sub

    Private Sub DatosTPV_ProductDataTableBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles DatosTPV_ProductDataTableBindingSource.CurrentChanged
        setPreview()
    End Sub

    Private Sub setPreview()
        If (DatosTPV_ProductDataTableBindingSource.Count > 0) Then
            Dim row As DataRowView = DatosTPV_ProductDataTableBindingSource.Current
            If Not IsDBNull(row.Item(2)) Then
                Item1.NameItem.Text = row.Item(2)
            Else
                Item1.NameItem.Text = "Nothing"
            End If

            If (Not IsDBNull(row.Row.Item(5))) Then
                Try
                    Item1.Picture.Image = Image.FromFile(row.Row.Item(5))
                Catch ex As Exception
                    Item1.Picture.Image = My.Resources.no_image
                End Try
            Else
                Item1.Picture.Image = My.Resources.no_image
            End If
            If Not IsDBNull(row.Item(2)) Then
                Item1.Refresh()
                Label3.Text = categorias.table.Select("idCategory = " & row.Row.Item(1))(0).Item(1)
            End If
        Else
            Item1.NameItem.Text = "Nothing"
            Item1.Picture.Image = My.Resources.no_image
            Label3.Text = "Nothing"
        End If
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If DatosTPV_ProductDataTableBindingSource.Count > 0 Then
            setModify()
            anteriorCode = ProductCodeTextBox.Text
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim list As New FiltroProductos(0)
        list.ShowDialog()
        If list.getID IsNot Nothing Then
            DatosTPV_ProductDataTableBindingSource.Position = DatosTPV_ProductDataTableBindingSource.Find("ProductCode", list.getID)
        End If
    End Sub

    Private Sub ToolStripTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                DatosTPV_ProductDataTableBindingSource.Filter += " AND [ProductCode] LIKE '*" & CInt(ToolStripTextBox1.Text) & "*' OR [Name] = '*" & ToolStripTextBox1.Text & "*'"
            Catch ex As Exception
                DatosTPV_ProductDataTableBindingSource.Filter += " AND [Name] LIKE '*" & ToolStripTextBox1.Text & "*'"
            End Try
            If DatosTPV_ProductDataTableBindingSource.Count = 0 Then
                reloadSearch()
                MsgBox(Constantes.NO_RESOULT)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim list As New Listado(categorias.table)
        list.ShowDialog()
        Dim row As DataRowView = DatosTPV_ProductDataTableBindingSource.Current
        If Not list.row Is Nothing Then
            row.Item(1) = list.row.Cells.Item(0).Value
            Label3.Text = categorias.table.Select("idCategory = " & row.Item(1))(0).Item(1)
        End If
    End Sub

    Private Sub reloadSearch()
        DatosTPV_ProductDataTableBindingSource.Filter = Constantes.FILTER
        ToolStripTextBox1.Clear()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        reloadSearch()
    End Sub

    Private Sub GestionProductos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If ToolStripButton1.Enabled Then
            If MsgBox(Constantes.MESSAGE_EXIT_WITH_CHANGES, MessageBoxButtons.YesNo, Constantes.WARNING_DELETE) = MsgBoxResult.No Then
                e.Cancel = True
                Return
            End If
        End If
        MenuGestion.Show()
    End Sub


    Private Sub PriceTextBox_Validating(sender As Object, e As CancelEventArgs) Handles PriceTextBox.Validating
        Try
            If Not Double.Parse(PriceTextBox.Text) > 0 Then
                e.Cancel = True
                ErrorProvider1.SetError(sender, Constantes.MESSAGE_NO_VALID_PRICE)
            End If
        Catch ex As Exception
            e.Cancel = True
        End Try
    End Sub
    Private Sub ProductCodeTextBox_Validating(sender As TextBox, e As CancelEventArgs) Handles ProductCodeTextBox.Validating
        Try
            Dim row As ProductRow = productos.table.FindByProductCode(sender.Text)
            If row IsNot Nothing AndAlso row.ProductCode <> anteriorCode Then
                e.Cancel = True
                ErrorProvider1.SetError(sender, Constantes.MESSAGE_DUPLICATED_FIELD)
            End If
        Catch ex As Exception
            e.Cancel = True
        End Try
    End Sub
    Private Sub NameTextBox_Validating(sender As Object, e As CancelEventArgs) Handles NameTextBox.Validating, PriceTextBox.Validating, ProductCodeTextBox.Validating
        If String.IsNullOrEmpty(CType(sender, TextBox).Text) Then
            e.Cancel = True
            ErrorProvider1.SetError(sender, Constantes.MESSAGE_OBLIGATORY_FIELD)
        End If
    End Sub

    Private Sub GestionProductos_Validating(sender As Object, e As CancelEventArgs) Handles Me.Validated
        If IsDBNull(CType(DatosTPV_ProductDataTableBindingSource.Current, DataRowView).Item(1)) Then
            ErrorProvider1.SetError(Button2, Constantes.MESSAGE_OBLIGATORY_FIELD)
            e.Cancel = True
        End If
    End Sub

    Private Sub Button2_Validating(sender As Object, e As CancelEventArgs) Handles Button2.Validating
        If IsDBNull(CType(DatosTPV_ProductDataTableBindingSource.Current, DataRowView).Item(1)) Then
            ErrorProvider1.SetError(Button2, Constantes.MESSAGE_OBLIGATORY_FIELD)
            e.Cancel = True
        End If
        If Not e.Cancel Then
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub NameTextBox_Validated(sender As Object, e As EventArgs) Handles NameTextBox.Validated
        Item1.NameItem.Text = NameTextBox.Text
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        DatosTPV_ProductDataTableBindingSource.CancelEdit()
        setRead()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class