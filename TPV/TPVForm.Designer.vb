<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TPVForm
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Products = New System.Windows.Forms.FlowLayoutPanel()
        Me.Categories = New System.Windows.Forms.FlowLayoutPanel()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdTicketDetailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TicketCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameProductDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndvPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TicketDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TicketBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosTPV = New ConexionBD.DatosTPV()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NameLabel1 = New System.Windows.Forms.Label()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.totalView = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.rbtTPVEfectivo = New System.Windows.Forms.RadioButton()
        Me.rbnTPVTarjeta = New System.Windows.Forms.RadioButton()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        NameLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosTPV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(212, 43)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(62, 20)
        NameLabel.TabIndex = 11
        NameLabel.Text = "Cliente:"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.Button1.Location = New System.Drawing.Point(951, 430)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 83)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cobrar Venta"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.Button2.Location = New System.Drawing.Point(735, 430)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 83)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Borrar Venta"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Products, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Categories, 0, 0)
        Me.TableLayoutPanel1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(556, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 170.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(548, 406)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Products
        '
        Me.Products.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Products.Location = New System.Drawing.Point(3, 173)
        Me.Products.Name = "Products"
        Me.Products.Size = New System.Drawing.Size(542, 230)
        Me.Products.TabIndex = 1
        '
        'Categories
        '
        Me.Categories.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Categories.AutoScroll = True
        Me.Categories.Location = New System.Drawing.Point(3, 3)
        Me.Categories.Name = "Categories"
        Me.Categories.Size = New System.Drawing.Size(542, 164)
        Me.Categories.TabIndex = 0
        Me.Categories.WrapContents = False
        '
        'PrintDocument1
        '
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1107, 412)
        Me.TableLayoutPanel2.TabIndex = 9
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.AutoScroll = True
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.DataGridView1, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 104.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(547, 406)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTicketDetailDataGridViewTextBoxColumn, Me.TicketCodeDataGridViewTextBoxColumn, Me.ProductCodeDataGridViewTextBoxColumn, Me.NameProductDataGridViewTextBoxColumn, Me.IndvPriceDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.TotalPriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TicketDetailBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 107)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(541, 296)
        Me.DataGridView1.TabIndex = 1
        '
        'IdTicketDetailDataGridViewTextBoxColumn
        '
        Me.IdTicketDetailDataGridViewTextBoxColumn.DataPropertyName = "idTicketDetail"
        Me.IdTicketDetailDataGridViewTextBoxColumn.HeaderText = "idTicketDetail"
        Me.IdTicketDetailDataGridViewTextBoxColumn.Name = "IdTicketDetailDataGridViewTextBoxColumn"
        Me.IdTicketDetailDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdTicketDetailDataGridViewTextBoxColumn.Visible = False
        '
        'TicketCodeDataGridViewTextBoxColumn
        '
        Me.TicketCodeDataGridViewTextBoxColumn.DataPropertyName = "TicketCode"
        Me.TicketCodeDataGridViewTextBoxColumn.HeaderText = "TicketCode"
        Me.TicketCodeDataGridViewTextBoxColumn.Name = "TicketCodeDataGridViewTextBoxColumn"
        Me.TicketCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TicketCodeDataGridViewTextBoxColumn.Visible = False
        '
        'ProductCodeDataGridViewTextBoxColumn
        '
        Me.ProductCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode"
        Me.ProductCodeDataGridViewTextBoxColumn.HeaderText = "ProductCode"
        Me.ProductCodeDataGridViewTextBoxColumn.Name = "ProductCodeDataGridViewTextBoxColumn"
        Me.ProductCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductCodeDataGridViewTextBoxColumn.Visible = False
        '
        'NameProductDataGridViewTextBoxColumn
        '
        Me.NameProductDataGridViewTextBoxColumn.DataPropertyName = "NameProduct"
        Me.NameProductDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NameProductDataGridViewTextBoxColumn.Name = "NameProductDataGridViewTextBoxColumn"
        Me.NameProductDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IndvPriceDataGridViewTextBoxColumn
        '
        Me.IndvPriceDataGridViewTextBoxColumn.DataPropertyName = "IndvPrice"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.IndvPriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.IndvPriceDataGridViewTextBoxColumn.HeaderText = "Precio Inv"
        Me.IndvPriceDataGridViewTextBoxColumn.Name = "IndvPriceDataGridViewTextBoxColumn"
        Me.IndvPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalPriceDataGridViewTextBoxColumn
        '
        Me.TotalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.TotalPriceDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TotalPriceDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalPriceDataGridViewTextBoxColumn.Name = "TotalPriceDataGridViewTextBoxColumn"
        Me.TotalPriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TicketDetailBindingSource
        '
        Me.TicketDetailBindingSource.AllowNew = True
        Me.TicketDetailBindingSource.DataMember = "FK_TicketDetail_Ticket"
        Me.TicketDetailBindingSource.DataSource = Me.TicketBindingSource
        '
        'TicketBindingSource
        '
        Me.TicketBindingSource.DataMember = "Ticket"
        Me.TicketBindingSource.DataSource = Me.DatosTPV
        '
        'DatosTPV
        '
        Me.DatosTPV.DataSetName = "DatosTPV"
        Me.DatosTPV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(NameLabel)
        Me.Panel1.Controls.Add(Me.NameLabel1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(541, 98)
        Me.Panel1.TabIndex = 1
        '
        'NameLabel1
        '
        Me.NameLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "name", True))
        Me.NameLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel1.Location = New System.Drawing.Point(280, 43)
        Me.NameLabel1.Name = "NameLabel1"
        Me.NameLabel1.Size = New System.Drawing.Size(238, 20)
        Me.NameLabel1.TabIndex = 12
        Me.NameLabel1.Text = "Label3"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Ticket_Clientes"
        Me.ClientesBindingSource.DataSource = Me.TicketBindingSource
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketBindingSource, "Date", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "D"))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Label1"
        '
        'totalView
        '
        Me.totalView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.totalView.AutoSize = True
        Me.totalView.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketBindingSource, "TotalCost", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.totalView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalView.Location = New System.Drawing.Point(134, 493)
        Me.totalView.Name = "totalView"
        Me.totalView.Size = New System.Drawing.Size(57, 20)
        Me.totalView.TabIndex = 10
        Me.totalView.Text = "Label1"
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.Button4.Location = New System.Drawing.Point(843, 430)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(90, 83)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Imprimir Ticket"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.Button5.Location = New System.Drawing.Point(628, 430)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(90, 83)
        Me.Button5.TabIndex = 3
        Me.Button5.Text = "Mostrar Tickets Parados"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'rbtTPVEfectivo
        '
        Me.rbtTPVEfectivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtTPVEfectivo.AutoSize = True
        Me.rbtTPVEfectivo.Checked = True
        Me.rbtTPVEfectivo.Location = New System.Drawing.Point(1055, 446)
        Me.rbtTPVEfectivo.Name = "rbtTPVEfectivo"
        Me.rbtTPVEfectivo.Size = New System.Drawing.Size(64, 17)
        Me.rbtTPVEfectivo.TabIndex = 7
        Me.rbtTPVEfectivo.TabStop = True
        Me.rbtTPVEfectivo.Text = "Efectivo"
        Me.rbtTPVEfectivo.UseVisualStyleBackColor = True
        '
        'rbnTPVTarjeta
        '
        Me.rbnTPVTarjeta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbnTPVTarjeta.AutoSize = True
        Me.rbnTPVTarjeta.Location = New System.Drawing.Point(1055, 475)
        Me.rbnTPVTarjeta.Name = "rbnTPVTarjeta"
        Me.rbnTPVTarjeta.Size = New System.Drawing.Size(58, 17)
        Me.rbnTPVTarjeta.TabIndex = 8
        Me.rbnTPVTarjeta.Text = "Tarjeta"
        Me.rbnTPVTarjeta.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.Button6.Location = New System.Drawing.Point(518, 430)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(90, 83)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Asignar Cliente"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button7.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.Button7.Location = New System.Drawing.Point(412, 430)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(90, 83)
        Me.Button7.TabIndex = 1
        Me.Button7.Text = "Cerrar Caja"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button8.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.Button8.Location = New System.Drawing.Point(306, 430)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(90, 83)
        Me.Button8.TabIndex = 0
        Me.Button8.Text = "Nuevo Ticket"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 446)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Total:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.TPV.My.Resources.Resources.arrow_back_circle_outline_1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 446)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'TPVForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.TPV.My.MySettings.Default.ColorP
        Me.ClientSize = New System.Drawing.Size(1131, 525)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.rbnTPVTarjeta)
        Me.Controls.Add(Me.rbtTPVEfectivo)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.totalView)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.MinimumSize = New System.Drawing.Size(1139, 556)
        Me.Name = "TPVForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPV"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosTPV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Categories As FlowLayoutPanel
    Friend WithEvents Products As FlowLayoutPanel
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents DatosTPV As ConexionBD.DatosTPV
    Friend WithEvents TicketBindingSource As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents totalView As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents rbtTPVEfectivo As RadioButton
    Friend WithEvents rbnTPVTarjeta As RadioButton
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents NameLabel1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TicketDetailBindingSource As BindingSource
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents IdTicketDetailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TicketCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductCodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameProductDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndvPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
