<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.rtbChat = New System.Windows.Forms.RichTextBox()
        Me.txtChat = New System.Windows.Forms.TextBox()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpReminder = New System.Windows.Forms.DateTimePicker()
        Me.btnAddTask = New System.Windows.Forms.Button()
        Me.btnViewTasks = New System.Windows.Forms.Button()
        Me.btnCompleteTask = New System.Windows.Forms.Button()
        Me.btnDeleteTask = New System.Windows.Forms.Button()
        Me.dgvTasks = New System.Windows.Forms.DataGridView()
        Me.btnActivityLog = New System.Windows.Forms.Button()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.lblHeading.Location = New System.Drawing.Point(130, -1)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(489, 41)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Cybersecurity Awareness Chatbot"
        '
        'picLogo
        '
        Me.picLogo.Image = CType(resources.GetObject("picLogo.Image"), System.Drawing.Image)
        Me.picLogo.Location = New System.Drawing.Point(46, 12)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(78, 82)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogo.TabIndex = 1
        Me.picLogo.TabStop = False
        '
        'rtbChat
        '
        Me.rtbChat.BackColor = System.Drawing.Color.Black
        Me.rtbChat.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbChat.ForeColor = System.Drawing.Color.LimeGreen
        Me.rtbChat.Location = New System.Drawing.Point(29, 100)
        Me.rtbChat.Name = "rtbChat"
        Me.rtbChat.ReadOnly = True
        Me.rtbChat.Size = New System.Drawing.Size(665, 379)
        Me.rtbChat.TabIndex = 2
        Me.rtbChat.Text = ""
        '
        'txtChat
        '
        Me.txtChat.Location = New System.Drawing.Point(29, 492)
        Me.txtChat.Name = "txtChat"
        Me.txtChat.Size = New System.Drawing.Size(516, 22)
        Me.txtChat.TabIndex = 3
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.Color.LimeGreen
        Me.btnSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.Location = New System.Drawing.Point(574, 485)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(120, 35)
        Me.btnSend.TabIndex = 4
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(936, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Task Assistant"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Location = New System.Drawing.Point(966, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Task Title"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(877, 100)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(233, 22)
        Me.txtTitle.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label3.Location = New System.Drawing.Point(966, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Description"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(877, 167)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(233, 22)
        Me.txtDescription.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label4.Location = New System.Drawing.Point(950, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Reminder Date"
        '
        'dtpReminder
        '
        Me.dtpReminder.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpReminder.Location = New System.Drawing.Point(856, 235)
        Me.dtpReminder.Name = "dtpReminder"
        Me.dtpReminder.Size = New System.Drawing.Size(288, 22)
        Me.dtpReminder.TabIndex = 11
        '
        'btnAddTask
        '
        Me.btnAddTask.BackColor = System.Drawing.Color.DarkGray
        Me.btnAddTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTask.Location = New System.Drawing.Point(932, 284)
        Me.btnAddTask.Name = "btnAddTask"
        Me.btnAddTask.Size = New System.Drawing.Size(178, 45)
        Me.btnAddTask.TabIndex = 12
        Me.btnAddTask.Text = "Add Task"
        Me.btnAddTask.UseVisualStyleBackColor = False
        '
        'btnViewTasks
        '
        Me.btnViewTasks.BackColor = System.Drawing.Color.Gold
        Me.btnViewTasks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewTasks.Location = New System.Drawing.Point(932, 347)
        Me.btnViewTasks.Name = "btnViewTasks"
        Me.btnViewTasks.Size = New System.Drawing.Size(178, 44)
        Me.btnViewTasks.TabIndex = 13
        Me.btnViewTasks.Text = "View Tasks"
        Me.btnViewTasks.UseVisualStyleBackColor = False
        '
        'btnCompleteTask
        '
        Me.btnCompleteTask.BackColor = System.Drawing.Color.Lime
        Me.btnCompleteTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompleteTask.Location = New System.Drawing.Point(932, 471)
        Me.btnCompleteTask.Name = "btnCompleteTask"
        Me.btnCompleteTask.Size = New System.Drawing.Size(178, 43)
        Me.btnCompleteTask.TabIndex = 14
        Me.btnCompleteTask.Text = "Complete Task"
        Me.btnCompleteTask.UseVisualStyleBackColor = False
        '
        'btnDeleteTask
        '
        Me.btnDeleteTask.BackColor = System.Drawing.Color.Red
        Me.btnDeleteTask.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteTask.ForeColor = System.Drawing.Color.White
        Me.btnDeleteTask.Location = New System.Drawing.Point(932, 410)
        Me.btnDeleteTask.Name = "btnDeleteTask"
        Me.btnDeleteTask.Size = New System.Drawing.Size(178, 44)
        Me.btnDeleteTask.TabIndex = 15
        Me.btnDeleteTask.Text = "Delete Task"
        Me.btnDeleteTask.UseVisualStyleBackColor = False
        '
        'dgvTasks
        '
        Me.dgvTasks.AllowUserToAddRows = False
        Me.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTasks.Location = New System.Drawing.Point(29, 538)
        Me.dgvTasks.MultiSelect = False
        Me.dgvTasks.Name = "dgvTasks"
        Me.dgvTasks.RowHeadersWidth = 51
        Me.dgvTasks.RowTemplate.Height = 24
        Me.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTasks.Size = New System.Drawing.Size(665, 203)
        Me.dgvTasks.TabIndex = 16
        '
        'btnActivityLog
        '
        Me.btnActivityLog.BackColor = System.Drawing.Color.Blue
        Me.btnActivityLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActivityLog.Location = New System.Drawing.Point(932, 529)
        Me.btnActivityLog.Name = "btnActivityLog"
        Me.btnActivityLog.Size = New System.Drawing.Size(178, 42)
        Me.btnActivityLog.TabIndex = 17
        Me.btnActivityLog.Text = "Activity Log"
        Me.btnActivityLog.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1182, 753)
        Me.Controls.Add(Me.btnActivityLog)
        Me.Controls.Add(Me.dgvTasks)
        Me.Controls.Add(Me.btnDeleteTask)
        Me.Controls.Add(Me.btnCompleteTask)
        Me.Controls.Add(Me.btnViewTasks)
        Me.Controls.Add(Me.btnAddTask)
        Me.Controls.Add(Me.dtpReminder)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.txtChat)
        Me.Controls.Add(Me.rtbChat)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cybersecurity Awareness Chatbot"
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTasks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picLogo As PictureBox
    Friend WithEvents rtbChat As RichTextBox
    Friend WithEvents txtChat As TextBox
    Friend WithEvents btnSend As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpReminder As DateTimePicker
    Friend WithEvents btnAddTask As Button
    Friend WithEvents btnViewTasks As Button
    Friend WithEvents btnCompleteTask As Button
    Friend WithEvents btnDeleteTask As Button
    Friend WithEvents dgvTasks As DataGridView
    Friend WithEvents btnActivityLog As Button
End Class
