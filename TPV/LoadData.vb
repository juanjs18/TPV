Imports ConexionBD

Public Class LoadData
    Private ds As DatosTPV
    Public Sub New(ds As DatosTPV)
        InitializeComponent()
        Me.ds = ds
    End Sub
    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Increment(e.ProgressPercentage)
        Label2.Text = e.UserState

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        ds.getData(BackgroundWorker1)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.Close()
    End Sub

    Private Sub LoadData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Maximum = 11
        BackgroundWorker1.RunWorkerAsync()
    End Sub
End Class