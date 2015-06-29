<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShutDownForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimerLabel = New System.Windows.Forms.Label()
        Me.AbortButton = New System.Windows.Forms.Button()
        Me.ShutDownTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Shutting down in:"
        '
        'TimerLabel
        '
        Me.TimerLabel.AutoSize = True
        Me.TimerLabel.Location = New System.Drawing.Point(169, 9)
        Me.TimerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TimerLabel.Name = "TimerLabel"
        Me.TimerLabel.Size = New System.Drawing.Size(29, 20)
        Me.TimerLabel.TabIndex = 1
        Me.TimerLabel.Text = "30"
        '
        'AbortButton
        '
        Me.AbortButton.Location = New System.Drawing.Point(40, 34)
        Me.AbortButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AbortButton.Name = "AbortButton"
        Me.AbortButton.Size = New System.Drawing.Size(124, 35)
        Me.AbortButton.TabIndex = 2
        Me.AbortButton.Text = "Abort!"
        Me.AbortButton.UseVisualStyleBackColor = True
        '
        'ShutDownTimer
        '
        Me.ShutDownTimer.Interval = 1000
        '
        'ShutDownForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(205, 81)
        Me.Controls.Add(Me.AbortButton)
        Me.Controls.Add(Me.TimerLabel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ShutDownForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shut Down"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TimerLabel As System.Windows.Forms.Label
    Friend WithEvents AbortButton As System.Windows.Forms.Button
    Friend WithEvents ShutDownTimer As System.Windows.Forms.Timer
End Class
