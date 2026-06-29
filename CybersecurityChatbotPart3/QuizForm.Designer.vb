<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuizForm
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
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.rbA = New System.Windows.Forms.RadioButton()
        Me.rbB = New System.Windows.Forms.RadioButton()
        Me.rbC = New System.Windows.Forms.RadioButton()
        Me.rbD = New System.Windows.Forms.RadioButton()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Location = New System.Drawing.Point(39, 77)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(144, 16)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "Question appears here"
        '
        'rbA
        '
        Me.rbA.AutoSize = True
        Me.rbA.Location = New System.Drawing.Point(43, 121)
        Me.rbA.Name = "rbA"
        Me.rbA.Size = New System.Drawing.Size(37, 20)
        Me.rbA.TabIndex = 1
        Me.rbA.TabStop = True
        Me.rbA.Text = "A"
        Me.rbA.UseVisualStyleBackColor = True
        '
        'rbB
        '
        Me.rbB.AutoSize = True
        Me.rbB.Location = New System.Drawing.Point(43, 178)
        Me.rbB.Name = "rbB"
        Me.rbB.Size = New System.Drawing.Size(37, 20)
        Me.rbB.TabIndex = 2
        Me.rbB.TabStop = True
        Me.rbB.Text = "B"
        Me.rbB.UseVisualStyleBackColor = True
        '
        'rbC
        '
        Me.rbC.AutoSize = True
        Me.rbC.Location = New System.Drawing.Point(42, 236)
        Me.rbC.Name = "rbC"
        Me.rbC.Size = New System.Drawing.Size(37, 20)
        Me.rbC.TabIndex = 3
        Me.rbC.TabStop = True
        Me.rbC.Text = "C"
        Me.rbC.UseVisualStyleBackColor = True
        '
        'rbD
        '
        Me.rbD.AutoSize = True
        Me.rbD.Location = New System.Drawing.Point(42, 289)
        Me.rbD.Name = "rbD"
        Me.rbD.Size = New System.Drawing.Size(38, 20)
        Me.rbD.TabIndex = 4
        Me.rbD.TabStop = True
        Me.rbD.Text = "D"
        Me.rbD.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(100, 335)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(125, 23)
        Me.btnNext.TabIndex = 5
        Me.btnNext.Text = "Next Question"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Location = New System.Drawing.Point(24, 392)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(56, 16)
        Me.lblScore.TabIndex = 6
        Me.lblScore.Text = "Score: 0"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(212, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(367, 29)
        Me.lblHeader.TabIndex = 7
        Me.lblHeader.Text = "Cybersecurity Awareness Quiz"
        '
        'QuizForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.rbD)
        Me.Controls.Add(Me.rbC)
        Me.Controls.Add(Me.rbB)
        Me.Controls.Add(Me.rbA)
        Me.Controls.Add(Me.lblQuestion)
        Me.Name = "QuizForm"
        Me.Text = "QuizForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuestion As Label
    Friend WithEvents rbA As RadioButton
    Friend WithEvents rbB As RadioButton
    Friend WithEvents rbC As RadioButton
    Friend WithEvents rbD As RadioButton
    Friend WithEvents btnNext As Button
    Friend WithEvents lblScore As Label
    Friend WithEvents lblHeader As Label
End Class
