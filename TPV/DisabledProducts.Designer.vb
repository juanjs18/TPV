<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisabledProducts
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DatosTPV = New ConexionBD.DatosTPV()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvDisabledProductsList = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnDisabledProductsHabilitar = New System.Windows.Forms.Button()
        Me.pbxDisabledProductsBack = New System.Windows.Forms.PictureBox()
        CType(Me.DatosTPV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDisabledProductsList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxDisabledProductsBack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatosTPV
        '
        Me.DatosTPV.DataSetName = "DatosTPV"
        Me.DatosTPV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.DatosTPV
        Me.ProductBindingSource.Filter = "Enabled = 'False'"
        '
        'dgvDisabledProductsList
        '
        Me.dgvDisabledProductsList.AllowUserToAddRows = False
        Me.dgvDisabledProductsList.AllowUserToDeleteRows = False
        Me.dgvDisabledProductsList.AutoGenerateColumns = False
        Me.dgvDisabledProductsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDisabledProductsList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvDisabledProductsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDisabledProductsList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn7, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewCheckBoxColumn3})
        Me.dgvDisabledProductsList.DataSource = Me.ProductBindingSource
        Me.dgvDisabledProductsList.Location = New System.Drawing.Point(12, 12)
        Me.dgvDisabledProductsList.MultiSelect = False
        Me.dgvDisabledProductsList.Name = "dgvDisabledProductsList"
        Me.dgvDisabledProductsList.ReadOnly = True
        Me.dgvDisabledProductsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDisabledProductsList.Size = New System.Drawing.Size(776, 321)
        Me.dgvDisabledProductsList.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProductCode"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codigo Producto"
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
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre"
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
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle1
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
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Stock"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Stock"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Stockable"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Stockable"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.ReadOnly = True
        Me.DataGridViewCheckBoxColumn2.Visible = False
        '
        'DataGridViewCheckBoxColumn3
        '
        Me.DataGridViewCheckBoxColumn3.DataPropertyName = "Vendible"
        Me.DataGridViewCheckBoxColumn3.HeaderText = "Vendible"
        Me.DataGridViewCheckBoxColumn3.Name = "DataGridViewCheckBoxColumn3"
        Me.DataGridViewCheckBoxColumn3.ReadOnly = True
        Me.DataGridViewCheckBoxColumn3.Visible = False
        '
        'btnDisabledProductsHabilitar
        '
        Me.btnDisabledProductsHabilitar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDisabledProductsHabilitar.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.btnDisabledProductsHabilitar.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.btnDisabledProductsHabilitar.Location = New System.Drawing.Point(331, 353)
        Me.btnDisabledProductsHabilitar.Name = "btnDisabledProductsHabilitar"
        Me.btnDisabledProductsHabilitar.Size = New System.Drawing.Size(138, 66)
        Me.btnDisabledProductsHabilitar.TabIndex = 2
        Me.btnDisabledProductsHabilitar.Text = "Habilitar producto"
        Me.btnDisabledProductsHabilitar.UseVisualStyleBackColor = False
        '
        'pbxDisabledProductsBack
        '
        Me.pbxDisabledProductsBack.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.pbxDisabledProductsBack.BackgroundImage = Global.TPV.My.Resources.Resources.arrow_back_circle_outline_1
        Me.pbxDisabledProductsBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbxDisabledProductsBack.Location = New System.Drawing.Point(12, 353)
        Me.pbxDisabledProductsBack.Name = "pbxDisabledProductsBack"
        Me.pbxDisabledProductsBack.Size = New System.Drawing.Size(70, 70)
        Me.pbxDisabledProductsBack.TabIndex = 3
        Me.pbxDisabledProductsBack.TabStop = False
        '
        'DisabledProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.TPV.My.MySettings.Default.ColorP
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pbxDisabledProductsBack)
        Me.Controls.Add(Me.btnDisabledProductsHabilitar)
        Me.Controls.Add(Me.dgvDisabledProductsList)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.MaximumSize = New System.Drawing.Size(816, 489)
        Me.Name = "DisabledProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPV - Habilitar productos"
        CType(Me.DatosTPV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDisabledProductsList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxDisabledProductsBack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DatosTPV As ConexionBD.DatosTPV
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents dgvDisabledProductsList As DataGridView
    Friend WithEvents btnDisabledProductsHabilitar As Button
    Friend WithEvents pbxDisabledProductsBack As PictureBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn3 As DataGridViewCheckBoxColumn
End Class
