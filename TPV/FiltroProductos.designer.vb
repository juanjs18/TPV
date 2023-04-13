<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FiltroProductos
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnProductos = New System.Windows.Forms.Button()
        Me.LblCategorias = New System.Windows.Forms.Label()
        Me.TBoxProductos = New System.Windows.Forms.TextBox()
        Me.BtnCategorias = New System.Windows.Forms.Button()
        Me.LblProductos = New System.Windows.Forms.Label()
        Me.BtnCancelarFiltro = New System.Windows.Forms.Button()
        Me.GestionesDataSet = New ConexionBD.DatosTPV()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductDataGridView = New System.Windows.Forms.DataGridView()
        Me.RBtnVendible = New System.Windows.Forms.RadioButton()
        Me.RBtnNoVendible = New System.Windows.Forms.RadioButton()
        Me.RBtnStockable = New System.Windows.Forms.RadioButton()
        Me.RBtnNoStockable = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RBtnNombre = New System.Windows.Forms.RadioButton()
        Me.RBtnID = New System.Windows.Forms.RadioButton()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.GestionesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnProductos
        '
        Me.BtnProductos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnProductos.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.BtnProductos.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.BtnProductos.Location = New System.Drawing.Point(534, 84)
        Me.BtnProductos.Name = "BtnProductos"
        Me.BtnProductos.Size = New System.Drawing.Size(104, 44)
        Me.BtnProductos.TabIndex = 1
        Me.BtnProductos.Text = "Buscar"
        Me.BtnProductos.UseVisualStyleBackColor = False
        '
        'LblCategorias
        '
        Me.LblCategorias.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblCategorias.AutoSize = True
        Me.LblCategorias.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCategorias.Location = New System.Drawing.Point(206, 26)
        Me.LblCategorias.Name = "LblCategorias"
        Me.LblCategorias.Size = New System.Drawing.Size(216, 25)
        Me.LblCategorias.TabIndex = 4
        Me.LblCategorias.Text = "Filtrar por categorias:"
        '
        'TBoxProductos
        '
        Me.TBoxProductos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TBoxProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TBoxProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxProductos.Location = New System.Drawing.Point(428, 88)
        Me.TBoxProductos.Name = "TBoxProductos"
        Me.TBoxProductos.Size = New System.Drawing.Size(100, 31)
        Me.TBoxProductos.TabIndex = 0
        '
        'BtnCategorias
        '
        Me.BtnCategorias.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnCategorias.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.BtnCategorias.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.BtnCategorias.Location = New System.Drawing.Point(428, 19)
        Me.BtnCategorias.Name = "BtnCategorias"
        Me.BtnCategorias.Size = New System.Drawing.Size(104, 44)
        Me.BtnCategorias.TabIndex = 6
        Me.BtnCategorias.Text = "Buscar categorias"
        Me.BtnCategorias.UseVisualStyleBackColor = False
        '
        'LblProductos
        '
        Me.LblProductos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblProductos.AutoSize = True
        Me.LblProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProductos.Location = New System.Drawing.Point(206, 91)
        Me.LblProductos.Name = "LblProductos"
        Me.LblProductos.Size = New System.Drawing.Size(211, 25)
        Me.LblProductos.TabIndex = 7
        Me.LblProductos.Text = "Filtrar por productos:"
        '
        'BtnCancelarFiltro
        '
        Me.BtnCancelarFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnCancelarFiltro.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.BtnCancelarFiltro.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.BtnCancelarFiltro.Location = New System.Drawing.Point(534, 19)
        Me.BtnCancelarFiltro.Name = "BtnCancelarFiltro"
        Me.BtnCancelarFiltro.Size = New System.Drawing.Size(104, 44)
        Me.BtnCancelarFiltro.TabIndex = 7
        Me.BtnCancelarFiltro.Text = "Cancelar filtro"
        Me.BtnCancelarFiltro.UseVisualStyleBackColor = False
        '
        'GestionesDataSet
        '
        Me.GestionesDataSet.DataSetName = "GestionesDataSet"
        Me.GestionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.GestionesDataSet
        '
        'ProductDataGridView
        '
        Me.ProductDataGridView.AllowUserToAddRows = False
        Me.ProductDataGridView.AllowUserToDeleteRows = False
        Me.ProductDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProductDataGridView.AutoGenerateColumns = False
        Me.ProductDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ProductDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn1, Me.Stock})
        Me.ProductDataGridView.DataSource = Me.ProductBindingSource
        Me.ProductDataGridView.Location = New System.Drawing.Point(12, 162)
        Me.ProductDataGridView.Name = "ProductDataGridView"
        Me.ProductDataGridView.ReadOnly = True
        Me.ProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductDataGridView.Size = New System.Drawing.Size(626, 347)
        Me.ProductDataGridView.TabIndex = 2
        '
        'RBtnVendible
        '
        Me.RBtnVendible.AutoSize = True
        Me.RBtnVendible.Checked = True
        Me.RBtnVendible.Location = New System.Drawing.Point(1, 13)
        Me.RBtnVendible.Name = "RBtnVendible"
        Me.RBtnVendible.Size = New System.Drawing.Size(66, 17)
        Me.RBtnVendible.TabIndex = 0
        Me.RBtnVendible.TabStop = True
        Me.RBtnVendible.Text = "Vendible"
        Me.RBtnVendible.UseVisualStyleBackColor = True
        '
        'RBtnNoVendible
        '
        Me.RBtnNoVendible.AutoSize = True
        Me.RBtnNoVendible.Location = New System.Drawing.Point(0, 36)
        Me.RBtnNoVendible.Name = "RBtnNoVendible"
        Me.RBtnNoVendible.Size = New System.Drawing.Size(82, 17)
        Me.RBtnNoVendible.TabIndex = 2
        Me.RBtnNoVendible.TabStop = True
        Me.RBtnNoVendible.Text = "No vendible"
        Me.RBtnNoVendible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RBtnNoVendible.UseVisualStyleBackColor = True
        '
        'RBtnStockable
        '
        Me.RBtnStockable.AutoSize = True
        Me.RBtnStockable.Checked = True
        Me.RBtnStockable.Location = New System.Drawing.Point(1, 13)
        Me.RBtnStockable.Name = "RBtnStockable"
        Me.RBtnStockable.Size = New System.Drawing.Size(73, 17)
        Me.RBtnStockable.TabIndex = 0
        Me.RBtnStockable.TabStop = True
        Me.RBtnStockable.Text = "Stockable"
        Me.RBtnStockable.UseVisualStyleBackColor = True
        '
        'RBtnNoStockable
        '
        Me.RBtnNoStockable.AutoSize = True
        Me.RBtnNoStockable.Location = New System.Drawing.Point(1, 39)
        Me.RBtnNoStockable.Name = "RBtnNoStockable"
        Me.RBtnNoStockable.Size = New System.Drawing.Size(88, 17)
        Me.RBtnNoStockable.TabIndex = 1
        Me.RBtnNoStockable.TabStop = True
        Me.RBtnNoStockable.Text = "No stockable"
        Me.RBtnNoStockable.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.RBtnVendible)
        Me.GroupBox1.Controls.Add(Me.RBtnNoVendible)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(91, 65)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.RBtnStockable)
        Me.GroupBox2.Controls.Add(Me.RBtnNoStockable)
        Me.GroupBox2.Location = New System.Drawing.Point(109, 20)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(91, 65)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.TPV.My.Resources.Resources.arrow_back_circle_outline_1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 516)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox3.Controls.Add(Me.RBtnNombre)
        Me.GroupBox3.Controls.Add(Me.RBtnID)
        Me.GroupBox3.Location = New System.Drawing.Point(62, 91)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(91, 65)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        '
        'RBtnNombre
        '
        Me.RBtnNombre.AutoSize = True
        Me.RBtnNombre.Location = New System.Drawing.Point(0, 43)
        Me.RBtnNombre.Name = "RBtnNombre"
        Me.RBtnNombre.Size = New System.Drawing.Size(62, 17)
        Me.RBtnNombre.TabIndex = 1
        Me.RBtnNombre.Text = "Nombre"
        Me.RBtnNombre.UseVisualStyleBackColor = True
        '
        'RBtnID
        '
        Me.RBtnID.AutoSize = True
        Me.RBtnID.Checked = True
        Me.RBtnID.Location = New System.Drawing.Point(0, 19)
        Me.RBtnID.Name = "RBtnID"
        Me.RBtnID.Size = New System.Drawing.Size(36, 17)
        Me.RBtnID.TabIndex = 0
        Me.RBtnID.TabStop = True
        Me.RBtnID.Text = "ID"
        Me.RBtnID.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProductCode"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID Producto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idCategory"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idCategory"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Descripción"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Price"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "C2"
        DataGridViewCellStyle13.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn5.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Picture"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Picture"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Enabled"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Enabled"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Visible = False
        '
        'Stock
        '
        Me.Stock.DataPropertyName = "Stock"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N0"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.Stock.DefaultCellStyle = DataGridViewCellStyle14
        Me.Stock.HeaderText = "Stock"
        Me.Stock.Name = "Stock"
        Me.Stock.ReadOnly = True
        '
        'FiltroProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.TPV.My.MySettings.Default.ColorP
        Me.ClientSize = New System.Drawing.Size(651, 594)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ProductDataGridView)
        Me.Controls.Add(Me.BtnCancelarFiltro)
        Me.Controls.Add(Me.LblProductos)
        Me.Controls.Add(Me.BtnCategorias)
        Me.Controls.Add(Me.TBoxProductos)
        Me.Controls.Add(Me.LblCategorias)
        Me.Controls.Add(Me.BtnProductos)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.MinimumSize = New System.Drawing.Size(667, 633)
        Me.Name = "FiltroProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPV - Lista de productos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GestionesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnProductos As Button
    Friend WithEvents LblCategorias As Label
    Friend WithEvents TBoxProductos As TextBox
    Friend WithEvents BtnCategorias As Button
    Friend WithEvents LblProductos As Label
    Friend WithEvents BtnCancelarFiltro As Button
    Friend WithEvents GestionesDataSet As ConexionBD.DatosTPV
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductDataGridView As DataGridView
    Friend WithEvents RBtnVendible As RadioButton
    Friend WithEvents RBtnNoVendible As RadioButton
    Friend WithEvents RBtnStockable As RadioButton
    Friend WithEvents RBtnNoStockable As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RBtnNombre As RadioButton
    Friend WithEvents RBtnID As RadioButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents Stock As DataGridViewTextBoxColumn
End Class
