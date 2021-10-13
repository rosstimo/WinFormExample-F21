<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WinFormExampleForm
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
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumberTextBox = New System.Windows.Forms.TextBox()
        Me.NumberLabel = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BottomCheckBox = New System.Windows.Forms.CheckBox()
        Me.MiddleCheckBox = New System.Windows.Forms.CheckBox()
        Me.TopCheckBox = New System.Windows.Forms.CheckBox()
        Me.BottomRadioButton = New System.Windows.Forms.RadioButton()
        Me.MiddleRadioButton = New System.Windows.Forms.RadioButton()
        Me.TopRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(177, 19)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(165, 103)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(348, 19)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(165, 103)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ToolTip.SetToolTip(Me.ExitButton, "Press ALT-x to quit")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(69, 27)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(160, 20)
        Me.FirstNameTextBox.TabIndex = 0
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(6, 27)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(57, 13)
        Me.FirstNameLabel.TabIndex = 3
        Me.FirstNameLabel.Text = "First Name"
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(6, 19)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(165, 103)
        Me.UpdateButton.TabIndex = 1
        Me.UpdateButton.Text = "&Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Location = New System.Drawing.Point(245, 16)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(252, 278)
        Me.DisplayLabel.TabIndex = 4
        Me.DisplayLabel.Text = "L"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumberTextBox)
        Me.GroupBox1.Controls.Add(Me.NumberLabel)
        Me.GroupBox1.Controls.Add(Me.LastNameTextBox)
        Me.GroupBox1.Controls.Add(Me.LastNameLabel)
        Me.GroupBox1.Controls.Add(Me.FirstNameTextBox)
        Me.GroupBox1.Controls.Add(Me.FirstNameLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 184)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        Me.ToolTip.SetToolTip(Me.GroupBox1, "Please Enter All User Information")
        '
        'NumberTextBox
        '
        Me.NumberTextBox.Location = New System.Drawing.Point(69, 79)
        Me.NumberTextBox.Name = "NumberTextBox"
        Me.NumberTextBox.Size = New System.Drawing.Size(160, 20)
        Me.NumberTextBox.TabIndex = 6
        '
        'NumberLabel
        '
        Me.NumberLabel.AutoSize = True
        Me.NumberLabel.Location = New System.Drawing.Point(6, 79)
        Me.NumberLabel.Name = "NumberLabel"
        Me.NumberLabel.Size = New System.Drawing.Size(44, 13)
        Me.NumberLabel.TabIndex = 7
        Me.NumberLabel.Text = "Number"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(69, 53)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(160, 20)
        Me.LastNameTextBox.TabIndex = 4
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(6, 53)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(58, 13)
        Me.LastNameLabel.TabIndex = 5
        Me.LastNameLabel.Text = "Last Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox4)
        Me.GroupBox2.Controls.Add(Me.CheckBox5)
        Me.GroupBox2.Controls.Add(Me.CheckBox6)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Controls.Add(Me.RadioButton5)
        Me.GroupBox2.Controls.Add(Me.RadioButton6)
        Me.GroupBox2.Controls.Add(Me.DisplayLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(308, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(517, 341)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        Me.ToolTip.SetToolTip(Me.GroupBox2, "Optional select a formatting option")
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(145, 66)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox4.TabIndex = 5
        Me.CheckBox4.Text = "CheckBox4"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Location = New System.Drawing.Point(145, 43)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "CheckBox5"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Location = New System.Drawing.Point(145, 20)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox6.TabIndex = 3
        Me.CheckBox6.Text = "CheckBox6"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(6, 65)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton4.TabIndex = 2
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RadioButton4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(6, 42)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton5.TabIndex = 1
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "RadioButton5"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton6.TabIndex = 0
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "RadioButton6"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BottomCheckBox)
        Me.GroupBox3.Controls.Add(Me.MiddleCheckBox)
        Me.GroupBox3.Controls.Add(Me.TopCheckBox)
        Me.GroupBox3.Controls.Add(Me.BottomRadioButton)
        Me.GroupBox3.Controls.Add(Me.MiddleRadioButton)
        Me.GroupBox3.Controls.Add(Me.TopRadioButton)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 202)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(285, 292)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        Me.ToolTip.SetToolTip(Me.GroupBox3, "Please make a selection")
        '
        'BottomCheckBox
        '
        Me.BottomCheckBox.AutoSize = True
        Me.BottomCheckBox.Location = New System.Drawing.Point(148, 66)
        Me.BottomCheckBox.Name = "BottomCheckBox"
        Me.BottomCheckBox.Size = New System.Drawing.Size(59, 17)
        Me.BottomCheckBox.TabIndex = 5
        Me.BottomCheckBox.Text = "Bottom"
        Me.BottomCheckBox.UseVisualStyleBackColor = True
        '
        'MiddleCheckBox
        '
        Me.MiddleCheckBox.AutoSize = True
        Me.MiddleCheckBox.Location = New System.Drawing.Point(148, 43)
        Me.MiddleCheckBox.Name = "MiddleCheckBox"
        Me.MiddleCheckBox.Size = New System.Drawing.Size(57, 17)
        Me.MiddleCheckBox.TabIndex = 4
        Me.MiddleCheckBox.Text = "Middle"
        Me.MiddleCheckBox.UseVisualStyleBackColor = True
        '
        'TopCheckBox
        '
        Me.TopCheckBox.AutoSize = True
        Me.TopCheckBox.Location = New System.Drawing.Point(148, 20)
        Me.TopCheckBox.Name = "TopCheckBox"
        Me.TopCheckBox.Size = New System.Drawing.Size(45, 17)
        Me.TopCheckBox.TabIndex = 3
        Me.TopCheckBox.Text = "Top"
        Me.TopCheckBox.UseVisualStyleBackColor = True
        '
        'BottomRadioButton
        '
        Me.BottomRadioButton.AutoSize = True
        Me.BottomRadioButton.Location = New System.Drawing.Point(9, 65)
        Me.BottomRadioButton.Name = "BottomRadioButton"
        Me.BottomRadioButton.Size = New System.Drawing.Size(58, 17)
        Me.BottomRadioButton.TabIndex = 2
        Me.BottomRadioButton.TabStop = True
        Me.BottomRadioButton.Text = "Bottom"
        Me.BottomRadioButton.UseVisualStyleBackColor = True
        '
        'MiddleRadioButton
        '
        Me.MiddleRadioButton.AutoSize = True
        Me.MiddleRadioButton.Location = New System.Drawing.Point(9, 42)
        Me.MiddleRadioButton.Name = "MiddleRadioButton"
        Me.MiddleRadioButton.Size = New System.Drawing.Size(56, 17)
        Me.MiddleRadioButton.TabIndex = 1
        Me.MiddleRadioButton.TabStop = True
        Me.MiddleRadioButton.Text = "Middle"
        Me.MiddleRadioButton.UseVisualStyleBackColor = True
        '
        'TopRadioButton
        '
        Me.TopRadioButton.AutoSize = True
        Me.TopRadioButton.Location = New System.Drawing.Point(9, 19)
        Me.TopRadioButton.Name = "TopRadioButton"
        Me.TopRadioButton.Size = New System.Drawing.Size(44, 17)
        Me.TopRadioButton.TabIndex = 0
        Me.TopRadioButton.TabStop = True
        Me.TopRadioButton.Text = "Top"
        Me.TopRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.UpdateButton)
        Me.GroupBox4.Controls.Add(Me.ClearButton)
        Me.GroupBox4.Controls.Add(Me.ExitButton)
        Me.GroupBox4.Location = New System.Drawing.Point(302, 359)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(523, 135)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'WinFormExampleForm
        '
        Me.AcceptButton = Me.UpdateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(837, 506)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "WinFormExampleForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Example"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents UpdateButton As Button
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents NumberTextBox As TextBox
    Friend WithEvents NumberLabel As Label
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents TopCheckBox As CheckBox
    Friend WithEvents BottomRadioButton As RadioButton
    Friend WithEvents MiddleRadioButton As RadioButton
    Friend WithEvents TopRadioButton As RadioButton
    Friend WithEvents BottomCheckBox As CheckBox
    Friend WithEvents MiddleCheckBox As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents ToolTip As ToolTip
End Class
