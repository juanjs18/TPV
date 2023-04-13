<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturar
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim NifLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LblBuscarUsuario = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnFiltrar = New System.Windows.Forms.Button()
        Me.FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.FechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.UsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GestionesDataSet = New ConexionBD.DatosTPV()
        Me.NifTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnBuscarEmpresa = New System.Windows.Forms.Button()
        Me.DataTable2DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataTable2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnFiltrado = New System.Windows.Forms.Button()
        Me.BtnTodo = New System.Windows.Forms.Button()
        Me.BtnQuitarFiltro = New System.Windows.Forms.Button()
        Me.FacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LineaFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnFacturados = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        NameLabel = New System.Windows.Forms.Label()
        NifLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GestionesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LineaFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(9, 77)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(103, 25)
        NameLabel.TabIndex = 10
        NameLabel.Text = "Empresa:"
        '
        'NifLabel
        '
        NifLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        NifLabel.AutoSize = True
        NifLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NifLabel.Location = New System.Drawing.Point(9, 115)
        NifLabel.Name = "NifLabel"
        NifLabel.Size = New System.Drawing.Size(51, 25)
        NifLabel.TabIndex = 16
        NifLabel.Text = "NIF:"
        '
        'Label4
        '
        Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.Location = New System.Drawing.Point(413, 77)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(68, 25)
        Label4.TabIndex = 20
        Label4.Text = "Inicio:"
        '
        'Label5
        '
        Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.Location = New System.Drawing.Point(413, 115)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(48, 25)
        Label5.TabIndex = 21
        Label5.Text = "Fin:"
        '
        'LblBuscarUsuario
        '
        Me.LblBuscarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblBuscarUsuario.AutoSize = True
        Me.LblBuscarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarUsuario.Location = New System.Drawing.Point(7, 27)
        Me.LblBuscarUsuario.Name = "LblBuscarUsuario"
        Me.LblBuscarUsuario.Size = New System.Drawing.Size(205, 25)
        Me.LblBuscarUsuario.TabIndex = 2
        Me.LblBuscarUsuario.Text = "Buscar por empresa"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(413, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Buscar entre fechas"
        '
        'BtnFiltrar
        '
        Me.BtnFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnFiltrar.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.BtnFiltrar.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.BtnFiltrar.Location = New System.Drawing.Point(235, 189)
        Me.BtnFiltrar.Name = "BtnFiltrar"
        Me.BtnFiltrar.Size = New System.Drawing.Size(105, 42)
        Me.BtnFiltrar.TabIndex = 4
        Me.BtnFiltrar.Text = "Buscar"
        Me.BtnFiltrar.UseVisualStyleBackColor = False
        '
        'FechaInicio
        '
        Me.FechaInicio.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.FechaInicio.Location = New System.Drawing.Point(487, 80)
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.Size = New System.Drawing.Size(200, 20)
        Me.FechaInicio.TabIndex = 7
        '
        'FechaFinal
        '
        Me.FechaFinal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.FechaFinal.Location = New System.Drawing.Point(487, 118)
        Me.FechaFinal.Name = "FechaFinal"
        Me.FechaFinal.Size = New System.Drawing.Size(200, 20)
        Me.FechaFinal.TabIndex = 8
        '
        'NameTextBox
        '
        Me.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "name", True))
        Me.NameTextBox.Enabled = False
        Me.NameTextBox.Location = New System.Drawing.Point(118, 83)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 11
        '
        'UsersBindingSource
        '
        Me.UsersBindingSource.DataMember = "Users"
        Me.UsersBindingSource.DataSource = Me.GestionesDataSet
        '
        'GestionesDataSet
        '
        Me.GestionesDataSet.DataSetName = "GestionesDataSet"
        Me.GestionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NifTextBox
        '
        Me.NifTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.NifTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NifTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UsersBindingSource, "nif", True))
        Me.NifTextBox.Enabled = False
        Me.NifTextBox.Location = New System.Drawing.Point(118, 121)
        Me.NifTextBox.Name = "NifTextBox"
        Me.NifTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NifTextBox.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 25)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "________________"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(413, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 25)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "________________"
        '
        'BtnBuscarEmpresa
        '
        Me.BtnBuscarEmpresa.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnBuscarEmpresa.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.BtnBuscarEmpresa.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.BtnBuscarEmpresa.Location = New System.Drawing.Point(224, 84)
        Me.BtnBuscarEmpresa.Name = "BtnBuscarEmpresa"
        Me.BtnBuscarEmpresa.Size = New System.Drawing.Size(25, 20)
        Me.BtnBuscarEmpresa.TabIndex = 22
        Me.BtnBuscarEmpresa.Text = "..."
        Me.BtnBuscarEmpresa.UseVisualStyleBackColor = False
        '
        'DataTable2DataGridView
        '
        Me.DataTable2DataGridView.AllowUserToAddRows = False
        Me.DataTable2DataGridView.AllowUserToDeleteRows = False
        Me.DataTable2DataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataTable2DataGridView.AutoGenerateColumns = False
        Me.DataTable2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataTable2DataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataTable2DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataTable2DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn8})
        Me.DataTable2DataGridView.DataSource = Me.DataTable2BindingSource
        Me.DataTable2DataGridView.Location = New System.Drawing.Point(19, 251)
        Me.DataTable2DataGridView.Name = "DataTable2DataGridView"
        Me.DataTable2DataGridView.ReadOnly = True
        Me.DataTable2DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataTable2DataGridView.Size = New System.Drawing.Size(668, 351)
        Me.DataTable2DataGridView.TabIndex = 22
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "idAlbaran"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID Albaran"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "facturada"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "facturada"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "descriptionsProduct"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
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
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "date"
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "amount"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn2.HeaderText = "Total Albaran"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "idUser"
        Me.DataGridViewTextBoxColumn8.HeaderText = "idUser"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataTable2BindingSource
        '
        Me.DataTable2BindingSource.DataMember = "DataTable2"
        Me.DataTable2BindingSource.DataSource = Me.GestionesDataSet
        '
        'BtnFiltrado
        '
        Me.BtnFiltrado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFiltrado.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.BtnFiltrado.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.BtnFiltrado.Location = New System.Drawing.Point(421, 624)
        Me.BtnFiltrado.Name = "BtnFiltrado"
        Me.BtnFiltrado.Size = New System.Drawing.Size(113, 54)
        Me.BtnFiltrado.TabIndex = 23
        Me.BtnFiltrado.Text = "Facturar filtrado"
        Me.BtnFiltrado.UseVisualStyleBackColor = False
        '
        'BtnTodo
        '
        Me.BtnTodo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnTodo.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.BtnTodo.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.BtnTodo.Location = New System.Drawing.Point(574, 624)
        Me.BtnTodo.Name = "BtnTodo"
        Me.BtnTodo.Size = New System.Drawing.Size(113, 54)
        Me.BtnTodo.TabIndex = 24
        Me.BtnTodo.Text = "Facturar todo"
        Me.BtnTodo.UseVisualStyleBackColor = False
        '
        'BtnQuitarFiltro
        '
        Me.BtnQuitarFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnQuitarFiltro.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.BtnQuitarFiltro.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.BtnQuitarFiltro.Location = New System.Drawing.Point(359, 189)
        Me.BtnQuitarFiltro.Name = "BtnQuitarFiltro"
        Me.BtnQuitarFiltro.Size = New System.Drawing.Size(105, 42)
        Me.BtnQuitarFiltro.TabIndex = 25
        Me.BtnQuitarFiltro.Text = "Quitar filtro"
        Me.BtnQuitarFiltro.UseVisualStyleBackColor = False
        '
        'FacturasBindingSource
        '
        Me.FacturasBindingSource.DataMember = "Facturas"
        Me.FacturasBindingSource.DataSource = Me.GestionesDataSet
        '
        'LineaFacturaBindingSource
        '
        Me.LineaFacturaBindingSource.DataMember = "LineaFactura"
        Me.LineaFacturaBindingSource.DataSource = Me.GestionesDataSet
        '
        'BtnFacturados
        '
        Me.BtnFacturados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnFacturados.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.BtnFacturados.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.BtnFacturados.Location = New System.Drawing.Point(268, 624)
        Me.BtnFacturados.Name = "BtnFacturados"
        Me.BtnFacturados.Size = New System.Drawing.Size(113, 54)
        Me.BtnFacturados.TabIndex = 27
        Me.BtnFacturados.Text = "Lista facturas"
        Me.BtnFacturados.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.TPV.My.Resources.Resources.arrow_back_circle_outline_1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(19, 608)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'Facturar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.TPV.My.MySettings.Default.ColorP
        Me.ClientSize = New System.Drawing.Size(699, 690)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnFacturados)
        Me.Controls.Add(Me.BtnQuitarFiltro)
        Me.Controls.Add(Me.BtnTodo)
        Me.Controls.Add(Me.BtnFiltrado)
        Me.Controls.Add(Me.DataTable2DataGridView)
        Me.Controls.Add(Me.BtnBuscarEmpresa)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblBuscarUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(NifLabel)
        Me.Controls.Add(Me.NifTextBox)
        Me.Controls.Add(Me.FechaFinal)
        Me.Controls.Add(Me.FechaInicio)
        Me.Controls.Add(Me.BtnFiltrar)
        Me.Controls.Add(Me.Label3)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.MinimumSize = New System.Drawing.Size(701, 692)
        Me.Name = "Facturar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPV - Facturar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.UsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GestionesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LineaFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataTable2BindingSource As BindingSource
    Friend WithEvents LblBuscarUsuario As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnFiltrar As Button
    Friend WithEvents FechaInicio As DateTimePicker
    Friend WithEvents FechaFinal As DateTimePicker
    Friend WithEvents UsersBindingSource As BindingSource
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents NifTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnBuscarEmpresa As Button
    Friend WithEvents DataTable2DataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents BtnFiltrado As Button
    Friend WithEvents BtnTodo As Button
    Friend WithEvents BtnQuitarFiltro As Button
    Friend WithEvents FacturasBindingSource As BindingSource
    Friend WithEvents LineaFacturaBindingSource As BindingSource
    Friend WithEvents BtnFacturados As Button
    Friend WithEvents PictureBox1 As PictureBox
    Public Shared GestionesDataSet As ConexionBD.DatosTPV
End Class
