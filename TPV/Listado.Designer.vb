<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Listado
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DatosTPV_ProductDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosTPV_ProductDataTableDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DatosTPV_ProductDataTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatosTPV_CategoryRowBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DatosTPV_ProductDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosTPV_ProductDataTableDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosTPV_ProductDataTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosTPV_CategoryRowBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.Button1.Location = New System.Drawing.Point(329, 370)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 68)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Atras"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DatosTPV_ProductDataTableBindingSource
        '
        Me.DatosTPV_ProductDataTableBindingSource.DataSource = GetType(ConexionBD.DatosTPV.ProductDataTable)
        '
        'DatosTPV_ProductDataTableDataGridView1
        '
        Me.DatosTPV_ProductDataTableDataGridView1.AllowUserToAddRows = False
        Me.DatosTPV_ProductDataTableDataGridView1.AllowUserToDeleteRows = False
        Me.DatosTPV_ProductDataTableDataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatosTPV_ProductDataTableDataGridView1.AutoGenerateColumns = False
        Me.DatosTPV_ProductDataTableDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DatosTPV_ProductDataTableDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatosTPV_ProductDataTableDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn1})
        Me.DatosTPV_ProductDataTableDataGridView1.DataSource = Me.DatosTPV_ProductDataTableBindingSource
        Me.DatosTPV_ProductDataTableDataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DatosTPV_ProductDataTableDataGridView1.MultiSelect = False
        Me.DatosTPV_ProductDataTableDataGridView1.Name = "DatosTPV_ProductDataTableDataGridView1"
        Me.DatosTPV_ProductDataTableDataGridView1.ReadOnly = True
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DatosTPV_ProductDataTableDataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DatosTPV_ProductDataTableDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatosTPV_ProductDataTableDataGridView1.Size = New System.Drawing.Size(782, 342)
        Me.DatosTPV_ProductDataTableDataGridView1.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProductCode"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ProductCode"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idCategory"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idCategory"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Price"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Picture"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Picture"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Enabled"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Enabled"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'DatosTPV_ProductDataTableDataGridView
        '
        Me.DatosTPV_ProductDataTableDataGridView.AllowUserToAddRows = False
        Me.DatosTPV_ProductDataTableDataGridView.AllowUserToDeleteRows = False
        Me.DatosTPV_ProductDataTableDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DatosTPV_ProductDataTableDataGridView.AutoGenerateColumns = False
        Me.DatosTPV_ProductDataTableDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DatosTPV_ProductDataTableDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DatosTPV_ProductDataTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DatosTPV_ProductDataTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCategoryDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.PictureDataGridViewTextBoxColumn})
        Me.DatosTPV_ProductDataTableDataGridView.DataSource = Me.DatosTPV_CategoryRowBindingSource
        Me.DatosTPV_ProductDataTableDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.DatosTPV_ProductDataTableDataGridView.MultiSelect = False
        Me.DatosTPV_ProductDataTableDataGridView.Name = "DatosTPV_ProductDataTableDataGridView"
        Me.DatosTPV_ProductDataTableDataGridView.ReadOnly = True
        Me.DatosTPV_ProductDataTableDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DatosTPV_ProductDataTableDataGridView.Size = New System.Drawing.Size(782, 342)
        Me.DatosTPV_ProductDataTableDataGridView.TabIndex = 1
        '
        'IdCategoryDataGridViewTextBoxColumn
        '
        Me.IdCategoryDataGridViewTextBoxColumn.DataPropertyName = "idCategory"
        Me.IdCategoryDataGridViewTextBoxColumn.HeaderText = "idCategory"
        Me.IdCategoryDataGridViewTextBoxColumn.Name = "IdCategoryDataGridViewTextBoxColumn"
        Me.IdCategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PictureDataGridViewTextBoxColumn
        '
        Me.PictureDataGridViewTextBoxColumn.DataPropertyName = "Picture"
        Me.PictureDataGridViewTextBoxColumn.HeaderText = "Picture"
        Me.PictureDataGridViewTextBoxColumn.Name = "PictureDataGridViewTextBoxColumn"
        Me.PictureDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DatosTPV_CategoryRowBindingSource
        '
        Me.DatosTPV_CategoryRowBindingSource.DataSource = GetType(ConexionBD.DatosTPV.CategoryRow)
        '
        'Listado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.TPV.My.MySettings.Default.ColorP
        Me.ClientSize = New System.Drawing.Size(806, 448)
        Me.ControlBox = False
        Me.Controls.Add(Me.DatosTPV_ProductDataTableDataGridView)
        Me.Controls.Add(Me.DatosTPV_ProductDataTableDataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Listado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPV - Lista categorias"
        CType(Me.DatosTPV_ProductDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosTPV_ProductDataTableDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosTPV_ProductDataTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosTPV_CategoryRowBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents DatosTPV_ProductDataTableBindingSource As BindingSource
    Friend WithEvents DatosTPV_CategoryRowBindingSource As BindingSource
    Friend WithEvents DatosTPV_ProductDataTableDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents PictureDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatosTPV_ProductDataTableDataGridView As DataGridView
End Class
