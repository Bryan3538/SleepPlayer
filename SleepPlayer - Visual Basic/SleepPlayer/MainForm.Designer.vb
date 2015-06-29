<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MediaPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SleepTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DecrescendoCheckBox = New System.Windows.Forms.CheckBox()
        Me.HoursTextBox = New System.Windows.Forms.TextBox()
        Me.MinutesTextBox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CloseRadioButton = New System.Windows.Forms.RadioButton()
        Me.RestartRadioButton = New System.Windows.Forms.RadioButton()
        Me.SleepRadioButton = New System.Windows.Forms.RadioButton()
        Me.ShutDownRadioButton = New System.Windows.Forms.RadioButton()
        CType(Me.MediaPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MediaPlayer
        '
        Me.MediaPlayer.Enabled = True
        Me.MediaPlayer.Location = New System.Drawing.Point(12, 36)
        Me.MediaPlayer.Margin = New System.Windows.Forms.Padding(4)
        Me.MediaPlayer.Name = "MediaPlayer"
        Me.MediaPlayer.OcxState = CType(resources.GetObject("MediaPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MediaPlayer.Size = New System.Drawing.Size(618, 350)
        Me.MediaPlayer.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(638, 36)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(369, 180)
        Me.ListBox1.TabIndex = 2
        '
        'SleepTimer
        '
        Me.SleepTimer.Interval = 60000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Set sleep time:"
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(154, 53)
        Me.StartButton.Margin = New System.Windows.Forms.Padding(4)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(100, 28)
        Me.StartButton.TabIndex = 5
        Me.StartButton.Text = "Start Sleep"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Location = New System.Drawing.Point(262, 53)
        Me.StopButton.Margin = New System.Windows.Forms.Padding(4)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(100, 28)
        Me.StopButton.TabIndex = 6
        Me.StopButton.Text = "Stop Sleep"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(116, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Hours:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(238, 19)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Minutes:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DecrescendoCheckBox)
        Me.GroupBox1.Controls.Add(Me.HoursTextBox)
        Me.GroupBox1.Controls.Add(Me.MinutesTextBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.StopButton)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.StartButton)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(638, 298)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 88)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sleep Timer"
        '
        'DecrescendoCheckBox
        '
        Me.DecrescendoCheckBox.AutoSize = True
        Me.DecrescendoCheckBox.Checked = True
        Me.DecrescendoCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.DecrescendoCheckBox.Location = New System.Drawing.Point(9, 58)
        Me.DecrescendoCheckBox.Name = "DecrescendoCheckBox"
        Me.DecrescendoCheckBox.Size = New System.Drawing.Size(111, 21)
        Me.DecrescendoCheckBox.TabIndex = 13
        Me.DecrescendoCheckBox.Text = "Decrescendo"
        Me.DecrescendoCheckBox.UseVisualStyleBackColor = True
        '
        'HoursTextBox
        '
        Me.HoursTextBox.Location = New System.Drawing.Point(173, 16)
        Me.HoursTextBox.Name = "HoursTextBox"
        Me.HoursTextBox.Size = New System.Drawing.Size(56, 23)
        Me.HoursTextBox.TabIndex = 12
        Me.HoursTextBox.Text = "0"
        Me.HoursTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MinutesTextBox
        '
        Me.MinutesTextBox.Location = New System.Drawing.Point(306, 16)
        Me.MinutesTextBox.Name = "MinutesTextBox"
        Me.MinutesTextBox.Size = New System.Drawing.Size(56, 23)
        Me.MinutesTextBox.TabIndex = 11
        Me.MinutesTextBox.Text = "0"
        Me.MinutesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1017, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.OpenToolStripMenuItem.Text = "Open..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(109, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.OptionsToolStripMenuItem.Text = "Options..."
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CloseRadioButton)
        Me.GroupBox2.Controls.Add(Me.RestartRadioButton)
        Me.GroupBox2.Controls.Add(Me.SleepRadioButton)
        Me.GroupBox2.Controls.Add(Me.ShutDownRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(638, 223)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(369, 69)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Action on Sleep"
        '
        'CloseRadioButton
        '
        Me.CloseRadioButton.AutoSize = True
        Me.CloseRadioButton.Location = New System.Drawing.Point(255, 24)
        Me.CloseRadioButton.Name = "CloseRadioButton"
        Me.CloseRadioButton.Size = New System.Drawing.Size(105, 21)
        Me.CloseRadioButton.TabIndex = 3
        Me.CloseRadioButton.TabStop = True
        Me.CloseRadioButton.Text = "Close Player"
        Me.CloseRadioButton.UseVisualStyleBackColor = True
        '
        'RestartRadioButton
        '
        Me.RestartRadioButton.AutoSize = True
        Me.RestartRadioButton.Location = New System.Drawing.Point(177, 24)
        Me.RestartRadioButton.Name = "RestartRadioButton"
        Me.RestartRadioButton.Size = New System.Drawing.Size(72, 21)
        Me.RestartRadioButton.TabIndex = 2
        Me.RestartRadioButton.TabStop = True
        Me.RestartRadioButton.Text = "Restart"
        Me.RestartRadioButton.UseVisualStyleBackColor = True
        '
        'SleepRadioButton
        '
        Me.SleepRadioButton.AutoSize = True
        Me.SleepRadioButton.Location = New System.Drawing.Point(109, 24)
        Me.SleepRadioButton.Name = "SleepRadioButton"
        Me.SleepRadioButton.Size = New System.Drawing.Size(62, 21)
        Me.SleepRadioButton.TabIndex = 1
        Me.SleepRadioButton.TabStop = True
        Me.SleepRadioButton.Text = "Sleep"
        Me.SleepRadioButton.UseVisualStyleBackColor = True
        '
        'ShutDownRadioButton
        '
        Me.ShutDownRadioButton.AutoSize = True
        Me.ShutDownRadioButton.Checked = True
        Me.ShutDownRadioButton.Location = New System.Drawing.Point(9, 24)
        Me.ShutDownRadioButton.Name = "ShutDownRadioButton"
        Me.ShutDownRadioButton.Size = New System.Drawing.Size(94, 21)
        Me.ShutDownRadioButton.TabIndex = 0
        Me.ShutDownRadioButton.TabStop = True
        Me.ShutDownRadioButton.Text = "Shut Down"
        Me.ShutDownRadioButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.StartButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 396)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.MediaPlayer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sleep Player"
        CType(Me.MediaPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MediaPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents SleepTimer As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents StopButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents HoursTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MinutesTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CloseRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents RestartRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents SleepRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ShutDownRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DecrescendoCheckBox As System.Windows.Forms.CheckBox

End Class
