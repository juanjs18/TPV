<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Compras
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
        Dim IDCompraLabel As System.Windows.Forms.Label
        Dim TotalCompraLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ComprasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ComprasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosTPV = New ConexionBD.DatosTPV()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.ComprasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BtnModify = New System.Windows.Forms.ToolStripButton()
        Me.BtnList = New System.Windows.Forms.ToolStripButton()
        Me.BtnCancel = New System.Windows.Forms.ToolStripButton()
        Me.IDCompraTextBox = New System.Windows.Forms.TextBox()
        Me.TotalCompraTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.LineaCompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LineaCompraDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuscarProducto = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IDCompraLabel = New System.Windows.Forms.Label()
        TotalCompraLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        CType(Me.ComprasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ComprasBindingNavigator.SuspendLayout()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosTPV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineaCompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineaCompraDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDCompraLabel
        '
        IDCompraLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        IDCompraLabel.AutoSize = True
        IDCompraLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDCompraLabel.Location = New System.Drawing.Point(218, 51)
        IDCompraLabel.Name = "IDCompraLabel"
        IDCompraLabel.Size = New System.Drawing.Size(90, 20)
        IDCompraLabel.TabIndex = 1
        IDCompraLabel.Text = "ID Compra:"
        '
        'TotalCompraLabel
        '
        TotalCompraLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TotalCompraLabel.AutoSize = True
        TotalCompraLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalCompraLabel.Location = New System.Drawing.Point(473, 434)
        TotalCompraLabel.Name = "TotalCompraLabel"
        TotalCompraLabel.Size = New System.Drawing.Size(108, 20)
        TotalCompraLabel.TabIndex = 3
        TotalCompraLabel.Text = "Total Compra:"
        '
        'FechaLabel
        '
        FechaLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        FechaLabel.AutoSize = True
        FechaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaLabel.Location = New System.Drawing.Point(218, 92)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(58, 20)
        FechaLabel.TabIndex = 5
        FechaLabel.Text = "Fecha:"
        '
        'ComprasBindingNavigator
        '
        Me.ComprasBindingNavigator.AddNewItem = Nothing
        Me.ComprasBindingNavigator.BindingSource = Me.ComprasBindingSource
        Me.ComprasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ComprasBindingNavigator.DeleteItem = Nothing
        Me.ComprasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ComprasBindingNavigatorSaveItem, Me.BtnModify, Me.BtnList, Me.BtnCancel})
        Me.ComprasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ComprasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ComprasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ComprasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ComprasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ComprasBindingNavigator.Name = "ComprasBindingNavigator"
        Me.ComprasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ComprasBindingNavigator.Size = New System.Drawing.Size(814, 27)
        Me.ComprasBindingNavigator.TabIndex = 0
        Me.ComprasBindingNavigator.Text = "BindingNavigator1"
        '
        'ComprasBindingSource
        '
        Me.ComprasBindingSource.DataMember = "Compras"
        Me.ComprasBindingSource.DataSource = Me.DatosTPV
        '
        'DatosTPV
        '
        Me.DatosTPV.DataSetName = "DatosTPV"
        Me.DatosTPV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 24)
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = Global.TPV.My.Resources.Resources.plus_17
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
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
        'ComprasBindingNavigatorSaveItem
        '
        Me.ComprasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ComprasBindingNavigatorSaveItem.Enabled = False
        Me.ComprasBindingNavigatorSaveItem.Image = Global.TPV.My.Resources.Resources.save_19
        Me.ComprasBindingNavigatorSaveItem.Name = "ComprasBindingNavigatorSaveItem"
        Me.ComprasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.ComprasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'BtnModify
        '
        Me.BtnModify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnModify.Image = Global.TPV.My.Resources.Resources.modifyicon
        Me.BtnModify.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnModify.Name = "BtnModify"
        Me.BtnModify.Size = New System.Drawing.Size(23, 24)
        Me.BtnModify.Text = "Modificar"
        '
        'BtnList
        '
        Me.BtnList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnList.Image = Global.TPV.My.Resources.Resources.card_list_1
        Me.BtnList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnList.Name = "BtnList"
        Me.BtnList.Size = New System.Drawing.Size(23, 24)
        Me.BtnList.Text = "Listar"
        '
        'BtnCancel
        '
        Me.BtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnCancel.Enabled = False
        Me.BtnCancel.Image = Global.TPV.My.Resources.Resources._66847
        Me.BtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(23, 24)
        Me.BtnCancel.Text = "Cancelar cambios"
        '
        'IDCompraTextBox
        '
        Me.IDCompraTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.IDCompraTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.IDCompraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "IDCompra", True))
        Me.IDCompraTextBox.Enabled = False
        Me.IDCompraTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDCompraTextBox.Location = New System.Drawing.Point(333, 51)
        Me.IDCompraTextBox.Name = "IDCompraTextBox"
        Me.IDCompraTextBox.Size = New System.Drawing.Size(200, 22)
        Me.IDCompraTextBox.TabIndex = 2
        '
        'TotalCompraTextBox
        '
        Me.TotalCompraTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalCompraTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TotalCompraTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ComprasBindingSource, "TotalCompra", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.TotalCompraTextBox.Enabled = False
        Me.TotalCompraTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCompraTextBox.Location = New System.Drawing.Point(588, 434)
        Me.TotalCompraTextBox.Name = "TotalCompraTextBox"
        Me.TotalCompraTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TotalCompraTextBox.TabIndex = 4
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ComprasBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Enabled = False
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(333, 91)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaDateTimePicker.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.TPV.My.Resources.Resources.arrow_back_circle_outline_1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 403)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'LineaCompraBindingSource
        '
        Me.LineaCompraBindingSource.DataMember = "FK_LineaCompra_Compras"
        Me.LineaCompraBindingSource.DataSource = Me.ComprasBindingSource
        '
        'LineaCompraDataGridView
        '
        Me.LineaCompraDataGridView.AllowUserToAddRows = False
        Me.LineaCompraDataGridView.AllowUserToDeleteRows = False
        Me.LineaCompraDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineaCompraDataGridView.AutoGenerateColumns = False
        Me.LineaCompraDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.LineaCompraDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LineaCompraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LineaCompraDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.BuscarProducto, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.LineaCompraDataGridView.DataSource = Me.LineaCompraBindingSource
        Me.LineaCompraDataGridView.Location = New System.Drawing.Point(12, 117)
        Me.LineaCompraDataGridView.Name = "LineaCompraDataGridView"
        Me.LineaCompraDataGridView.ReadOnly = True
        Me.LineaCompraDataGridView.Size = New System.Drawing.Size(776, 280)
        Me.LineaCompraDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDLineaCompra"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDLineaCompra"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'BuscarProducto
        '
        Me.BuscarProducto.FillWeight = 20.0!
        Me.BuscarProducto.HeaderText = "Buscar producto"
        Me.BuscarProducto.Name = "BuscarProducto"
        Me.BuscarProducto.ReadOnly = True
        Me.BuscarProducto.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductCode"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ID Producto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Cantidad"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IDCompra"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IDCompra"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PrecioCompra"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Total"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'Compras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.TPV.My.MySettings.Default.ColorP
        Me.ClientSize = New System.Drawing.Size(814, 522)
        Me.Controls.Add(Me.LineaCompraDataGridView)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(IDCompraLabel)
        Me.Controls.Add(Me.IDCompraTextBox)
        Me.Controls.Add(TotalCompraLabel)
        Me.Controls.Add(Me.TotalCompraTextBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(Me.ComprasBindingNavigator)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.MinimumSize = New System.Drawing.Size(816, 524)
        Me.Name = "Compras"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPV - Compras"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ComprasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ComprasBindingNavigator.ResumeLayout(False)
        Me.ComprasBindingNavigator.PerformLayout()
        CType(Me.ComprasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosTPV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineaCompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineaCompraDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatosTPV As ConexionBD.DatosTPV
    Friend WithEvents ComprasBindingSource As BindingSource
    Friend WithEvents ComprasBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents ComprasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BtnList As ToolStripButton
    Friend WithEvents BtnCancel As ToolStripButton
    Friend WithEvents IDCompraTextBox As TextBox
    Friend WithEvents TotalCompraTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnModify As ToolStripButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents LineaCompraDataGridView As DataGridView
    Friend WithEvents LineaCompraBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents BuscarProducto As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
