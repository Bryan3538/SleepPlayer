Public Class OptionForm

    Private Sub cancelButton_Click(sender As Object, e As EventArgs) Handles cancelButton.Click
        Me.Close()
    End Sub

    Private Sub okButton_Click(sender As Object, e As EventArgs) Handles okButton.Click
        Try
            MainForm.decrescendoTime = Integer.Parse(decrescendoTimeTextBox.Text)
            Dim da As Decimal = Decimal.Parse(decrescendoAmountTextBox.Text)
            MainForm.decrescendoAmount = 1.0 - da * 0.01
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Numbers Only!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub OptionForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        decrescendoAmountTextBox.Text = 100 - MainForm.decrescendoAmount / 0.01
        decrescendoTimeTextBox.Text = MainForm.decrescendoTime
    End Sub
End Class