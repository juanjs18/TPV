<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Item
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.NameItem = New System.Windows.Forms.Label()
        Me.Picture = New System.Windows.Forms.PictureBox()
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NameItem
        '
        Me.NameItem.AutoSize = True
        Me.NameItem.Location = New System.Drawing.Point(22, 109)
        Me.NameItem.Name = "NameItem"
        Me.NameItem.Size = New System.Drawing.Size(44, 13)
        Me.NameItem.TabIndex = 1
        Me.NameItem.Text = "Nothing"
        '
        'Picture
        '
        Me.Picture.Image = Global.TPV.My.Resources.Resources.no_image
        Me.Picture.Location = New System.Drawing.Point(25, 18)
        Me.Picture.Name = "Picture"
        Me.Picture.Size = New System.Drawing.Size(94, 74)
        Me.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Picture.TabIndex = 0
        Me.Picture.TabStop = False
        '
        'Item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.NameItem)
        Me.Controls.Add(Me.Picture)
        Me.Name = "Item"
        Me.Size = New System.Drawing.Size(140, 137)
        CType(Me.Picture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Picture As PictureBox
    Friend WithEvents NameItem As Label
End Class
