<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuPrincipal
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonSell = New System.Windows.Forms.Button()
        Me.ButtonGestion = New System.Windows.Forms.Button()
        Me.ButtonConfig = New System.Windows.Forms.Button()
        Me.ButtonExit = New System.Windows.Forms.Button()
        Me.DatosTPV1 = New ConexionBD.DatosTPV()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DatosTPV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(279, 39)
        Me.Label1.MinimumSize = New System.Drawing.Size(70, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TPV"
        '
        'ButtonSell
        '
        Me.ButtonSell.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonSell.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.ButtonSell.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonSell.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSell.Location = New System.Drawing.Point(203, 111)
        Me.ButtonSell.Name = "ButtonSell"
        Me.ButtonSell.Size = New System.Drawing.Size(223, 129)
        Me.ButtonSell.TabIndex = 0
        Me.ButtonSell.Text = "Vender"
        Me.ButtonSell.UseVisualStyleBackColor = False
        '
        'ButtonGestion
        '
        Me.ButtonGestion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonGestion.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.ButtonGestion.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonGestion.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGestion.Location = New System.Drawing.Point(337, 258)
        Me.ButtonGestion.Name = "ButtonGestion"
        Me.ButtonGestion.Size = New System.Drawing.Size(194, 79)
        Me.ButtonGestion.TabIndex = 2
        Me.ButtonGestion.Text = "Administrar productos"
        Me.ButtonGestion.UseVisualStyleBackColor = False
        '
        'ButtonConfig
        '
        Me.ButtonConfig.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonConfig.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.ButtonConfig.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonConfig.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConfig.Location = New System.Drawing.Point(333, 497)
        Me.ButtonConfig.MinimumSize = New System.Drawing.Size(194, 79)
        Me.ButtonConfig.Name = "ButtonConfig"
        Me.ButtonConfig.Size = New System.Drawing.Size(194, 79)
        Me.ButtonConfig.TabIndex = 6
        Me.ButtonConfig.Text = "Configuracion"
        Me.ButtonConfig.UseVisualStyleBackColor = False
        '
        'ButtonExit
        '
        Me.ButtonExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonExit.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.ButtonExit.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ButtonExit.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.Location = New System.Drawing.Point(102, 497)
        Me.ButtonExit.MinimumSize = New System.Drawing.Size(194, 79)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(194, 79)
        Me.ButtonExit.TabIndex = 5
        Me.ButtonExit.Text = "Salir"
        Me.ButtonExit.UseVisualStyleBackColor = False
        '
        'DatosTPV1
        '
        Me.DatosTPV1.DataSetName = "DatosTPV"
        Me.DatosTPV1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.Button1.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(98, 262)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(194, 71)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Inventario"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.Button2.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(98, 353)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(194, 71)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Clientes"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.Button3.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorS", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Button3.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(337, 353)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(194, 71)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Albaranes y Facturacion"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.TPV.My.MySettings.Default.ColorP
        Me.ClientSize = New System.Drawing.Size(628, 609)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.ButtonConfig)
        Me.Controls.Add(Me.ButtonGestion)
        Me.Controls.Add(Me.ButtonSell)
        Me.Controls.Add(Me.Label1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("BackColor", Global.TPV.My.MySettings.Default, "ColorP", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.MinimumSize = New System.Drawing.Size(586, 570)
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPV"
        CType(Me.DatosTPV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonSell As Button
    Friend WithEvents ButtonGestion As Button
    Friend WithEvents ButtonConfig As Button
    Friend WithEvents ButtonExit As Button
    Friend WithEvents DatosTPV1 As ConexionBD.DatosTPV
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
