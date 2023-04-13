<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DetalleTicket
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
        Dim TicketCodeLabel As System.Windows.Forms.Label
        Dim DateLabel As System.Windows.Forms.Label
        Dim TotalCostLabel As System.Windows.Forms.Label
        Dim TotalIVALabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DatosTPV = New ConexionBD.DatosTPV()
        Me.TicketDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TicketDetailDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TicketBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TicketCodeTextBox = New System.Windows.Forms.TextBox()
        Me.DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TotalCostTextBox = New System.Windows.Forms.TextBox()
        Me.TotalIVATextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        TicketCodeLabel = New System.Windows.Forms.Label()
        DateLabel = New System.Windows.Forms.Label()
        TotalCostLabel = New System.Windows.Forms.Label()
        TotalIVALabel = New System.Windows.Forms.Label()
        CType(Me.DatosTPV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketDetailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TicketCodeLabel
        '
        TicketCodeLabel.AutoSize = True
        TicketCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TicketCodeLabel.Location = New System.Drawing.Point(54, 43)
        TicketCodeLabel.Name = "TicketCodeLabel"
        TicketCodeLabel.Size = New System.Drawing.Size(97, 20)
        TicketCodeLabel.TabIndex = 1
        TicketCodeLabel.Text = "Ticket Code:"
        '
        'DateLabel
        '
        DateLabel.AutoSize = True
        DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateLabel.Location = New System.Drawing.Point(54, 82)
        DateLabel.Name = "DateLabel"
        DateLabel.Size = New System.Drawing.Size(48, 20)
        DateLabel.TabIndex = 3
        DateLabel.Text = "Date:"
        '
        'TotalCostLabel
        '
        TotalCostLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TotalCostLabel.AutoSize = True
        TotalCostLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalCostLabel.Location = New System.Drawing.Point(406, 43)
        TotalCostLabel.Name = "TotalCostLabel"
        TotalCostLabel.Size = New System.Drawing.Size(85, 20)
        TotalCostLabel.TabIndex = 5
        TotalCostLabel.Text = "Total Cost:"
        '
        'TotalIVALabel
        '
        TotalIVALabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TotalIVALabel.AutoSize = True
        TotalIVALabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TotalIVALabel.Location = New System.Drawing.Point(406, 81)
        TotalIVALabel.Name = "TotalIVALabel"
        TotalIVALabel.Size = New System.Drawing.Size(79, 20)
        TotalIVALabel.TabIndex = 7
        TotalIVALabel.Text = "Total IVA:"
        '
        'DatosTPV
        '
        Me.DatosTPV.DataSetName = "DatosTPV"
        Me.DatosTPV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TicketDetailBindingSource
        '
        Me.TicketDetailBindingSource.DataMember = "TicketDetail"
        Me.TicketDetailBindingSource.DataSource = Me.DatosTPV
        '
        'TicketDetailDataGridView
        '
        Me.TicketDetailDataGridView.AllowUserToAddRows = False
        Me.TicketDetailDataGridView.AllowUserToDeleteRows = False
        Me.TicketDetailDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TicketDetailDataGridView.AutoGenerateColumns = False
        Me.TicketDetailDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TicketDetailDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TicketDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TicketDetailDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TicketDetailDataGridView.DataSource = Me.TicketDetailBindingSource
        Me.TicketDetailDataGridView.Location = New System.Drawing.Point(46, 165)
        Me.TicketDetailDataGridView.Name = "TicketDetailDataGridView"
        Me.TicketDetailDataGridView.ReadOnly = True
        Me.TicketDetailDataGridView.Size = New System.Drawing.Size(689, 277)
        Me.TicketDetailDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idTicketDetail"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idTicketDetail"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "TicketCode"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Codigo Ticket"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ProductCode"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Producto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IndvPrice"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn4.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Cantidad"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TotalPrice"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'TicketBindingSource
        '
        Me.TicketBindingSource.DataMember = "Ticket"
        Me.TicketBindingSource.DataSource = Me.DatosTPV
        '
        'TicketCodeTextBox
        '
        Me.TicketCodeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TicketCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketBindingSource, "TicketCode", True))
        Me.TicketCodeTextBox.Enabled = False
        Me.TicketCodeTextBox.Location = New System.Drawing.Point(183, 43)
        Me.TicketCodeTextBox.Name = "TicketCodeTextBox"
        Me.TicketCodeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TicketCodeTextBox.TabIndex = 2
        '
        'DateDateTimePicker
        '
        Me.DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TicketBindingSource, "Date", True))
        Me.DateDateTimePicker.Enabled = False
        Me.DateDateTimePicker.Location = New System.Drawing.Point(183, 81)
        Me.DateDateTimePicker.Name = "DateDateTimePicker"
        Me.DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateDateTimePicker.TabIndex = 4
        '
        'TotalCostTextBox
        '
        Me.TotalCostTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalCostTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TotalCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketBindingSource, "TotalCost", True))
        Me.TotalCostTextBox.Enabled = False
        Me.TotalCostTextBox.Location = New System.Drawing.Point(535, 43)
        Me.TotalCostTextBox.Name = "TotalCostTextBox"
        Me.TotalCostTextBox.Size = New System.Drawing.Size(200, 20)
        Me.TotalCostTextBox.TabIndex = 6
        '
        'TotalIVATextBox
        '
        Me.TotalIVATextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalIVATextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TotalIVATextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TicketBindingSource, "TotalIVA", True))
        Me.TotalIVATextBox.Enabled = False
        Me.TotalIVATextBox.Location = New System.Drawing.Point(535, 81)
        Me.TotalIVATextBox.Name = "TotalIVATextBox"
        Me.TotalIVATextBox.Size = New System.Drawing.Size(200, 20)
        Me.TotalIVATextBox.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(532, 469)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(203, 63)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Imprimir Ticket"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.TPV.My.Resources.Resources.arrow_back_circle_outline_1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(46, 465)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'DetalleTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.TPV.My.MySettings.Default.ColorP
        Me.ClientSize = New System.Drawing.Size(757, 547)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(TicketCodeLabel)
        Me.Controls.Add(Me.TicketCodeTextBox)
        Me.Controls.Add(DateLabel)
        Me.Controls.Add(Me.DateDateTimePicker)
        Me.Controls.Add(TotalCostLabel)
        Me.Controls.Add(Me.TotalCostTextBox)
        Me.Controls.Add(TotalIVALabel)
        Me.Controls.Add(Me.TotalIVATextBox)
        Me.Controls.Add(Me.TicketDetailDataGridView)
        Me.MinimumSize = New System.Drawing.Size(773, 586)
        Me.Name = "DetalleTicket"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPV - Detalle ticket"
        CType(Me.DatosTPV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketDetailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatosTPV As ConexionBD.DatosTPV
    Friend WithEvents TicketDetailBindingSource As BindingSource
    Friend WithEvents TicketDetailDataGridView As DataGridView
    Friend WithEvents TicketBindingSource As BindingSource
    Friend WithEvents TicketCodeTextBox As TextBox
    Friend WithEvents DateDateTimePicker As DateTimePicker
    Friend WithEvents TotalCostTextBox As TextBox
    Friend WithEvents TotalIVATextBox As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
End Class
