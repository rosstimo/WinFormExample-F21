Public Class WinFormExampleForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Me.Text = FirstNameTextBox.Text
    End Sub

    Private Sub WinFormExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
    End Sub

    Sub SetDefaults()
        TopRadioButton.Checked = True
        RadioButton5.Checked = True
        UpdateButton.Enabled = False
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        NumberTextBox.Text = ""
    End Sub

    Sub EvaluateUserFeilds()
        If FirstNameTextBox.Text <> "" And LastNameTextBox.Text <> "" And NumberTextBox.Text <> "" Then
            UpdateButton.Enabled = True
        Else
            UpdateButton.Enabled = False
        End If
    End Sub

    Private Sub FirstNameTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FirstNameTextBox.KeyPress,
                                                                                            LastNameTextBox.KeyPress,
                                                                                            NumberTextBox.KeyPress
        EvaluateUserFeilds()
    End Sub

    Private Sub FirstNameTextBox_LostFocus(sender As Object, e As EventArgs) Handles FirstNameTextBox.LostFocus,
                                                                                     LastNameTextBox.LostFocus,
                                                                                     NumberTextBox.LostFocus
        EvaluateUserFeilds()
    End Sub




End Class
