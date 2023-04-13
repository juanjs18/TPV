<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacturasRealizadas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdFacturaLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Dim EmpresaLabel As System.Windows.Forms.Label
        Dim DomicilioLabel As System.Windows.Forms.Label
        Dim NifLabel As System.Windows.Forms.Label
        Dim PostalCodeLabel As System.Windows.Forms.Label
        Dim NameCityLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GestionesDataSet = New ConexionBD.DatosTPV()
        Me.FacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.FacturasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BtnBack = New System.Windows.Forms.ToolStripButton()
        Me.IdFacturaTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.EmpresaTextBox = New System.Windows.Forms.TextBox()
        Me.DomicilioTextBox = New System.Windows.Forms.TextBox()
        Me.NifTextBox = New System.Windows.Forms.TextBox()
        Me.LineaFacturaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LineaFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PostalCodeTextBox = New System.Windows.Forms.TextBox()
        Me.NameCityTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        IdFacturaLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        EmpresaLabel = New System.Windows.Forms.Label()
        DomicilioLabel = New System.Windows.Forms.Label()
        NifLabel = New System.Windows.Forms.Label()
        PostalCodeLabel = New System.Windows.Forms.Label()
        NameCityLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        CType(Me.GestionesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FacturasBindingNavigator.SuspendLayout()
        CType(Me.LineaFacturaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineaFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdFacturaLabel
        '
        IdFacturaLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        IdFacturaLabel.AutoSize = True
        IdFacturaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdFacturaLabel.Location = New System.Drawing.Point(26, 48)
        IdFacturaLabel.Name = "IdFacturaLabel"
        IdFacturaLabel.Size = New System.Drawing.Size(91, 25)
        IdFacturaLabel.TabIndex = 1
        IdFacturaLabel.Text = "Factura:"
        '
        'FechaLabel
        '
        FechaLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        FechaLabel.AutoSize = True
        FechaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.Location = New System.Drawing.Point(39, 100)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(78, 25)
        FechaLabel.TabIndex = 3
        FechaLabel.Text = "Fecha:"
        '
        'TotalLabel
        '
        TotalLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TotalLabel.AutoSize = True
        TotalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalLabel.Location = New System.Drawing.Point(452, 540)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(66, 25)
        TotalLabel.TabIndex = 5
        TotalLabel.Text = "Total:"
        '
        'EmpresaLabel
        '
        EmpresaLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        EmpresaLabel.AutoSize = True
        EmpresaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpresaLabel.Location = New System.Drawing.Point(14, 152)
        EmpresaLabel.Name = "EmpresaLabel"
        EmpresaLabel.Size = New System.Drawing.Size(103, 25)
        EmpresaLabel.TabIndex = 7
        EmpresaLabel.Text = "Empresa:"
        '
        'DomicilioLabel
        '
        DomicilioLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        DomicilioLabel.AutoSize = True
        DomicilioLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DomicilioLabel.Location = New System.Drawing.Point(413, 50)
        DomicilioLabel.Name = "DomicilioLabel"
        DomicilioLabel.Size = New System.Drawing.Size(105, 25)
        DomicilioLabel.TabIndex = 9
        DomicilioLabel.Text = "Domicilio:"
        '
        'NifLabel
        '
        NifLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        NifLabel.AutoSize = True
        NifLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NifLabel.Location = New System.Drawing.Point(66, 204)
        NifLabel.Name = "NifLabel"
        NifLabel.Size = New System.Drawing.Size(51, 25)
        NifLabel.TabIndex = 11
        NifLabel.Text = "NIF:"
        '
        'PostalCodeLabel
        '
        PostalCodeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        PostalCodeLabel.AutoSize = True
        PostalCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PostalCodeLabel.Location = New System.Drawing.Point(366, 101)
        PostalCodeLabel.Name = "PostalCodeLabel"
        PostalCodeLabel.Size = New System.Drawing.Size(152, 25)
        PostalCodeLabel.TabIndex = 17
        PostalCodeLabel.Text = "Codigo Postal:"
        '
        'NameCityLabel
        '
        NameCityLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        NameCityLabel.AutoSize = True
        NameCityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameCityLabel.Location = New System.Drawing.Point(432, 152)
        NameCityLabel.Name = "NameCityLabel"
        NameCityLabel.Size = New System.Drawing.Size(86, 25)
        NameCityLabel.TabIndex = 21
        NameCityLabel.Text = "Ciudad:"
        '
        'NameLabel
        '
        NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(458, 203)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(60, 25)
        NameLabel.TabIndex = 23
        NameLabel.Text = "País:"
        '
        'GestionesDataSet
        '
        Me.GestionesDataSet.DataSetName = "GestionesDataSet"
        Me.GestionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturasBindingSource
        '
        Me.FacturasBindingSource.DataMember = "Facturas"
        Me.FacturasBindingSource.DataSource = Me.GestionesDataSet
        '
        'FacturasBindingNavigator
        '
        Me.FacturasBindingNavigator.AddNewItem = Nothing
        Me.FacturasBindingNavigator.BindingSource = Me.FacturasBindingSource
        Me.FacturasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FacturasBindingNavigator.DeleteItem = Nothing
        Me.FacturasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.FacturasBindingNavigatorSaveItem, Me.BtnBack})
        Me.FacturasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FacturasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FacturasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FacturasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FacturasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FacturasBindingNavigator.Name = "FacturasBindingNavigator"
        Me.FacturasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FacturasBindingNavigator.Size = New System.Drawing.Size(787, 27)
        Me.FacturasBindingNavigator.TabIndex = 0
        Me.FacturasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 24)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
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
        'FacturasBindingNavigatorSaveItem
        '
        Me.FacturasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FacturasBindingNavigatorSaveItem.Image = Global.TPV.My.Resources.Resources.card_list_1
        Me.FacturasBindingNavigatorSaveItem.Name = "FacturasBindingNavigatorSaveItem"
        Me.FacturasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.FacturasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'BtnBack
        '
        Me.BtnBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BtnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnBack.Image = Global.TPV.My.Resources.Resources.arrow_back_circle_outline_1
        Me.BtnBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(23, 24)
        Me.BtnBack.Text = "ToolStripButton1"
        '
        'IdFacturaTextBox
        '
        Me.IdFacturaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IdFacturaTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.IdFacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturasBindingSource, "idFactura", True))
        Me.IdFacturaTextBox.Enabled = False
        Me.IdFacturaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdFacturaTextBox.Location = New System.Drawing.Point(147, 49)
        Me.IdFacturaTextBox.Name = "IdFacturaTextBox"
        Me.IdFacturaTextBox.Size = New System.Drawing.Size(200, 26)
        Me.IdFacturaTextBox.TabIndex = 2
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FacturasBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Enabled = False
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(147, 103)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaDateTimePicker.TabIndex = 4
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturasBindingSource, "total", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.TotalTextBox.Enabled = False
        Me.TotalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTextBox.Location = New System.Drawing.Point(567, 539)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(200, 26)
        Me.TotalTextBox.TabIndex = 6
        '
        'EmpresaTextBox
        '
        Me.EmpresaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.EmpresaTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.EmpresaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturasBindingSource, "empresa", True))
        Me.EmpresaTextBox.Enabled = False
        Me.EmpresaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpresaTextBox.Location = New System.Drawing.Point(147, 151)
        Me.EmpresaTextBox.Name = "EmpresaTextBox"
        Me.EmpresaTextBox.Size = New System.Drawing.Size(200, 26)
        Me.EmpresaTextBox.TabIndex = 8
        '
        'DomicilioTextBox
        '
        Me.DomicilioTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DomicilioTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DomicilioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturasBindingSource, "domicilio", True))
        Me.DomicilioTextBox.Enabled = False
        Me.DomicilioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DomicilioTextBox.Location = New System.Drawing.Point(567, 49)
        Me.DomicilioTextBox.Name = "DomicilioTextBox"
        Me.DomicilioTextBox.Size = New System.Drawing.Size(200, 26)
        Me.DomicilioTextBox.TabIndex = 10
        '
        'NifTextBox
        '
        Me.NifTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NifTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NifTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FacturasBindingSource, "nif", True))
        Me.NifTextBox.Enabled = False
        Me.NifTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NifTextBox.Location = New System.Drawing.Point(147, 205)
        Me.NifTextBox.Name = "NifTextBox"
        Me.NifTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NifTextBox.TabIndex = 12
        '
        'LineaFacturaDataGridView
        '
        Me.LineaFacturaDataGridView.AllowUserToAddRows = False
        Me.LineaFacturaDataGridView.AllowUserToDeleteRows = False
        Me.LineaFacturaDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineaFacturaDataGridView.AutoGenerateColumns = False
        Me.LineaFacturaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.LineaFacturaDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LineaFacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LineaFacturaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.LineaFacturaDataGridView.DataSource = Me.LineaFacturaBindingSource
        Me.LineaFacturaDataGridView.Location = New System.Drawing.Point(12, 237)
        Me.LineaFacturaDataGridView.Name = "LineaFacturaDataGridView"
        Me.LineaFacturaDataGridView.ReadOnly = True
        Me.LineaFacturaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.LineaFacturaDataGridView.Size = New System.Drawing.Size(755, 296)
        Me.LineaFacturaDataGridView.TabIndex = 15
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idLineaFactura"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idLineaFactura"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idFactura"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idFactura"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fecha"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "producto"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "cantidad"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "precioUnitario"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn6.HeaderText = "Precio Unitario"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "total"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn7.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'LineaFacturaBindingSource
        '
        Me.LineaFacturaBindingSource.DataMember = "FK_LineaFactura_Facturas1"
        Me.LineaFacturaBindingSource.DataSource = Me.FacturasBindingSource
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.GestionesDataSet
        '
        'PostalCodeTextBox
        '
        Me.PostalCodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PostalCodeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PostalCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "postalCode", True))
        Me.PostalCodeTextBox.Enabled = False
        Me.PostalCodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PostalCodeTextBox.Location = New System.Drawing.Point(567, 100)
        Me.PostalCodeTextBox.Name = "PostalCodeTextBox"
        Me.PostalCodeTextBox.Size = New System.Drawing.Size(200, 26)
        Me.PostalCodeTextBox.TabIndex = 18
        '
        'NameCityTextBox
        '
        Me.NameCityTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NameCityTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NameCityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "nameCity", True))
        Me.NameCityTextBox.Enabled = False
        Me.NameCityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameCityTextBox.Location = New System.Drawing.Point(567, 151)
        Me.NameCityTextBox.Name = "NameCityTextBox"
        Me.NameCityTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NameCityTextBox.TabIndex = 22
        '
        'NameTextBox
        '
        Me.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "country", True))
        Me.NameTextBox.Enabled = False
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.Location = New System.Drawing.Point(567, 202)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.NameTextBox.TabIndex = 24
        '
        'FacturasRealizadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.TPV.My.MySettings.Default.ColorP
        Me.ClientSize = New System.Drawing.Size(787, 608)
        Me.ControlBox = False
        Me.Controls.Add(PostalCodeLabel)
        Me.Controls.Add(Me.PostalCodeTextBox)
        Me.Controls.Add(NameCityLabel)
        Me.Controls.Add(Me.NameCityTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.LineaFacturaDataGridView)
        Me.Controls.Add(IdFacturaLabel)
        Me.Controls.Add(Me.IdFacturaTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(EmpresaLabel)
        Me.Controls.Add(Me.EmpresaTextBox)
        Me.Controls.Add(DomicilioLabel)
        Me.Controls.Add(Me.DomicilioTextBox)
        Me.Controls.Add(NifLabel)
        Me.Controls.Add(Me.NifTextBox)
        Me.Controls.Add(Me.FacturasBindingNavigator)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.MinimumSize = New System.Drawing.Size(803, 624)
        Me.Name = "FacturasRealizadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPV - Facturas realizadas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GestionesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FacturasBindingNavigator.ResumeLayout(False)
        Me.FacturasBindingNavigator.PerformLayout()
        CType(Me.LineaFacturaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineaFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GestionesDataSet As ConexionBD.DatosTPV
    Friend WithEvents FacturasBindingSource As BindingSource
    Friend WithEvents FacturasBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents FacturasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IdFacturaTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents EmpresaTextBox As TextBox
    Friend WithEvents DomicilioTextBox As TextBox
    Friend WithEvents NifTextBox As TextBox
    Friend WithEvents LineaFacturaBindingSource As BindingSource
    Friend WithEvents LineaFacturaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents PostalCodeTextBox As TextBox
    Friend WithEvents NameCityTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents BtnBack As ToolStripButton
End Class
