Imports System.ComponentModel
Imports ConexionBD.DatosTPVTableAdapters
Imports ProcesosEmpresariales

Public Class GestionClientes
    Private idPais As Integer
    Private Const FILTER_TICKETS_COBRADOS = "Parada = 'False'"
    Private Const FILTER_TICKETS_NOCOBRADOS = "Parada = 'True'"
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub GestionClientes_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MenuPrincipal.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If idPais <> 0 Then
            Dim list As New DirectionList(False, DatosTPV, idPais)
            list.ShowDialog()

            If list.row IsNot Nothing Then
                CType(UsersBindingSource.Current, DataRowView).Row.Item(3) = list.row.Row.Item(0)
                PostalCodeTextBox.Text = list.row.Row.Item(2)
                NameCityTextBox.Text = list.row.Row.Item(4)
                Me.ValidateChildren()
            End If
        End If
    End Sub
    Private Sub setRead()
        NameTextBox.Enabled = False
        StreetTextBox.Enabled = False
        NifTextBox.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        ToolStripTextBox1.Enabled = True
        ToolStripButton4.Enabled = True
        ToolStripButton1.Enabled = False
        ToolStripButton2.Enabled = True
        ToolStripButton3.Enabled = True
        ToolStripButton5.Enabled = False
        BindingNavigatorPositionItem1.Enabled = True
        ClientesBindingNavigator.PositionItem = BindingNavigatorPositionItem1
        BindingNavigatorDeleteItem1.Enabled = True
        BindingNavigatorAddNewItem1.Enabled = True
        ClientesBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem1
        ClientesBindingNavigator.MoveLastItem = BindingNavigatorMoveLastItem1
        ClientesBindingNavigator.MoveNextItem = BindingNavigatorMoveNextItem1
        ClientesBindingNavigator.MovePreviousItem = BindingNavigatorMovePreviousItem1
        BindingNavigatorAddNewItem1.Enabled = True
    End Sub

    Private Sub setModify()
        NameTextBox.Enabled = True
        StreetTextBox.Enabled = True
        NifTextBox.Enabled = True
        Button3.Enabled = True
        ToolStripButton1.Enabled = True
        ToolStripButton3.Enabled = False
        ToolStripButton5.Enabled = True
        ToolStripTextBox1.Enabled = False
        ToolStripButton4.Enabled = False
        ToolStripButton2.Enabled = False
        ClientesBindingNavigator.PositionItem = Nothing
        BindingNavigatorPositionItem1.Enabled = False
        ClientesBindingNavigator.MoveFirstItem = Nothing
        ClientesBindingNavigator.MoveLastItem = Nothing
        ClientesBindingNavigator.MoveNextItem = Nothing
        ClientesBindingNavigator.MovePreviousItem = Nothing
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
    Private Sub GestionClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DatosTPV = MenuPrincipal.DatosTPV1
        Dim adapterAlbaran As New AlbaranTableAdapter
        adapterAlbaran.Fill(DatosTPV.Albaran)
        Dim adapterFacturas As New FacturasTableAdapter
        adapterFacturas.Fill(DatosTPV.Facturas)
        UsersBindingSource.DataSource = DatosTPV
        UsersBindingSource.DataMember = "Users"
        DataTable1BindingSource.DataSource = UsersBindingSource
        TicketBindingSource.DataSource = UsersBindingSource
        TicketBindingSource.DataMember = "Users_Ticket"
        TicketBindingSource.Filter = FILTER_TICKETS_COBRADOS
        FacturasBindingSource.DataSource = UsersBindingSource
        FacturasBindingSource.DataMember = "Users_Facturas"
        setRead()
        Dim tag As New Users(DatosTPV)
        ToolStripButton1.Tag = tag
        BindingNavigatorDeleteItem1.Tag = tag
        AddHandler ToolStripButton1.Click, AddressOf NavigatorHandlers.Save
        AddHandler BindingNavigatorDeleteItem1.Click, AddressOf NavigatorHandlers.Delete
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim list As New DirectionList(True, DatosTPV, 0)
        list.ShowDialog()
        If list.row IsNot Nothing Then
            CType(UsersBindingSource.Current, DataRowView).Row.Item(3) = list.row.Row.Item(0)
            CountryTextBox.Text = list.row.Row.Item(1)
            Button2.Enabled = True
            Me.ValidateChildren()
        End If
    End Sub

    Private Sub UsersBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles UsersBindingSource.CurrentChanged
        Try
            idPais = CType(DataTable1BindingSource.Current, DataRowView).Row.Item(1)
        Catch ex As Exception
            idPais = -1
        End Try
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        Dim list As New Empresa
        list.ShowDialog()
        If list.getID <> 0 Then
            UsersBindingSource.Position = UsersBindingSource.Find("idUser", list.getID)
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem1_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem1.Click
        setModify()
        CountryTextBox.Text = CType(DataTable1BindingSource.Current, DataRowView).Row.Item(2)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        setModify()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        UsersBindingSource.CancelEdit()
        setRead()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If Me.ValidateChildren Then
            setRead()
        End If
    End Sub

    Private Sub ValidatingTextBox(sender As TextBox, e As CancelEventArgs) Handles NifTextBox.Validating, NameTextBox.Validating, StreetTextBox.Validating, NameCityTextBox.Validating, CountryTextBox.Validating, PostalCodeTextBox.Validating
        If String.IsNullOrEmpty(sender.Text) Then
            e.Cancel = True
            ErrorProvider1.SetError(sender, Constantes.MESSAGE_OBLIGATORY_FIELD)
        End If
        If Not e.Cancel Then
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub ToolStripTextBox1_KeyDown(sender As ToolStripTextBox, e As KeyEventArgs) Handles ToolStripTextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim filter As String = "name LIKE '*{0}*'"
            UsersBindingSource.Filter = String.Format(filter, sender.Text)
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        UsersBindingSource.RemoveFilter()
    End Sub

    Private Sub TicketDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TicketDataGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim detail As New DetalleTicket(TicketBindingSource.Current, DatosTPV)
            detail.ShowDialog()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged
        If RadioButton1.Checked Then
            TicketBindingSource.Filter = FILTER_TICKETS_COBRADOS
        Else
            TicketBindingSource.Filter = FILTER_TICKETS_NOCOBRADOS
        End If
    End Sub

    Private Sub FacturasDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles FacturasDataGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim form As New FacturasRealizadas(FacturasDataGridView.Rows.Item(e.RowIndex).Cells.Item(0).Value)
            form.ShowDialog()
        End If
    End Sub
End Class