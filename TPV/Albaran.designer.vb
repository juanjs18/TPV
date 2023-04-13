<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Albaran
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdAlbaranLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim IdUserLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim StreetLabel As System.Windows.Forms.Label
        Dim IdPostalCodeLabel As System.Windows.Forms.Label
        Dim NifLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.IdUserDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StreetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdPostalCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NifDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlbaranBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.AlbaranBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GestionesDataSet = New ConexionBD.DatosTPV()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorModifyItem = New System.Windows.Forms.ToolStripButton()
        Me.AlbaranBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorListItem = New System.Windows.Forms.ToolStripButton()
        Me.BttnAtras = New System.Windows.Forms.ToolStripButton()
        Me.BtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.IdAlbaranTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdUserTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StreetTextBox = New System.Windows.Forms.TextBox()
        Me.NifTextBox = New System.Windows.Forms.TextBox()
        Me.PostalCodeTextBox = New System.Windows.Forms.TextBox()
        Me.PostalCodeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BttnBuscarEmpresa = New System.Windows.Forms.Button()
        Me.AmountTextBox = New System.Windows.Forms.TextBox()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SelectProduct = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        IdAlbaranLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        IdUserLabel = New System.Windows.Forms.Label()
        AmountLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        StreetLabel = New System.Windows.Forms.Label()
        IdPostalCodeLabel = New System.Windows.Forms.Label()
        NifLabel = New System.Windows.Forms.Label()
        CType(Me.AlbaranBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AlbaranBindingNavigator.SuspendLayout()
        CType(Me.AlbaranBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestionesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PostalCodeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdAlbaranLabel
        '
        IdAlbaranLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        IdAlbaranLabel.AutoSize = True
        IdAlbaranLabel.Enabled = False
        IdAlbaranLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdAlbaranLabel.Location = New System.Drawing.Point(36, 48)
        IdAlbaranLabel.Name = "IdAlbaranLabel"
        IdAlbaranLabel.Size = New System.Drawing.Size(92, 25)
        IdAlbaranLabel.TabIndex = 1
        IdAlbaranLabel.Text = "Albaran:"
        '
        'DateLabel
        '
        DateLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        DateLabel.AutoSize = True
        DateLabel.Enabled = False
        DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateLabel.Location = New System.Drawing.Point(466, 45)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(78, 25)
        DateLabel.TabIndex = 3
        DateLabel.Text = "Fecha:"
        '
        'IdUserLabel
        '
        IdUserLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        IdUserLabel.AutoSize = True
        IdUserLabel.Enabled = False
        IdUserLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdUserLabel.Location = New System.Drawing.Point(36, 158)
        IdUserLabel.Name = "IdUserLabel"
        IdUserLabel.Size = New System.Drawing.Size(103, 25)
        IdUserLabel.TabIndex = 5
        IdUserLabel.Text = "Empresa:"
        '
        'AmountLabel
        '
        AmountLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        AmountLabel.AutoSize = True
        AmountLabel.Enabled = False
        AmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AmountLabel.Location = New System.Drawing.Point(536, 574)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(66, 25)
        AmountLabel.TabIndex = 7
        AmountLabel.Text = "Total:"
        '
        'NameLabel
        '
        NameLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        NameLabel.AutoSize = True
        NameLabel.Enabled = False
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(36, 207)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(93, 25)
        NameLabel.TabIndex = 12
        NameLabel.Text = "Nombre:"
        '
        'StreetLabel
        '
        StreetLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        StreetLabel.AutoSize = True
        StreetLabel.Enabled = False
        StreetLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StreetLabel.Location = New System.Drawing.Point(466, 116)
        StreetLabel.Name = "StreetLabel"
        StreetLabel.Size = New System.Drawing.Size(105, 25)
        StreetLabel.TabIndex = 14
        StreetLabel.Text = "Domicilio:"
        '
        'IdPostalCodeLabel
        '
        IdPostalCodeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        IdPostalCodeLabel.AutoSize = True
        IdPostalCodeLabel.Enabled = False
        IdPostalCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdPostalCodeLabel.Location = New System.Drawing.Point(466, 162)
        IdPostalCodeLabel.Name = "IdPostalCodeLabel"
        IdPostalCodeLabel.Size = New System.Drawing.Size(152, 25)
        IdPostalCodeLabel.TabIndex = 16
        IdPostalCodeLabel.Text = "Codigo Postal:"
        '
        'NifLabel
        '
        NifLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        NifLabel.AutoSize = True
        NifLabel.Enabled = False
        NifLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NifLabel.Location = New System.Drawing.Point(466, 207)
        NifLabel.Name = "NifLabel"
        NifLabel.Size = New System.Drawing.Size(51, 25)
        NifLabel.TabIndex = 18
        NifLabel.Text = "NIF:"
        '
        'IdUserDataGridViewTextBoxColumn
        '
        Me.IdUserDataGridViewTextBoxColumn.DataPropertyName = "idUser"
        Me.IdUserDataGridViewTextBoxColumn.HeaderText = "idUser"
        Me.IdUserDataGridViewTextBoxColumn.Name = "IdUserDataGridViewTextBoxColumn"
        Me.IdUserDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'StreetDataGridViewTextBoxColumn
        '
        Me.StreetDataGridViewTextBoxColumn.DataPropertyName = "street"
        Me.StreetDataGridViewTextBoxColumn.HeaderText = "street"
        Me.StreetDataGridViewTextBoxColumn.Name = "StreetDataGridViewTextBoxColumn"
        '
        'IdPostalCodeDataGridViewTextBoxColumn
        '
        Me.IdPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "idPostalCode"
        Me.IdPostalCodeDataGridViewTextBoxColumn.HeaderText = "idPostalCode"
        Me.IdPostalCodeDataGridViewTextBoxColumn.Name = "IdPostalCodeDataGridViewTextBoxColumn"
        '
        'NifDataGridViewTextBoxColumn
        '
        Me.NifDataGridViewTextBoxColumn.DataPropertyName = "nif"
        Me.NifDataGridViewTextBoxColumn.HeaderText = "nif"
        Me.NifDataGridViewTextBoxColumn.Name = "NifDataGridViewTextBoxColumn"
        '
        'AlbaranBindingNavigator
        '
        Me.AlbaranBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AlbaranBindingNavigator.BindingSource = Me.AlbaranBindingSource
        Me.AlbaranBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AlbaranBindingNavigator.DeleteItem = Nothing
        Me.AlbaranBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorModifyItem, Me.AlbaranBindingNavigatorSaveItem, Me.BindingNavigatorListItem, Me.BttnAtras, Me.BtnCancelar})
        Me.AlbaranBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AlbaranBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AlbaranBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AlbaranBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AlbaranBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AlbaranBindingNavigator.Name = "AlbaranBindingNavigator"
        Me.AlbaranBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AlbaranBindingNavigator.Size = New System.Drawing.Size(884, 27)
        Me.AlbaranBindingNavigator.TabIndex = 0
        Me.AlbaranBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = Global.TPV.My.Resources.Resources.plus_17
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'AlbaranBindingSource
        '
        Me.AlbaranBindingSource.DataMember = "Albaran"
        Me.AlbaranBindingSource.DataSource = Me.GestionesDataSet
        '
        'GestionesDataSet
        '
        Me.GestionesDataSet.DataSetName = "GestionesDataSet"
        Me.GestionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = Global.TPV.My.Resources.Resources.skip_backward_3
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = Global.TPV.My.Resources.Resources.arrow_back_ios_1
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = Global.TPV.My.Resources.Resources.next_4
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = Global.TPV.My.Resources.Resources.skip_forward_3
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = Global.TPV.My.Resources.Resources.delete_1
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorModifyItem
        '
        Me.BindingNavigatorModifyItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorModifyItem.Image = Global.TPV.My.Resources.Resources.modifyicon
        Me.BindingNavigatorModifyItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorModifyItem.Name = "BindingNavigatorModifyItem"
        Me.BindingNavigatorModifyItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorModifyItem.Text = "Modificar"
        '
        'AlbaranBindingNavigatorSaveItem
        '
        Me.AlbaranBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AlbaranBindingNavigatorSaveItem.Enabled = False
        Me.AlbaranBindingNavigatorSaveItem.Image = Global.TPV.My.Resources.Resources.save_19
        Me.AlbaranBindingNavigatorSaveItem.Name = "AlbaranBindingNavigatorSaveItem"
        Me.AlbaranBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.AlbaranBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'BindingNavigatorListItem
        '
        Me.BindingNavigatorListItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorListItem.Image = Global.TPV.My.Resources.Resources.card_list_1
        Me.BindingNavigatorListItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BindingNavigatorListItem.Name = "BindingNavigatorListItem"
        Me.BindingNavigatorListItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorListItem.Text = "Filtrar"
        '
        'BttnAtras
        '
        Me.BttnAtras.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BttnAtras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BttnAtras.Image = Global.TPV.My.Resources.Resources.arrow_back_circle_outline_1
        Me.BttnAtras.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BttnAtras.Name = "BttnAtras"
        Me.BttnAtras.Size = New System.Drawing.Size(23, 24)
        Me.BttnAtras.Text = "Atrás"
        '
        'BtnCancelar
        '
        Me.BtnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnCancelar.Enabled = False
        Me.BtnCancelar.Image = Global.TPV.My.Resources.Resources._66847
        Me.BtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(23, 24)
        Me.BtnCancelar.Text = "Cancelar"
        '
        'IdAlbaranTextBox
        '
        Me.IdAlbaranTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.IdAlbaranTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.IdAlbaranTextBox.Cursor = System.Windows.Forms.Cursors.No
        Me.IdAlbaranTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlbaranBindingSource, "idAlbaran", True))
        Me.IdAlbaranTextBox.Enabled = False
        Me.IdAlbaranTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdAlbaranTextBox.Location = New System.Drawing.Point(157, 48)
        Me.IdAlbaranTextBox.Name = "IdAlbaranTextBox"
        Me.IdAlbaranTextBox.Size = New System.Drawing.Size(200, 21)
        Me.IdAlbaranTextBox.TabIndex = 2
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.DateDateTimePicker.Cursor = System.Windows.Forms.Cursors.No
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AlbaranBindingSource, "date", True))
        Me.DateDateTimePicker.Enabled = False
        Me.DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateDateTimePicker.Location = New System.Drawing.Point(587, 46)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(247, 21)
        Me.DateDateTimePicker.TabIndex = 1
        '
        'IdUserTextBox
        '
        Me.IdUserTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.IdUserTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.IdUserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlbaranBindingSource, "idUser", True))
        Me.IdUserTextBox.Enabled = False
        Me.IdUserTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdUserTextBox.Location = New System.Drawing.Point(157, 162)
        Me.IdUserTextBox.Name = "IdUserTextBox"
        Me.IdUserTextBox.Size = New System.Drawing.Size(200, 21)
        Me.IdUserTextBox.TabIndex = 6
        '
        'NameTextBox
        '
        Me.NameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.NameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NameTextBox.Cursor = System.Windows.Forms.Cursors.No
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "name", True))
        Me.NameTextBox.Enabled = False
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(157, 207)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 21)
        Me.NameTextBox.TabIndex = 13
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.GestionesDataSet
        '
        'StreetTextBox
        '
        Me.StreetTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.StreetTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.StreetTextBox.Cursor = System.Windows.Forms.Cursors.No
        Me.StreetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "street", True))
        Me.StreetTextBox.Enabled = False
        Me.StreetTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StreetTextBox.Location = New System.Drawing.Point(634, 116)
        Me.StreetTextBox.Name = "StreetTextBox"
        Me.StreetTextBox.Size = New System.Drawing.Size(200, 21)
        Me.StreetTextBox.TabIndex = 15
        '
        'NifTextBox
        '
        Me.NifTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.NifTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NifTextBox.Cursor = System.Windows.Forms.Cursors.No
        Me.NifTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "nif", True))
        Me.NifTextBox.Enabled = False
        Me.NifTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NifTextBox.Location = New System.Drawing.Point(634, 207)
        Me.NifTextBox.Name = "NifTextBox"
        Me.NifTextBox.Size = New System.Drawing.Size(200, 21)
        Me.NifTextBox.TabIndex = 19
        '
        'PostalCodeTextBox
        '
        Me.PostalCodeTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.PostalCodeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PostalCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PostalCodeBindingSource, "postalCode", True))
        Me.PostalCodeTextBox.Enabled = False
        Me.PostalCodeTextBox.Location = New System.Drawing.Point(634, 162)
        Me.PostalCodeTextBox.Name = "PostalCodeTextBox"
        Me.PostalCodeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PostalCodeTextBox.TabIndex = 22
        '
        'PostalCodeBindingSource
        '
        Me.PostalCodeBindingSource.DataMember = "PostalCode"
        Me.PostalCodeBindingSource.DataSource = Me.GestionesDataSet
        '
        'BttnBuscarEmpresa
        '
        Me.BttnBuscarEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BttnBuscarEmpresa.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.BttnBuscarEmpresa.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.BttnBuscarEmpresa.Enabled = False
        Me.BttnBuscarEmpresa.Location = New System.Drawing.Point(363, 162)
        Me.BttnBuscarEmpresa.Name = "BttnBuscarEmpresa"
        Me.BttnBuscarEmpresa.Size = New System.Drawing.Size(27, 24)
        Me.BttnBuscarEmpresa.TabIndex = 0
        Me.BttnBuscarEmpresa.Text = "..."
        Me.BttnBuscarEmpresa.UseVisualStyleBackColor = False
        '
        'AmountTextBox
        '
        Me.AmountTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AmountTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AlbaranBindingSource, "amount", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.AmountTextBox.Enabled = False
        Me.AmountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountTextBox.Location = New System.Drawing.Point(634, 568)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(200, 31)
        Me.AmountTextBox.TabIndex = 30
        Me.AmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.AllowNew = True
        Me.OrdersBindingSource.DataMember = "FK_Orders_Albaran"
        Me.OrdersBindingSource.DataSource = Me.AlbaranBindingSource
        '
        'OrdersDataGridView
        '
        Me.OrdersDataGridView.AllowUserToAddRows = False
        Me.OrdersDataGridView.AllowUserToDeleteRows = False
        Me.OrdersDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OrdersDataGridView.AutoGenerateColumns = False
        Me.OrdersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.OrdersDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrdersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.SelectProduct, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.OrdersDataGridView.DataSource = Me.OrdersBindingSource
        Me.OrdersDataGridView.Location = New System.Drawing.Point(41, 235)
        Me.OrdersDataGridView.Name = "OrdersDataGridView"
        Me.OrdersDataGridView.ReadOnly = True
        Me.OrdersDataGridView.Size = New System.Drawing.Size(793, 327)
        Me.OrdersDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idOrders"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idOrders"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'SelectProduct
        '
        Me.SelectProduct.FillWeight = 36.54822!
        Me.SelectProduct.HeaderText = "Buscar"
        Me.SelectProduct.Name = "SelectProduct"
        Me.SelectProduct.ReadOnly = True
        Me.SelectProduct.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idProduct"
        Me.DataGridViewTextBoxColumn2.FillWeight = 112.6904!
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID Producto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "descriptionsProduct"
        Me.DataGridViewTextBoxColumn3.FillWeight = 112.6904!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Quantity"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn4.FillWeight = 112.6904!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.FillWeight = 112.6904!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Precio Unitario"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "amountOrders"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn6.FillWeight = 112.6904!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "idAlbaran"
        Me.DataGridViewTextBoxColumn7.HeaderText = "idAlbaran"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.DataMember = "Orders"
        Me.ErrorProvider1.DataSource = Me.GestionesDataSet
        '
        'Albaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.TPV.My.MySettings.Default.ColorP
        Me.ClientSize = New System.Drawing.Size(884, 648)
        Me.Controls.Add(Me.OrdersDataGridView)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Me.BttnBuscarEmpresa)
        Me.Controls.Add(Me.PostalCodeTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(StreetLabel)
        Me.Controls.Add(Me.StreetTextBox)
        Me.Controls.Add(IdPostalCodeLabel)
        Me.Controls.Add(NifLabel)
        Me.Controls.Add(Me.NifTextBox)
        Me.Controls.Add(IdAlbaranLabel)
        Me.Controls.Add(Me.IdAlbaranTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(IdUserLabel)
        Me.Controls.Add(Me.IdUserTextBox)
        Me.Controls.Add(AmountLabel)
        Me.Controls.Add(Me.AlbaranBindingNavigator)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.MinimumSize = New System.Drawing.Size(886, 650)
        Me.Name = "Albaran"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPV - Albaran"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AlbaranBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AlbaranBindingNavigator.ResumeLayout(False)
        Me.AlbaranBindingNavigator.PerformLayout()
        CType(Me.AlbaranBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestionesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PostalCodeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents IdUserDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StreetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdPostalCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NifDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GestionesDataSet As ConexionBD.DatosTPV
    Friend WithEvents AlbaranBindingSource As BindingSource
    Friend WithEvents AlbaranBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents AlbaranBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdAlbaranTextBox As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents IdUserTextBox As TextBox
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents StreetTextBox As TextBox
    Friend WithEvents NifTextBox As TextBox
    Friend WithEvents BttnAtras As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorModifyItem As ToolStripButton
    Friend WithEvents BindingNavigatorListItem As ToolStripButton
    Friend WithEvents PostalCodeBindingSource As BindingSource
    Friend WithEvents PostalCodeTextBox As TextBox
    Friend WithEvents BttnBuscarEmpresa As Button
    Friend WithEvents AmountTextBox As TextBox
    Friend WithEvents BtnCancelar As ToolStripButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OrdersDataGridView As DataGridView
    Friend WithEvents OrdersBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SelectProduct As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
