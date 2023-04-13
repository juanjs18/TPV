<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListaRegularizaciones
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
        Me.DatosTPV = New ConexionBD.DatosTPV()
        Me.RegularizacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RegularizacionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DatosTPV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegularizacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegularizacionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DatosTPV
        '
        Me.DatosTPV.DataSetName = "DatosTPV"
        Me.DatosTPV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RegularizacionBindingSource
        '
        Me.RegularizacionBindingSource.DataMember = "Regularizacion"
        Me.RegularizacionBindingSource.DataSource = Me.DatosTPV
        Me.RegularizacionBindingSource.Filter = "Manual = 'True'"
        '
        'RegularizacionDataGridView
        '
        Me.RegularizacionDataGridView.AllowUserToAddRows = False
        Me.RegularizacionDataGridView.AllowUserToDeleteRows = False
        Me.RegularizacionDataGridView.AutoGenerateColumns = False
        Me.RegularizacionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RegularizacionDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RegularizacionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RegularizacionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.RegularizacionDataGridView.DataSource = Me.RegularizacionBindingSource
        Me.RegularizacionDataGridView.Location = New System.Drawing.Point(12, 12)
        Me.RegularizacionDataGridView.MultiSelect = False
        Me.RegularizacionDataGridView.Name = "RegularizacionDataGridView"
        Me.RegularizacionDataGridView.ReadOnly = True
        Me.RegularizacionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RegularizacionDataGridView.Size = New System.Drawing.Size(771, 312)
        Me.RegularizacionDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDRegularizacion"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDRegularizacion"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Motivo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Motivo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ProductCode"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Cantidad"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Inventario"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Inventario"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.TPV.My.Resources.Resources.arrow_back_circle_outline_1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 373)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'ListaRegularizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.TPV.My.MySettings.Default.ColorP
        Me.ClientSize = New System.Drawing.Size(795, 455)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RegularizacionDataGridView)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Name = "ListaRegularizaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPV - Lista de regularizaciones"
        CType(Me.DatosTPV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegularizacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegularizacionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DatosTPV As ConexionBD.DatosTPV
    Friend WithEvents RegularizacionBindingSource As BindingSource
    Friend WithEvents RegularizacionDataGridView As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
