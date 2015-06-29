Public Class ShutDownForm
    Dim counter As Integer
    Dim DoHibernate As Boolean = False
    Dim DoClose As Boolean = False
    Dim ActionTaken As String = "Shutting Down"
    Private Sub ShutDownForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        StartShutDown()
    End Sub

    Private Sub StartShutDown()
        Select Case MainForm.SleepAction
            Case "RESTART"
                ActionTaken = "Restarting"
                Shell("Shutdown -r", AppWinStyle.Hide)
            Case "CLOSE"
                ActionTaken = "Closing"
                DoClose = True
            Case "SLEEP"
                ActionTaken = "Hibernating"
                DoHibernate = True
            Case Else
                ActionTaken = "Shutting down"
                Shell("Shutdown -s", AppWinStyle.Hide)

        End Select
        Label1.Text = ActionTaken & " in: "
        counter = 30
        TimerLabel.Text = counter.ToString()
        ShutDownTimer.Start()
    End Sub
    Private Sub ShutDownTimer_Tick(sender As System.Object, e As System.EventArgs) Handles ShutDownTimer.Tick
        If counter > 0 Then
            counter -= 1
        ElseIf counter = 0 And DoHibernate Then
            DoHibernate = False
            Shell("Shutdown -h", AppWinStyle.Hide)
            MainForm.Close()
        ElseIf counter = 0 And DoClose Then
            DoClose = False
            MainForm.Close()
        End If
        TimerLabel.Text = counter.ToString()
    End Sub

    Private Sub AbortButton_Click(sender As System.Object, e As System.EventArgs) Handles AbortButton.Click
        Shell("Shutdown -A")
        MainForm.StopButton.PerformClick()
        Me.Close()
    End Sub

    Public Sub Hibernate()
        DoHibernate = True
    End Sub
End Class