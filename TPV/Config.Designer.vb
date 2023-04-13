<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Config
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
        Dim CountryLabel As System.Windows.Forms.Label
        Dim PostalCodeLabel As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtConfiguracionEmpresa = New System.Windows.Forms.TextBox()
        Me.txtConfiguracionTelefono = New System.Windows.Forms.TextBox()
        Me.txtConfiguracionNIF = New System.Windows.Forms.TextBox()
        Me.txtConfiguracionIVA = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatosTPV = New ConexionBD.DatosTPV()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.PostalCodeTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.LblUbicacion = New System.Windows.Forms.Label()
        Me.BtnBuscarRuta = New System.Windows.Forms.Button()
        Me.LblRuta = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        NameLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        PostalCodeLabel = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatosTPV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(492, 128)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(79, 20)
        NameLabel.TabIndex = 12
        NameLabel.Text = "Municipio:"
        '
        'CountryLabel
        '
        CountryLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        CountryLabel.AutoSize = True
        CountryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CountryLabel.Location = New System.Drawing.Point(492, 213)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(43, 20)
        CountryLabel.TabIndex = 16
        CountryLabel.Text = "Pais:"
        '
        'PostalCodeLabel
        '
        PostalCodeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right
        PostalCodeLabel.AutoSize = True
        PostalCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PostalCodeLabel.Location = New System.Drawing.Point(492, 171)
        PostalCodeLabel.Name = "PostalCodeLabel"
        PostalCodeLabel.Size = New System.Drawing.Size(111, 20)
        PostalCodeLabel.TabIndex = 20
        PostalCodeLabel.Text = "Codigo Postal:"
        '
        'Label6
        '
        Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.Location = New System.Drawing.Point(492, 255)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(48, 20)
        Label6.TabIndex = 26
        Label6.Text = "Calle:"
        '
        'Label7
        '
        Label7.Anchor = System.Windows.Forms.AnchorStyles.Right
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.Location = New System.Drawing.Point(492, 298)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(60, 20)
        Label7.TabIndex = 28
        Label7.Text = "Puerta:"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.Button1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(650, 372)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 88)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(310, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Información Empresa"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre empresa:"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Telefono:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "NIF:"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "IVA:"
        '
        'txtConfiguracionEmpresa
        '
        Me.txtConfiguracionEmpresa.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConfiguracionEmpresa.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtConfiguracionEmpresa.Location = New System.Drawing.Point(208, 129)
        Me.txtConfiguracionEmpresa.Name = "txtConfiguracionEmpresa"
        Me.txtConfiguracionEmpresa.Size = New System.Drawing.Size(229, 20)
        Me.txtConfiguracionEmpresa.TabIndex = 0
        '
        'txtConfiguracionTelefono
        '
        Me.txtConfiguracionTelefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConfiguracionTelefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtConfiguracionTelefono.Location = New System.Drawing.Point(208, 171)
        Me.txtConfiguracionTelefono.Name = "txtConfiguracionTelefono"
        Me.txtConfiguracionTelefono.Size = New System.Drawing.Size(229, 20)
        Me.txtConfiguracionTelefono.TabIndex = 1
        '
        'txtConfiguracionNIF
        '
        Me.txtConfiguracionNIF.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConfiguracionNIF.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtConfiguracionNIF.Location = New System.Drawing.Point(208, 213)
        Me.txtConfiguracionNIF.Name = "txtConfiguracionNIF"
        Me.txtConfiguracionNIF.Size = New System.Drawing.Size(229, 20)
        Me.txtConfiguracionNIF.TabIndex = 2
        '
        'txtConfiguracionIVA
        '
        Me.txtConfiguracionIVA.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtConfiguracionIVA.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtConfiguracionIVA.Location = New System.Drawing.Point(208, 255)
        Me.txtConfiguracionIVA.Name = "txtConfiguracionIVA"
        Me.txtConfiguracionIVA.Size = New System.Drawing.Size(229, 20)
        Me.txtConfiguracionIVA.TabIndex = 3
        '
        'NameTextBox
        '
        Me.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.NameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "nameCity", True))
        Me.NameTextBox.Enabled = False
        Me.NameTextBox.Location = New System.Drawing.Point(638, 129)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(120, 20)
        Me.NameTextBox.TabIndex = 13
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DatosTPV
        Me.DataTable1BindingSource.Filter = "idCountry = 1"
        '
        'DatosTPV
        '
        Me.DatosTPV.DataSetName = "DatosTPV"
        Me.DatosTPV.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CountryTextBox
        '
        Me.CountryTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.CountryTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "country", True))
        Me.CountryTextBox.Enabled = False
        Me.CountryTextBox.Location = New System.Drawing.Point(638, 213)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(120, 20)
        Me.CountryTextBox.TabIndex = 17
        '
        'PostalCodeTextBox
        '
        Me.PostalCodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PostalCodeTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PostalCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataTable1BindingSource, "postalCode", True))
        Me.PostalCodeTextBox.Enabled = False
        Me.PostalCodeTextBox.Location = New System.Drawing.Point(638, 171)
        Me.PostalCodeTextBox.Name = "PostalCodeTextBox"
        Me.PostalCodeTextBox.Size = New System.Drawing.Size(120, 20)
        Me.PostalCodeTextBox.TabIndex = 21
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button3.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.Button3.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button3.Location = New System.Drawing.Point(775, 211)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(32, 22)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "..."
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Button5.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.Button5.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button5.Location = New System.Drawing.Point(775, 128)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 20)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(638, 255)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(120, 20)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TextBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(638, 298)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(120, 20)
        Me.TextBox2.TabIndex = 8
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(312, 390)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 20)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Color primario:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(312, 434)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 20)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Color secundario:"
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.Button4.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button4.Location = New System.Drawing.Point(464, 386)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 30)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Color"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button6.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.Button6.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button6.Location = New System.Drawing.Point(464, 430)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(88, 30)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Color"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'LblUbicacion
        '
        Me.LblUbicacion.AutoSize = True
        Me.LblUbicacion.Location = New System.Drawing.Point(422, 338)
        Me.LblUbicacion.Name = "LblUbicacion"
        Me.LblUbicacion.Size = New System.Drawing.Size(0, 13)
        Me.LblUbicacion.TabIndex = 35
        '
        'BtnBuscarRuta
        '
        Me.BtnBuscarRuta.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.BtnBuscarRuta.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.BtnBuscarRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarRuta.Location = New System.Drawing.Point(405, 297)
        Me.BtnBuscarRuta.Name = "BtnBuscarRuta"
        Me.BtnBuscarRuta.Size = New System.Drawing.Size(32, 26)
        Me.BtnBuscarRuta.TabIndex = 4
        Me.BtnBuscarRuta.Text = "..."
        Me.BtnBuscarRuta.UseVisualStyleBackColor = False
        '
        'LblRuta
        '
        Me.LblRuta.AutoSize = True
        Me.LblRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRuta.Location = New System.Drawing.Point(33, 303)
        Me.LblRuta.Name = "LblRuta"
        Me.LblRuta.Size = New System.Drawing.Size(246, 20)
        Me.LblRuta.TabIndex = 33
        Me.LblRuta.Text = "Ruta donde  guardar las facturas:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.TPV.My.Resources.Resources.arrow_back_circle_outline_1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(37, 408)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'Config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.TPV.My.MySettings.Default.ColorP
        Me.ClientSize = New System.Drawing.Size(919, 490)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblUbicacion)
        Me.Controls.Add(Me.BtnBuscarRuta)
        Me.Controls.Add(Me.LblRuta)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Label7)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(PostalCodeLabel)
        Me.Controls.Add(Me.PostalCodeTextBox)
        Me.Controls.Add(Me.txtConfiguracionIVA)
        Me.Controls.Add(Me.txtConfiguracionNIF)
        Me.Controls.Add(Me.txtConfiguracionTelefono)
        Me.Controls.Add(Me.txtConfiguracionEmpresa)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Name = "Config"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPV - Configuración"
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatosTPV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtConfiguracionEmpresa As TextBox
    Friend WithEvents txtConfiguracionTelefono As TextBox
    Friend WithEvents txtConfiguracionNIF As TextBox
    Friend WithEvents txtConfiguracionIVA As TextBox
    Friend WithEvents DatosTPV As ConexionBD.DatosTPV
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents PostalCodeTextBox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents LblUbicacion As Label
    Friend WithEvents BtnBuscarRuta As Button
    Friend WithEvents LblRuta As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
