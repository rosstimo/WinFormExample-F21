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
        Me.HelloButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UserInputTextBox = New System.Windows.Forms.TextBox()
        Me.UserInputLabel = New System.Windows.Forms.Label()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HelloButton
        '
        Me.HelloButton.Location = New System.Drawing.Point(593, 427)
        Me.HelloButton.Name = "HelloButton"
        Me.HelloButton.Size = New System.Drawing.Size(165, 103)
        Me.HelloButton.TabIndex = 2
        Me.HelloButton.Text = "Say &Hello"
        Me.HelloButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Location = New System.Drawing.Point(764, 427)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(165, 103)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'UserInputTextBox
        '
        Me.UserInputTextBox.Location = New System.Drawing.Point(49, 6)
        Me.UserInputTextBox.Name = "UserInputTextBox"
        Me.UserInputTextBox.Size = New System.Drawing.Size(291, 20)
        Me.UserInputTextBox.TabIndex = 0
        '
        'UserInputLabel
        '
        Me.UserInputLabel.AutoSize = True
        Me.UserInputLabel.Location = New System.Drawing.Point(12, 9)
        Me.UserInputLabel.Name = "UserInputLabel"
        Me.UserInputLabel.Size = New System.Drawing.Size(31, 13)
        Me.UserInputLabel.TabIndex = 3
        Me.UserInputLabel.Text = "Input"
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(251, 427)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(165, 103)
        Me.UpdateButton.TabIndex = 1
        Me.UpdateButton.Text = "&Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayLabel.Location = New System.Drawing.Point(38, 35)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(511, 350)
        Me.DisplayLabel.TabIndex = 4
        Me.DisplayLabel.Text = "osaenhytisenhytiohytiy"
        Me.DisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(422, 427)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(165, 103)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DisplayLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(371, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(555, 409)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'WinFormExampleForm
        '
        Me.AcceptButton = Me.UpdateButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(938, 542)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.UserInputLabel)
        Me.Controls.Add(Me.UserInputTextBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.HelloButton)
        Me.Name = "WinFormExampleForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Example"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HelloButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents UserInputTextBox As TextBox
    Friend WithEvents UserInputLabel As Label
    Friend WithEvents UpdateButton As Button
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents ClearButton As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
