<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DirectionList
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DatosTPV = New ConexionBD.DatosTPV()
        Me.CiudadesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CiudadesDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdCountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CountriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CiudadesDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nameCity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DatosTPV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CiudadesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CiudadesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CountriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CiudadesDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(118, 37)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 20)
        Me.TextBox1.TabIndex = 3
        '
        'DatosTPV
        '
        Me.DatosTPV.DataSetName = "DatosTPV"
        Me.DatosTPV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CiudadesBindingSource
        '
        Me.CiudadesBindingSource.DataMember = "Ciudades"
        Me.CiudadesBindingSource.DataSource = Me.DatosTPV
        '
        'CiudadesDataGridView
        '
        Me.CiudadesDataGridView.AllowUserToAddRows = False
        Me.CiudadesDataGridView.AllowUserToDeleteRows = False
        Me.CiudadesDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CiudadesDataGridView.AutoGenerateColumns = False
        Me.CiudadesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CiudadesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CiudadesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdCountryDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn})
        Me.CiudadesDataGridView.DataSource = Me.CountriesBindingSource
        Me.CiudadesDataGridView.Location = New System.Drawing.Point(43, 81)
        Me.CiudadesDataGridView.MultiSelect = False
        Me.CiudadesDataGridView.Name = "CiudadesDataGridView"
        Me.CiudadesDataGridView.ReadOnly = True
        Me.CiudadesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CiudadesDataGridView.Size = New System.Drawing.Size(502, 306)
        Me.CiudadesDataGridView.TabIndex = 4
        '
        'IdCountryDataGridViewTextBoxColumn
        '
        Me.IdCountryDataGridViewTextBoxColumn.DataPropertyName = "idCountry"
        Me.IdCountryDataGridViewTextBoxColumn.HeaderText = "idCountry"
        Me.IdCountryDataGridViewTextBoxColumn.Name = "IdCountryDataGridViewTextBoxColumn"
        Me.IdCountryDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdCountryDataGridViewTextBoxColumn.Visible = False
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CountriesBindingSource
        '
        Me.CountriesBindingSource.DataMember = "Countries"
        Me.CountriesBindingSource.DataSource = Me.DatosTPV
        '
        'CiudadesDataGridView1
        '
        Me.CiudadesDataGridView1.AllowUserToAddRows = False
        Me.CiudadesDataGridView1.AllowUserToDeleteRows = False
        Me.CiudadesDataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CiudadesDataGridView1.AutoGenerateColumns = False
        Me.CiudadesDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CiudadesDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CiudadesDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CiudadesDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.nameCity, Me.DataGridViewTextBoxColumn11})
        Me.CiudadesDataGridView1.DataSource = Me.CiudadesBindingSource
        Me.CiudadesDataGridView1.Location = New System.Drawing.Point(43, 81)
        Me.CiudadesDataGridView1.MultiSelect = False
        Me.CiudadesDataGridView1.Name = "CiudadesDataGridView1"
        Me.CiudadesDataGridView1.ReadOnly = True
        Me.CiudadesDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CiudadesDataGridView1.Size = New System.Drawing.Size(502, 306)
        Me.CiudadesDataGridView1.TabIndex = 4
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "idPC"
        Me.DataGridViewTextBoxColumn8.HeaderText = "idPC"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "idCity"
        Me.DataGridViewTextBoxColumn9.HeaderText = "idCity"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'nameCity
        '
        Me.nameCity.DataPropertyName = "nameCity"
        Me.nameCity.HeaderText = "nameCity"
        Me.nameCity.Name = "nameCity"
        Me.nameCity.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "postalCode"
        Me.DataGridViewTextBoxColumn11.HeaderText = "postalCode"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'Button2
        '
        Me.Button2.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.Button2.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button2.Location = New System.Drawing.Point(292, 37)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 20)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.TPV.My.Resources.Resources.arrow_back_circle_outline_1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(43, 407)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'DirectionList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.TPV.My.MySettings.Default.ColorP
        Me.ClientSize = New System.Drawing.Size(594, 489)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CiudadesDataGridView1)
        Me.Controls.Add(Me.CiudadesDataGridView)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(610, 528)
        Me.Name = "DirectionList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPV - Ciudades"
        CType(Me.DatosTPV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CiudadesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CiudadesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CountriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CiudadesDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DatosTPV As ConexionBD.DatosTPV
    Friend WithEvents CiudadesBindingSource As BindingSource
    Friend WithEvents CiudadesDataGridView As DataGridView
    Friend WithEvents CountriesBindingSource As BindingSource
    Friend WithEvents CiudadesDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents nameCity As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents IdCountryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
