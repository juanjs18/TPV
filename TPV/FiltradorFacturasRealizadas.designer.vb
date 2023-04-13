<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FiltradorFacturasRealizadas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GestionesDataSet = New ConexionBD.DatosTPV()
        Me.FacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblFiltrar = New System.Windows.Forms.Label()
        Me.TBoxFiltrar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RBtnFactura = New System.Windows.Forms.RadioButton()
        Me.RBtnFecha = New System.Windows.Forms.RadioButton()
        Me.RBtnNif = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnQuitarFiltro = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.GestionesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'FacturasDataGridView
        '
        Me.FacturasDataGridView.AllowUserToAddRows = False
        Me.FacturasDataGridView.AllowUserToDeleteRows = False
        Me.FacturasDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FacturasDataGridView.AutoGenerateColumns = False
        Me.FacturasDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.FacturasDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FacturasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FacturasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn7})
        Me.FacturasDataGridView.DataSource = Me.FacturasBindingSource
        Me.FacturasDataGridView.Location = New System.Drawing.Point(12, 118)
        Me.FacturasDataGridView.Name = "FacturasDataGridView"
        Me.FacturasDataGridView.ReadOnly = True
        Me.FacturasDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.FacturasDataGridView.Size = New System.Drawing.Size(662, 286)
        Me.FacturasDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idFactura"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "Factura"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fecha"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "empresa"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Empresa"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "domicilio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Domicilio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "nif"
        Me.DataGridViewTextBoxColumn6.HeaderText = "NIF"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "total"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "idPostalCode"
        Me.DataGridViewTextBoxColumn7.HeaderText = "idPostalCode"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'LblFiltrar
        '
        Me.LblFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblFiltrar.AutoSize = True
        Me.LblFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFiltrar.Location = New System.Drawing.Point(295, 9)
        Me.LblFiltrar.Name = "LblFiltrar"
        Me.LblFiltrar.Size = New System.Drawing.Size(93, 25)
        Me.LblFiltrar.TabIndex = 2
        Me.LblFiltrar.Text = "Cadena:"
        '
        'TBoxFiltrar
        '
        Me.TBoxFiltrar.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TBoxFiltrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TBoxFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBoxFiltrar.Location = New System.Drawing.Point(394, 8)
        Me.TBoxFiltrar.Name = "TBoxFiltrar"
        Me.TBoxFiltrar.Size = New System.Drawing.Size(200, 26)
        Me.TBoxFiltrar.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Filtrar por:"
        '
        'RBtnFactura
        '
        Me.RBtnFactura.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RBtnFactura.AutoSize = True
        Me.RBtnFactura.Checked = True
        Me.RBtnFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnFactura.Location = New System.Drawing.Point(128, 10)
        Me.RBtnFactura.Name = "RBtnFactura"
        Me.RBtnFactura.Size = New System.Drawing.Size(136, 24)
        Me.RBtnFactura.TabIndex = 7
        Me.RBtnFactura.TabStop = True
        Me.RBtnFactura.Text = "Codigo Factura"
        Me.RBtnFactura.UseVisualStyleBackColor = True
        '
        'RBtnFecha
        '
        Me.RBtnFecha.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RBtnFecha.AutoSize = True
        Me.RBtnFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnFecha.Location = New System.Drawing.Point(128, 40)
        Me.RBtnFecha.Name = "RBtnFecha"
        Me.RBtnFecha.Size = New System.Drawing.Size(72, 24)
        Me.RBtnFecha.TabIndex = 8
        Me.RBtnFecha.TabStop = True
        Me.RBtnFecha.Text = "Fecha"
        Me.RBtnFecha.UseVisualStyleBackColor = True
        '
        'RBtnNif
        '
        Me.RBtnNif.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.RBtnNif.AutoSize = True
        Me.RBtnNif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBtnNif.Location = New System.Drawing.Point(128, 70)
        Me.RBtnNif.Name = "RBtnNif"
        Me.RBtnNif.Size = New System.Drawing.Size(53, 24)
        Me.RBtnNif.TabIndex = 9
        Me.RBtnNif.TabStop = True
        Me.RBtnNif.Text = "NIF"
        Me.RBtnNif.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(295, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Fecha:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(394, 53)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 11
        '
        'BtnQuitarFiltro
        '
        Me.BtnQuitarFiltro.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BtnQuitarFiltro.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.BtnQuitarFiltro.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.BtnQuitarFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuitarFiltro.Location = New System.Drawing.Point(12, 47)
        Me.BtnQuitarFiltro.Name = "BtnQuitarFiltro"
        Me.BtnQuitarFiltro.Size = New System.Drawing.Size(110, 34)
        Me.BtnQuitarFiltro.TabIndex = 12
        Me.BtnQuitarFiltro.Text = "Quitar Filtro"
        Me.BtnQuitarFiltro.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.TPV.My.Resources.Resources.arrow_back_circle_outline_1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 410)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'FiltradorFacturasRealizadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.TPV.My.MySettings.Default.ColorP
        Me.ClientSize = New System.Drawing.Size(696, 489)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnQuitarFiltro)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RBtnNif)
        Me.Controls.Add(Me.RBtnFecha)
        Me.Controls.Add(Me.RBtnFactura)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBoxFiltrar)
        Me.Controls.Add(Me.LblFiltrar)
        Me.Controls.Add(Me.FacturasDataGridView)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Name = "FiltradorFacturasRealizadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPV - Listado Facturas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GestionesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GestionesDataSet As ConexionBD.DatosTPV
    Friend WithEvents FacturasBindingSource As BindingSource
    Friend WithEvents FacturasDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents LblFiltrar As Label
    Friend WithEvents TBoxFiltrar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RBtnFactura As RadioButton
    Friend WithEvents RBtnFecha As RadioButton
    Friend WithEvents RBtnNif As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BtnQuitarFiltro As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
