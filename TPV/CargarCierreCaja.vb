Imports ConexionBD.DatosTPV

Public Class CargarCierreCaja
    Public cancel As Boolean
    Private linesT As TicketRow()
    Private linesDT As TicketDetailRow()
    Private form As CierreCaja

    Public Sub New(form As CierreCaja)
        InitializeComponent()
        Me.form = form
    End Sub

    Private Sub WorkerLoad_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles WorkerLoad.DoWork
        For Each row As TicketRow In linesT
            form.totalD += row.TotalCost
            form.totalIVAD += row.TotalIVA
            If row.Efectivo Then
                form.totalEfectivoD += row.TotalCost
            Else
                form.totalTarjetaD += row.TotalCost
            End If
            linesDT = form.DatosTPV.TicketDetail.Select("TicketCode = " & row.TicketCode)
            loadDetailLines()
            WorkerLoad.ReportProgress(1)
        Next
    End Sub

    Private Sub loadDetailLines()
        For Each row As TicketDetailRow In linesDT
            form.lines.Add(row)
        Next
    End Sub

    Private Sub WorkerLoad_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles WorkerLoad.ProgressChanged
        Progress.Increment(e.ProgressPercentage)
    End Sub

    Private Sub WorkerLoad_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles WorkerLoad.RunWorkerCompleted
        Me.Close()
    End Sub

    Private Sub CargarCierreCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        linesT = form.DatosTPV.Ticket.Select("Closed = 'False' AND Parada = 'False'")
        If linesT.Length > 0 Then
            Progress.Maximum = linesT.Length
            WorkerLoad.RunWorkerAsync()
        Else
            cancel = True
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cancel = False
        WorkerLoad.CancelAsync()
    End Sub
End Class