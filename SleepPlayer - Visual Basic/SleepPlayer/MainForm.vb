Imports System.IO

Public Class MainForm
    'Dim PathString As String = IO.Path.GetFullPath(Directory.GetDirectoryRoot("\"))
    Dim PathString As String = Microsoft.VisualBasic.FileIO.SpecialDirectories.MyMusic &
                               "\Playlists"
    Dim playlists(1000) As String
    Dim SleepTimeHours, SleepTimeMinutes, SleepTime As Integer
    Friend SleepAction As String = "-s"
    'user controls for sleeping decrescendo
    Dim decrescendo As Boolean = False
    Dim _decrescendoTime As Integer = 5
    Dim _decrescendoAmount As Decimal = 0.9
    Dim dataChanged As Boolean = False

    Property decrescendoTime As Integer
        Get
            Return _decrescendoTime
        End Get
        Set(value As Integer)
            _decrescendoTime = value
            dataChanged = True
        End Set
    End Property

    Property decrescendoAmount As Decimal
        Get
            Return _decrescendoAmount
        End Get
        Set(value As Decimal)
            _decrescendoAmount = value
            dataChanged = True
        End Set
    End Property

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        writeUserData()
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        readUserData()
        MediaPlayer.settings.autoStart = False
        ListBox1.Items.Add("(none)")
        GetDirectoryContents()
        ListBox1.SelectedIndex = 0
        MediaPlayer.URL = String.Empty
        MediaPlayer.settings.volume = 100
    End Sub

    Private Sub GetDirectoryContents()
        Dim sDir As String = Microsoft.VisualBasic.FileIO.SpecialDirectories.MyMusic &
                               "\Playlists"
        Dim dDir As New DirectoryInfo(sDir)
        Dim fFileSystemInfo As FileSystemInfo
        Dim counter As Integer
        Dim Name As String

        For Each fFileSystemInfo In dDir.GetFileSystemInfos()
            Name = fFileSystemInfo.Name.Substring(0, fFileSystemInfo.Name.Length - 4)
            ListBox1.Items.Add(Name)
            playlists(counter) = fFileSystemInfo.FullName
            counter += 1
        Next
    End Sub


    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > 0 Then
            MediaPlayer.URL = playlists(ListBox1.SelectedIndex - 1)
        Else
            MediaPlayer.URL = String.Empty
        End If
    End Sub

    Private Sub SleepTimer_Tick(sender As System.Object, e As System.EventArgs) Handles SleepTimer.Tick
        If SleepTimeMinutes > 0 Then
            SleepTimeMinutes -= 1
            MinutesTextBox.Text = SleepTimeMinutes.ToString
        ElseIf SleepTimeHours > 0 And SleepTimeMinutes <= 0 Then
            SleepTimeMinutes = 59
            SleepTimeHours -= 1
            MinutesTextBox.Text = SleepTimeMinutes.ToString
            HoursTextBox.Text = SleepTimeHours.ToString
        Else
            MinutesTextBox.Text = "0"
            SleepTimer.Stop()
            ShutDownForm.Show()
        End If

        If SleepTimeMinutes Mod _decrescendoTime = 0 And decrescendo Then
            MediaPlayer.settings.volume = MediaPlayer.settings.volume * _decrescendoAmount
        End If

    End Sub



    Private Sub StartButton_Click(sender As System.Object, e As System.EventArgs) Handles StartButton.Click
        Try
            SleepTimeHours = Integer.Parse(HoursTextBox.Text)
            SleepTimeMinutes = Integer.Parse(MinutesTextBox.Text)
            If SleepTimeMinutes < 60 And (SleepTimeMinutes > 0 Or SleepTimeHours > 0) Then
                SleepTime = (SleepTimeHours * 60) + SleepTimeMinutes
                SleepTimer.Start()
                MinutesTextBox.ReadOnly = True
                HoursTextBox.ReadOnly = True
                SleepTimer_Tick(vbNull, System.EventArgs.Empty)
            Else
                MessageBox.Show("You must enter times greater than 0 and a minute value of less than 60!", "Time Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
                HoursTextBox.Text = "0"
                With MinutesTextBox
                    .Text = "0"
                    .Focus()
                End With
            End If
        Catch ex As Exception
            MessageBox.Show("You may only enter numbers for time!", "Time Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            HoursTextBox.Text = "0"
            With MinutesTextBox
                .Text = "0"
                .Focus()
            End With
        End Try

    End Sub

    Private Sub StopButton_Click(sender As System.Object, e As System.EventArgs) Handles StopButton.Click
        SleepTimer.Stop()
        SleepTime = 0
        SleepTimeHours = 0
        SleepTimeMinutes = 0
        MinutesTextBox.ReadOnly = False
        HoursTextBox.ReadOnly = False
        MediaPlayer.settings.volume = 100
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.InitialDirectory = Microsoft.VisualBasic.FileIO.SpecialDirectories.MyMusic
        With OpenFileDialog1
            .ShowDialog()
            MediaPlayer.URL = .FileName
        End With
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub RadioButtons_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles ShutDownRadioButton.CheckedChanged,
        SleepRadioButton.CheckedChanged, RestartRadioButton.CheckedChanged, CloseRadioButton.CheckedChanged

        If SleepRadioButton.Checked Then
            SleepAction = "SLEEP"
        ElseIf RestartRadioButton.Checked Then
            SleepAction = "RESTART"
        ElseIf CloseRadioButton.Checked Then
            SleepAction = "CLOSE"
        Else
            SleepAction = "SHUTDOWN"
        End If
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        OptionForm.ShowDialog(Me)
    End Sub

    Private Sub readUserData()
        Try
            Using reader As New StreamReader("config.txt")
                _decrescendoTime = Integer.Parse(reader.ReadLine)
                _decrescendoAmount = Decimal.Parse(reader.ReadLine)
            End Using
        Catch ex As Exception
            MessageBox.Show("Error reading options!", "Data could not be read properly, using default values", MessageBoxButtons.OK)
            _decrescendoAmount = 0.9
            _decrescendoTime = 5
            writeUserData()
        End Try
    End Sub

    Private Sub writeUserData()
        Using writer As New StreamWriter("config.txt")
            writer.WriteLine(_decrescendoTime)
            writer.WriteLine(_decrescendoAmount)
        End Using
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles DecrescendoCheckBox.CheckedChanged
        If DecrescendoCheckBox.Checked Then
            decrescendo = True
        Else
            decrescendo = False
        End If
    End Sub

    Private Sub HoursTextBox_TextChanged(sender As Object, e As EventArgs) Handles HoursTextBox.TextChanged
        If HoursTextBox.Text = String.Empty Then
            HoursTextBox.Text = "0"
        End If
    End Sub

    Private Sub MinutesTextBox_TextChanged(sender As Object, e As EventArgs) Handles MinutesTextBox.TextChanged
        If MinutesTextBox.Text = String.Empty Then
            MinutesTextBox.Text = "0"
        End If
    End Sub
End Class
