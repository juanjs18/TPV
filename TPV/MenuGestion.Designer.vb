<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuGestion
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnProductosInhabilitados = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.Button1.Location = New System.Drawing.Point(272, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 98)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "CATEGORIAS"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.Button2.Location = New System.Drawing.Point(60, 100)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(157, 98)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "PRODUCTOS"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 29)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Que quieres gestionar?"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = Global.TPV.My.Resources.Resources.arrow_back_circle_outline_1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 340)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 70)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'BtnProductosInhabilitados
        '
        Me.BtnProductosInhabilitados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtnProductosInhabilitados.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.BtnProductosInhabilitados.Location = New System.Drawing.Point(166, 230)
        Me.BtnProductosInhabilitados.Name = "BtnProductosInhabilitados"
        Me.BtnProductosInhabilitados.Size = New System.Drawing.Size(157, 98)
        Me.BtnProductosInhabilitados.TabIndex = 26
        Me.BtnProductosInhabilitados.Text = "PRODUCTOS DESHABILITADOS"
        Me.BtnProductosInhabilitados.UseVisualStyleBackColor = False
        '
        'MenuGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.TPV.My.MySettings.Default.ColorP
        Me.ClientSize = New System.Drawing.Size(491, 422)
        Me.Controls.Add(Me.BtnProductosInhabilitados)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.MinimumSize = New System.Drawing.Size(507, 461)
        Me.Name = "MenuGestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPV - Administrar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnProductosInhabilitados As Button
End Class
