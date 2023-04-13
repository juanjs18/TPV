Imports System.IO
Imports ProcesosEmpresariales

Public Class GestionCategorias
    Private categorias As ProcesosEmpresariales.Categorias
    Private Sub GestionCategorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        categorias = New ProcesosEmpresariales.Categorias
        ToolStripButton1.Tag = categorias
        BindingNavigatorDeleteItem1.Tag = categorias
        CategoryBindingSource.DataSource = categorias.table
        CategoryBindingSource.Filter = Constantes.FILTER
        AddHandler ToolStripButton1.Click, AddressOf NavigatorHandlers.Save
        AddHandler BindingNavigatorDeleteItem1.Click, AddressOf NavigatorHandlers.Delete
    End Sub

    Private Sub habilitar()
        NameTextBox.Enabled = True
        DescriptionTextBox.Enabled = True
        Button2.Enabled = True
        ToolStripButton1.Enabled = True
        ToolStripTextBox1.Enabled = False
        ToolStripButton4.Enabled = False
        BindingNavigator1.PositionItem = Nothing
        BindingNavigatorPositionItem1.Enabled = False
        BindingNavigator1.MoveFirstItem = Nothing
        BindingNavigator1.MoveLastItem = Nothing
        BindingNavigator1.MoveNextItem = Nothing
        BindingNavigator1.MovePreviousItem = Nothing
        BindingNavigatorMoveFirstItem1.Enabled = False
        BindingNavigatorMoveNextItem1.Enabled = False
        BindingNavigatorMoveLastItem1.Enabled = False
        BindingNavigatorMovePreviousItem1.Enabled = False
        BindingNavigatorDeleteItem1.Enabled = False
        BindingNavigatorAddNewItem1.Enabled = False
        ToolStripButton3.Enabled = False
        ToolStripButton2.Enabled = False
        ToolStripButton5.Enabled = True
    End Sub

    Private Sub deshabilitar()
        ToolStripButton1.Enabled = False
        NameTextBox.Enabled = False
        DescriptionTextBox.Enabled = False
        ToolStripTextBox1.Enabled = True
        ToolStripButton4.Enabled = True
        Button2.Enabled = False
        ToolStripButton2.Enabled = True
        ToolStripButton3.Enabled = True
        BindingNavigatorPositionItem1.Enabled = True
        BindingNavigator1.PositionItem = BindingNavigatorPositionItem1
        BindingNavigatorDeleteItem1.Enabled = True
        BindingNavigatorAddNewItem1.Enabled = True
        BindingNavigator1.MoveFirstItem = BindingNavigatorMoveFirstItem1
        BindingNavigator1.MoveLastItem = BindingNavigatorMoveLastItem1
        BindingNavigator1.MoveNextItem = BindingNavigatorMoveNextItem1
        BindingNavigator1.MovePreviousItem = BindingNavigatorMovePreviousItem1
        BindingNavigatorAddNewItem1.Enabled = True
        ToolStripButton5.Enabled = False
        setPreview()
    End Sub

    Private Sub setPreview()
        If (CategoryBindingSource.Count > 0) Then
            Dim row As DataRowView = CategoryBindingSource.Current
            If Not IsDBNull(row.Item(1)) Then
                Item1.NameItem.Text = row.Item(1)
            Else
                Item1.NameItem.Text = "Nothing"
            End If

            If (Not IsDBNull(row.Row.Item(3))) Then
                Try
                    Item1.Picture.Image = Image.FromFile(row.Row.Item(3))
                Catch ex As Exception
                    Item1.Picture.Image = My.Resources.no_image
                End Try
            Else

            End If
            Item1.Refresh()
        Else
            Item1.NameItem.Text = "Nothing"
            Item1.Picture.Image = My.Resources.no_image
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem1_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem1.Click
        habilitar()
        reloadSearch()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If CategoryBindingSource.Count > 0 Then
            habilitar()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim file As New OpenFileDialog
        file.Filter = "Archivos de imagen (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png"
        file.FilterIndex = 2
        file.RestoreDirectory = True
        Dim result As DialogResult = file.ShowDialog()
        If (result = DialogResult.OK) Then
            If (Not FileManagement.copyFile(Constantes.PATH_CATEGORIES, file.FileName)) Then
                MsgBox(Constantes.ERROR_COPY, , Constantes.ERROR_TITLE)
            Else
                Dim a As DataRowView = CategoryBindingSource.Current
                a.Row.Item(3) = Constantes.PATH_CATEGORIES & Path.GetFileName(file.FileName)
                Item1.Picture.Image = Image.FromFile(a.Row.Item(3))
            End If
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If Me.ValidateChildren Then
            deshabilitar()
            CType(CategoryBindingSource.Current, DataRowView).Row.Item(4) = True
        End If
    End Sub

    Private Sub CategoryBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles CategoryBindingSource.CurrentChanged
        setPreview()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim lista As New TPV.Categorias()
        lista.ShowDialog()
        If lista.getID <> 0 Then
            CategoryBindingSource.Position = CategoryBindingSource.Find("idCategory", lista.getID)
        End If
    End Sub


    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        reloadSearch()
    End Sub

    Private Sub GestionCategorias_FormClosed(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ToolStripButton1.Enabled Then
            If MsgBox(Constantes.MESSAGE_EXIT_WITH_CHANGES, MessageBoxButtons.YesNo, Constantes.WARNING_DELETE) = MsgBoxResult.No Then
                e.Cancel = True
                Return
            End If
        End If
        MenuGestion.Show()
    End Sub

    Private Sub ToolStripTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                CategoryBindingSource.Filter += " AND [idCategory] = " & CInt(ToolStripTextBox1.Text)
            Catch ex As Exception
                CategoryBindingSource.Filter += " AND [Name] LIKE '*" & ToolStripTextBox1.Text & "*'"
            End Try
            If CategoryBindingSource.Count = 0 Then
                reloadSearch()
                MsgBox(Constantes.NO_RESOULT)
            End If
        End If
    End Sub
    Private Sub reloadSearch()
        CategoryBindingSource.Filter = Constantes.FILTER
        ToolStripTextBox1.Clear()
    End Sub

    Private Sub NameTextBox_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles NameTextBox.Validating
        If String.IsNullOrEmpty(NameTextBox.Text) Then
            e.Cancel = True
            ErrorProvider1.SetError(sender, Constantes.MESSAGE_OBLIGATORY_FIELD)
        End If
    End Sub

    Private Sub NameTextBox_Validated(sender As Object, e As EventArgs) Handles NameTextBox.Validated
        Item1.NameItem.Text = NameTextBox.Text
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        CategoryBindingSource.CancelEdit()
        deshabilitar()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class