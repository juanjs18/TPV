<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Albaranes
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
        Me.GestionesDataSet = New ConexionBD.DatosTPV()
        Me.AlbaranBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlbaranDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RBtnAlbaran = New System.Windows.Forms.RadioButton()
        Me.RBtnUsuario = New System.Windows.Forms.RadioButton()
        Me.TBoxFiltrar = New System.Windows.Forms.TextBox()
        CType(Me.GestionesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlbaranBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlbaranDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GestionesDataSet
        '
        Me.GestionesDataSet.DataSetName = "GestionesDataSet"
        Me.GestionesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlbaranBindingSource
        '
        Me.AlbaranBindingSource.DataMember = "Albaran"
        Me.AlbaranBindingSource.DataSource = Me.GestionesDataSet
        '
        'AlbaranDataGridView
        '
        Me.AlbaranDataGridView.AllowUserToAddRows = False
        Me.AlbaranDataGridView.AllowUserToDeleteRows = False
        Me.AlbaranDataGridView.AutoGenerateColumns = False
        Me.AlbaranDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AlbaranDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AlbaranDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.AlbaranDataGridView.DataSource = Me.AlbaranBindingSource
        Me.AlbaranDataGridView.Location = New System.Drawing.Point(12, 87)
        Me.AlbaranDataGridView.Name = "AlbaranDataGridView"
        Me.AlbaranDataGridView.ReadOnly = True
        Me.AlbaranDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AlbaranDataGridView.Size = New System.Drawing.Size(507, 351)
        Me.AlbaranDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idAlbaran"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdAlbaran"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idUser"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IdUsuario"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "amount"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.TPV.My.Resources.Resources.arrow_back_circle_outline_1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 444)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Filtrar:"
        '
        'RBtnAlbaran
        '
        Me.RBtnAlbaran.AutoSize = True
        Me.RBtnAlbaran.Checked = True
        Me.RBtnAlbaran.Location = New System.Drawing.Point(17, 37)
        Me.RBtnAlbaran.Name = "RBtnAlbaran"
        Me.RBtnAlbaran.Size = New System.Drawing.Size(75, 17)
        Me.RBtnAlbaran.TabIndex = 2
        Me.RBtnAlbaran.TabStop = True
        Me.RBtnAlbaran.Text = "ID Albaran"
        Me.RBtnAlbaran.UseVisualStyleBackColor = True
        '
        'RBtnUsuario
        '
        Me.RBtnUsuario.AutoSize = True
        Me.RBtnUsuario.Location = New System.Drawing.Point(17, 61)
        Me.RBtnUsuario.Name = "RBtnUsuario"
        Me.RBtnUsuario.Size = New System.Drawing.Size(75, 17)
        Me.RBtnUsuario.TabIndex = 3
        Me.RBtnUsuario.Text = "ID Usuario"
        Me.RBtnUsuario.UseVisualStyleBackColor = True
        '
        'TBoxFiltrar
        '
        Me.TBoxFiltrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TBoxFiltrar.Location = New System.Drawing.Point(113, 47)
        Me.TBoxFiltrar.Name = "TBoxFiltrar"
        Me.TBoxFiltrar.Size = New System.Drawing.Size(100, 20)
        Me.TBoxFiltrar.TabIndex = 0
        '
        'Albaranes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.TPV.My.MySettings.Default.ColorP
        Me.ClientSize = New System.Drawing.Size(534, 524)
        Me.ControlBox = False
        Me.Controls.Add(Me.TBoxFiltrar)
        Me.Controls.Add(Me.RBtnUsuario)
        Me.Controls.Add(Me.RBtnAlbaran)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AlbaranDataGridView)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Albaranes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPV - Albaranes"
        CType(Me.GestionesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlbaranBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlbaranDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GestionesDataSet As ConexionBD.DatosTPV
    Friend WithEvents AlbaranBindingSource As BindingSource
    Friend WithEvents AlbaranDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RBtnAlbaran As RadioButton
    Friend WithEvents RBtnUsuario As RadioButton
    Friend WithEvents TBoxFiltrar As TextBox
End Class
