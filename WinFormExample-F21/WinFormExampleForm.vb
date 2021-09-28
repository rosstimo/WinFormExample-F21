Public Class WinFormExampleForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub HelloButton_Click(sender As Object, e As EventArgs) Handles HelloButton.Click
        'MsgBox("Hello User")
        Me.Text = "Super Duper"
        HelloButton.Text = "Pressed"
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Me.Text = UserInputTextBox.Text
    End Sub
End Class
