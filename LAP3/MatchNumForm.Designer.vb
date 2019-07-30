<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MatchNumForm
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
        Me.resultTextBox = New System.Windows.Forms.TextBox()
        Me.playButton = New System.Windows.Forms.Button()
        Me.paymentPlanTextBox = New System.Windows.Forms.TextBox()
        Me.luckyNumberTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'resultTextBox
        '
        Me.resultTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.resultTextBox.Location = New System.Drawing.Point(8, 85)
        Me.resultTextBox.Multiline = True
        Me.resultTextBox.Name = "resultTextBox"
        Me.resultTextBox.ReadOnly = True
        Me.resultTextBox.Size = New System.Drawing.Size(215, 74)
        Me.resultTextBox.TabIndex = 7
        Me.resultTextBox.TabStop = False
        '
        'playButton
        '
        Me.playButton.Location = New System.Drawing.Point(229, 85)
        Me.playButton.Name = "playButton"
        Me.playButton.Size = New System.Drawing.Size(44, 27)
        Me.playButton.TabIndex = 8
        Me.playButton.Text = "Play!"
        Me.playButton.UseVisualStyleBackColor = True
        '
        'paymentPlanTextBox
        '
        Me.paymentPlanTextBox.Location = New System.Drawing.Point(82, 40)
        Me.paymentPlanTextBox.Name = "paymentPlanTextBox"
        Me.paymentPlanTextBox.Size = New System.Drawing.Size(100, 20)
        Me.paymentPlanTextBox.TabIndex = 4
        '
        'luckyNumberTextBox
        '
        Me.luckyNumberTextBox.Location = New System.Drawing.Point(82, 6)
        Me.luckyNumberTextBox.Name = "luckyNumberTextBox"
        Me.luckyNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.luckyNumberTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(184, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Between 1 and 3"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Payment Plan"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(187, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 29)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = """Lump Sum"" or ""20-year Spread"""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lucky Number"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Result:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 165)
        Me.Controls.Add(Me.resultTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.playButton)
        Me.Controls.Add(Me.paymentPlanTextBox)
        Me.Controls.Add(Me.luckyNumberTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Match the Number!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents resultTextBox As System.Windows.Forms.TextBox
    Friend WithEvents playButton As System.Windows.Forms.Button
    Friend WithEvents paymentPlanTextBox As System.Windows.Forms.TextBox
    Friend WithEvents luckyNumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
