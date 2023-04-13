<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CierreCaja
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
        Me.TicketDetailDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TicketDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosTPV = New ConexionBD.DatosTPV()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.CierreCajaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TotalEfectivo = New System.Windows.Forms.Label()
        Me.TotalTarjeta = New System.Windows.Forms.Label()
        Me.TotalCaja = New System.Windows.Forms.Label()
        Me.AnteriorCaja = New System.Windows.Forms.Label()
        Me.IVA = New System.Windows.Forms.Label()
        Me.TicketInicial = New System.Windows.Forms.Label()
        Me.TicketFinal = New System.Windows.Forms.Label()
        Me.Fecha = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.TicketDetailDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TicketDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosTPV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CierreCajaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TicketDetailDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TicketDetailDataGridView.DataSource = Me.TicketDetailBindingSource
        Me.TicketDetailDataGridView.Location = New System.Drawing.Point(67, 259)
        Me.TicketDetailDataGridView.Name = "TicketDetailDataGridView"
        Me.TicketDetailDataGridView.ReadOnly = True
        Me.TicketDetailDataGridView.Size = New System.Drawing.Size(948, 290)
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
        Me.DataGridViewTextBoxColumn2.HeaderText = "TicketCode"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "NameProduct"
        Me.DataGridViewTextBoxColumn7.HeaderText = "NameProduct"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ProductCode"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ProductCode"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IndvPrice"
        Me.DataGridViewTextBoxColumn4.HeaderText = "IndvPrice"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "TotalPrice"
        Me.DataGridViewTextBoxColumn6.HeaderText = "TotalPrice"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'TicketDetailBindingSource
        '
        Me.TicketDetailBindingSource.DataMember = "TicketDetail"
        Me.TicketDetailBindingSource.DataSource = Me.DatosTPV
        '
        'DatosTPV
        '
        Me.DatosTPV.DataSetName = "DatosTPV"
        Me.DatosTPV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Total:"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(412, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total efectivo:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(412, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total tarjeta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Total IVA:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(736, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 24)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Conteo caja:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(736, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 24)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Conteo anterior:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(63, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 24)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Porcentaje IVA:"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(412, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 24)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Ticket incial:"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(412, 202)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 24)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Ticket final:"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(736, 172)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 24)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Fecha:"
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CierreCajaBindingSource, "Total", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(169, 71)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(14, 16)
        Me.Total.TabIndex = 12
        Me.Total.Text = "0"
        '
        'CierreCajaBindingSource
        '
        Me.CierreCajaBindingSource.DataMember = "CierresCaja"
        Me.CierreCajaBindingSource.DataSource = Me.DatosTPV
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CierreCajaBindingSource, "TotalIVA", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(169, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 16)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "0"
        '
        'TotalEfectivo
        '
        Me.TotalEfectivo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TotalEfectivo.AutoSize = True
        Me.TotalEfectivo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CierreCajaBindingSource, "TotalEfectivo", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.TotalEfectivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalEfectivo.Location = New System.Drawing.Point(559, 69)
        Me.TotalEfectivo.Name = "TotalEfectivo"
        Me.TotalEfectivo.Size = New System.Drawing.Size(14, 16)
        Me.TotalEfectivo.TabIndex = 14
        Me.TotalEfectivo.Text = "0"
        '
        'TotalTarjeta
        '
        Me.TotalTarjeta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TotalTarjeta.AutoSize = True
        Me.TotalTarjeta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CierreCajaBindingSource, "TotalTarjeta", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.TotalTarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTarjeta.Location = New System.Drawing.Point(559, 111)
        Me.TotalTarjeta.Name = "TotalTarjeta"
        Me.TotalTarjeta.Size = New System.Drawing.Size(14, 16)
        Me.TotalTarjeta.TabIndex = 15
        Me.TotalTarjeta.Text = "0"
        '
        'TotalCaja
        '
        Me.TotalCaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalCaja.AutoSize = True
        Me.TotalCaja.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CierreCajaBindingSource, "CajaActual", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.TotalCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCaja.Location = New System.Drawing.Point(886, 71)
        Me.TotalCaja.Name = "TotalCaja"
        Me.TotalCaja.Size = New System.Drawing.Size(14, 16)
        Me.TotalCaja.TabIndex = 16
        Me.TotalCaja.Text = "0"
        '
        'AnteriorCaja
        '
        Me.AnteriorCaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AnteriorCaja.AutoSize = True
        Me.AnteriorCaja.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CierreCajaBindingSource, "CajaAnterior", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.AnteriorCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AnteriorCaja.Location = New System.Drawing.Point(886, 113)
        Me.AnteriorCaja.Name = "AnteriorCaja"
        Me.AnteriorCaja.Size = New System.Drawing.Size(14, 16)
        Me.AnteriorCaja.TabIndex = 17
        Me.AnteriorCaja.Text = "0"
        '
        'IVA
        '
        Me.IVA.AutoSize = True
        Me.IVA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CierreCajaBindingSource, "IVA", True))
        Me.IVA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IVA.Location = New System.Drawing.Point(223, 178)
        Me.IVA.Name = "IVA"
        Me.IVA.Size = New System.Drawing.Size(14, 16)
        Me.IVA.TabIndex = 18
        Me.IVA.Text = "0"
        '
        'TicketInicial
        '
        Me.TicketInicial.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TicketInicial.AutoSize = True
        Me.TicketInicial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CierreCajaBindingSource, "TicketIni", True))
        Me.TicketInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TicketInicial.Location = New System.Drawing.Point(543, 170)
        Me.TicketInicial.Name = "TicketInicial"
        Me.TicketInicial.Size = New System.Drawing.Size(14, 16)
        Me.TicketInicial.TabIndex = 19
        Me.TicketInicial.Text = "0"
        '
        'TicketFinal
        '
        Me.TicketFinal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TicketFinal.AutoSize = True
        Me.TicketFinal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CierreCajaBindingSource, "TicketFin", True))
        Me.TicketFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TicketFinal.Location = New System.Drawing.Point(543, 210)
        Me.TicketFinal.Name = "TicketFinal"
        Me.TicketFinal.Size = New System.Drawing.Size(14, 16)
        Me.TicketFinal.TabIndex = 20
        Me.TicketFinal.Text = "0"
        '
        'Fecha
        '
        Me.Fecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Fecha.AutoSize = True
        Me.Fecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CierreCajaBindingSource, "Fecha", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "G"))
        Me.Fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fecha.Location = New System.Drawing.Point(817, 178)
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Size = New System.Drawing.Size(14, 16)
        Me.Fecha.TabIndex = 21
        Me.Fecha.Text = "0"
        '
        'PrintDocument1
        '
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(479, 577)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(116, 53)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "Imprimir cierre de caja"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(62, 19)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(215, 25)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "Detalle cierre de caja"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.TPV.My.Resources.Resources.arrow_back_circle_outline_1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(67, 570)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'CierreCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.TPV.My.MySettings.Default.ColorP
        Me.ClientSize = New System.Drawing.Size(1075, 652)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Fecha)
        Me.Controls.Add(Me.TicketFinal)
        Me.Controls.Add(Me.TicketInicial)
        Me.Controls.Add(Me.IVA)
        Me.Controls.Add(Me.AnteriorCaja)
        Me.Controls.Add(Me.TotalCaja)
        Me.Controls.Add(Me.TotalTarjeta)
        Me.Controls.Add(Me.TotalEfectivo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TicketDetailDataGridView)
        Me.Name = "CierreCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPV - Cierre Caja"
        CType(Me.TicketDetailDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TicketDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosTPV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CierreCajaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatosTPV As ConexionBD.DatosTPV
    Friend WithEvents TicketDetailBindingSource As BindingSource
    Friend WithEvents TicketDetailDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Total As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TotalEfectivo As Label
    Friend WithEvents TotalTarjeta As Label
    Friend WithEvents TotalCaja As Label
    Friend WithEvents AnteriorCaja As Label
    Friend WithEvents IVA As Label
    Friend WithEvents TicketInicial As Label
    Friend WithEvents TicketFinal As Label
    Friend WithEvents Fecha As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Button2 As Button
    Friend WithEvents Label21 As Label
    Friend WithEvents CierreCajaBindingSource As BindingSource
    Friend WithEvents PictureBox1 As PictureBox
End Class
