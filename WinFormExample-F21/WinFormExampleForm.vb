Public Class WinFormExampleForm
    Sub SetDefaults()
        TopRadioButton.Checked = True
        RadioButton5.Checked = True
        UpdateButton.Enabled = False
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        NumberTextBox.Text = ""
        TopCheckBox.Checked = False
        MiddleCheckBox.Checked = False
        BottomCheckBox.Checked = False

    End Sub

    Sub EvaluateUserFeilds()
        If FirstNameTextBox.Text <> "" And LastNameTextBox.Text <> "" And NumberTextBox.Text <> "" Then
            UpdateButton.Enabled = True
        Else
            UpdateButton.Enabled = False
        End If
    End Sub

    Function ValidateUserNumber() As Boolean
        Dim userNumber As Integer
        Dim userMessage As String
        Dim statusFlag As Boolean = False

        Try
            userNumber = CInt(NumberTextBox.Text)
            Select Case userNumber
                Case < 0
                    userMessage = "Must be a positive number"
                Case 0 To 5
                    userMessage = "Your number is too small"
                Case 6 To 47
                    'userMessage = "It's your lucky day!"
                    statusFlag = True
                Case Else
                    userMessage = "Your number is too big"
            End Select

        Catch ex As Exception
            NumberTextBox.Text = ""
            NumberTextBox.Select()
            userMessage = "Please enter a whole number"
        End Try

        If statusFlag <> True Then
            MsgBox(userMessage)
        End If

        Return statusFlag
    End Function

    Sub Display()
        DisplayLabel.Text = FirstNameTextBox.Text & " " &
            LastNameTextBox.Text & vbNewLine &
            "Lucky Number = " & NumberTextBox.Text
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        SetDefaults()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If ValidateUserNumber() Then
            Display()
        Else
            UpdateButton.Enabled = False
        End If
    End Sub

    Private Sub WinFormExampleForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetDefaults()
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
