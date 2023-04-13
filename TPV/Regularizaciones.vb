Imports System.ComponentModel
Imports ConexionBD.DatosTPV
Imports ConexionBD.DatosTPVTableAdapters
Imports ProcesosEmpresariales

Public Class Regularizaciones
    Private Const FILTER_FECHA As String = " AND Fecha >= '{0}' AND Fecha < '{1}'"
    Private Const FILTER_MOTIVO As String = " AND Motivo LIKE '*{0}*'"
    Private Const FILTER_DEFAULT As String = "Manual = 'True'"
    Private ant As String
    Public modify As Boolean
    Private datos As Regularizacion
    Private Sub setRead()
        MotivoTextBox.Enabled = False
        Button1.Enabled = False
        CantidadTextBox.Enabled = False
        InventarioTextBox.Enabled = False
        GroupBox1.Enabled = False
        FechaDateTimePicker.Enabled = False
        ToolStripTextBox1.Enabled = True
        ToolStripButton4.Enabled = True
        ToolStripButton1.Enabled = False
        ToolStripButton2.Enabled = True
        ToolStripButton3.Enabled = True
        ToolStripButton5.Enabled = False
        BindingNavigatorPositionItem1.Enabled = True
        RegularizacionesBindingNavigator.PositionItem = BindingNavigatorPositionItem1
        BindingNavigatorDeleteItem1.Enabled = True
        BindingNavigatorAddNewItem1.Enabled = True
        RegularizacionesBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem1
        RegularizacionesBindingNavigator.MoveLastItem = BindingNavigatorMoveLastItem1
        RegularizacionesBindingNavigator.MoveNextItem = BindingNavigatorMoveNextItem1
        RegularizacionesBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem1
        BindingNavigatorAddNewItem1.Enabled = True
        DateTimePicker1.Enabled = True
    End Sub
    Private Sub setModify()
        MotivoTextBox.Enabled = True
        Button1.Enabled = True
        GroupBox1.Enabled = True
        ToolStripButton1.Enabled = True
        ToolStripButton3.Enabled = False
        ToolStripButton5.Enabled = True
        ToolStripTextBox1.Enabled = False
        ToolStripButton4.Enabled = False
        ToolStripButton2.Enabled = False
        FechaDateTimePicker.Enabled = True
        RegularizacionesBindingNavigator.PositionItem = Nothing
        BindingNavigatorPositionItem1.Enabled = False
        RegularizacionesBindingNavigator.MoveFirstItem = Nothing
        RegularizacionesBindingNavigator.MoveLastItem = Nothing
        RegularizacionesBindingNavigator.MoveNextItem = Nothing
        RegularizacionesBindingNavigator.MovePreviousItem = Nothing
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
        DateTimePicker1.Enabled = False
    End Sub

    Private Sub Regularizaciones_Load(sender As Object, e As EventArgs) Handles Me.Load
        setRead()
        Dim adapter As New RegularizacionTableAdapter
        adapter.Fill(DatosTPV.Regularizacion)
        Dim adapterP As New ProductTableAdapter
        adapterP.Fill(DatosTPV.Product)
        datos = New Regularizacion(DatosTPV)
        BindingNavigatorDeleteItem1.Tag = datos
        BindingNavigatorAddNewItem1.Tag = datos
        ToolStripButton1.Tag = datos
        AddHandler ToolStripButton1.Click, AddressOf NavigatorHandlers.Save
        AddHandler BindingNavigatorDeleteItem1.Click, AddressOf NavigatorHandlers.Delete
        DateTimePicker1.Value = Today
    End Sub

    Private Sub BindingNavigatorAddNewItem1_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem1.Click
        RegularizacionBindingSource.AddNew()
        RegularizacionBindingSource.MoveLast()
        CType(RegularizacionBindingSource.Current, DataRowView).Item(5) = Today
        CType(RegularizacionBindingSource.Current, DataRowView).Item(6) = True
        setModify()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If RegularizacionBindingSource.Count > 0 Then
            setModify()
            modify = True
            ant = CType(RegularizacionBindingSource.Current, DataRowView).Row.Item(3)
            RemoveHandler ToolStripButton1.Click, AddressOf NavigatorHandlers.Save
            CType(ProductBindingSource.Current, DataRowView).Row.Item(7) -= CType(RegularizacionBindingSource.Current, DataRowView).Row.Item(2)
            CType(RegularizacionBindingSource.Current, DataRowView).Row.Item(4) = DBNull.Value
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If Me.ValidateChildren Then
            ProductBindingSource.EndEdit()
            If modify Then
                RegularizacionBindingSource.EndEdit()
                datos.modify(RegularizacionBindingSource.Current.Row.Item(0))
                AddHandler ToolStripButton1.Click, AddressOf NavigatorHandlers.Save
                modify = False
            End If
            setRead()
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        If RadioButton1.Checked Then
            InventarioTextBox.Enabled = True
            CantidadTextBox.Enabled = False
        Else
            CantidadTextBox.Enabled = True
            InventarioTextBox.Enabled = False
        End If
    End Sub

    Private Sub Regularizaciones_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MenuInventario.Show()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        If modify Then
            CType(RegularizacionBindingSource.Current, DataRowView).Row.Item(3) = ant
        End If
        RegularizacionBindingSource.Current.CancelEdit()
        ProductBindingSource.CancelEdit()
        setRead()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form As New FiltroProductos(1)
        form.ShowDialog()
        If form.getID IsNot Nothing Then
            CType(RegularizacionBindingSource.Current, DataRowView).Row.Item(3) = form.getID
            Label3.Text = DatosTPV.Product.FindByProductCode(form.getID).Name
        End If
    End Sub

    Private Sub MotivoTextBox_Validating(sender As TextBox, e As CancelEventArgs) Handles MotivoTextBox.Validating
        If String.IsNullOrEmpty(sender.Text) Then
            e.Cancel = True
            ErrorProvider1.SetError(sender, Constantes.MESSAGE_OBLIGATORY_FIELD)
        End If
        If Not e.Cancel Then
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub Button1_Validating(sender As Object, e As CancelEventArgs) Handles Button1.Validating
        If IsDBNull(CType(RegularizacionBindingSource.Current, DataRowView).Row.Item(3)) Then
            e.Cancel = True
            ErrorProvider1.SetError(sender, Constantes.MESSAGE_OBLIGATORY_FIELD)
        End If
        If Not e.Cancel Then
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub InventarioTextBox_Validating(sender As Object, e As CancelEventArgs) Handles TextBox1.Validating
        If String.IsNullOrEmpty(InventarioTextBox.Text) And String.IsNullOrEmpty(CantidadTextBox.Text) Then
            e.Cancel = True
            ErrorProvider1.SetError(GroupBox1, Constantes.MESSAGE_OBLIGATORY_FIELD)
        End If
        If Not e.Cancel Then
            ErrorProvider1.SetError(GroupBox1, "")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        RegularizacionBindingSource.Filter = FILTER_DEFAULT
    End Sub

    Private Sub ToolStripTextBox1_KeyDown(sender As ToolStripTextBox, e As KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            RegularizacionBindingSource.Filter += String.Format(FILTER_MOTIVO, sender.Text)
            If RegularizacionBindingSource.Count = 0 Then
                MsgBox(Constantes.NO_RESOULT, , Constantes.WARNING_DELETE)
                RegularizacionBindingSource.Filter = FILTER_DEFAULT
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RegularizacionBindingSource.Filter = FILTER_DEFAULT
    End Sub

    Private Sub DateTimePicker1_CloseUp(sender As Object, e As EventArgs) Handles DateTimePicker1.CloseUp
        RegularizacionBindingSource.Filter += String.Format(FILTER_FECHA, DateTimePicker1.Value.ToShortDateString, DateTimePicker1.Value.AddDays(1).ToShortDateString)
        If RegularizacionBindingSource.Count = 0 Then
            MsgBox(Constantes.NO_RESOULT, , Constantes.WARNING_DELETE)
            RegularizacionBindingSource.Filter = FILTER_DEFAULT
        End If
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim list As New ListaRegularizaciones(DatosTPV)
        list.ShowDialog()
        If list.id IsNot Nothing Then
            RegularizacionBindingSource.Position = RegularizacionBindingSource.Find("idRegularizacion", list.id.Cells.Item(0).Value)
        End If
    End Sub
End Class