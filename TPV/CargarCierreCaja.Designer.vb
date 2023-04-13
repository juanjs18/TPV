<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CargarCierreCaja
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
        Me.WorkerLoad = New System.ComponentModel.BackgroundWorker()
        Me.Progress = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'WorkerLoad
        '
        Me.WorkerLoad.WorkerReportsProgress = True
        Me.WorkerLoad.WorkerSupportsCancellation = True
        '
        'Progress
        '
        Me.Progress.Location = New System.Drawing.Point(63, 127)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(534, 28)
        Me.Progress.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(230, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Procesando"
        '
        'Button1
        '
        Me.Button1.BackColor = Global.TPV.My.MySettings.Default.ColorS
        Me.Button1.Location = New System.Drawing.Point(266, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 42)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CargarCierreCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = Global.TPV.My.MySettings.Default.ColorP
        Me.ClientSize = New System.Drawing.Size(665, 325)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Progress)
        Me.Name = "CargarCierreCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TPV - Cargar Cierre"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WorkerLoad As System.ComponentModel.BackgroundWorker
    Friend WithEvents Progress As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
