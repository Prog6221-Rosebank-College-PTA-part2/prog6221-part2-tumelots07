Imports System.Security.Authentication.ExtendedProtection
Imports MySql.Data.MySqlClient
Imports System.Media
Imports System.IO

Public Class Form1

    Private db As New DatabaseHelper()

    Private Sub AddActivity(action As String)
        ActivityLog.AddLog(action)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            Dim connectionString As String =
                "server=localhost;database=CybersecurityChatbotDB;user=root;password=Vwpolo1.6;"

            Using conn As New MySqlConnection(connectionString)
                conn.Open()
            End Using

            LoadTasks()
            CheckReminders()

        Catch ex As Exception

            MessageBox.Show("Database connection failed." & vbCrLf & ex.Message)

        End Try

        '========================
        ' WELCOME SOUND + ASCII
        '========================

        Try
            'Play welcome sound
            Dim player As New SoundPlayer("Resources\Welcome.wav")
            player.Play()

            'Load ASCII Art
            If File.Exists("ASCIIArt.txt") Then
                Dim ascii As String = File.ReadAllText("Resources\ASCIIArt.txt")
                rtbChat.AppendText(Environment.NewLine &
                                   ascii &
                                   Environment.NewLine &
                                   "Welcome to Cybersecurity Chatbot!" &
                                   Environment.NewLine)
            Else
                rtbChat.AppendText("Welcome to Cybersecurity Chatbot!" & Environment.NewLine)
            End If

        Catch ex As Exception
            MessageBox.Show("Welcome resources missing: " & ex.Message)
        End Try

    End Sub

    Private Sub LoadTasks()

        dgvTasks.DataSource = db.GetTasks()

    End Sub

    Private Sub btnAddTask_Click(sender As Object, e As EventArgs) Handles btnAddTask.Click

        If txtTitle.Text.Trim = "" Then
            MessageBox.Show("Please enter a task title.")
            Return
        End If

        db.AddTask(
    txtTitle.Text,
    txtDescription.Text,
    dtpReminder.Value.Date)

        AddActivity("Task added: " & txtTitle.Text)

        MessageBox.Show("Task added successfully!")

        txtTitle.Clear()
        txtDescription.Clear()

        LoadTasks()

    End Sub

    Private Sub btnViewTasks_Click(sender As Object, e As EventArgs) Handles btnViewTasks.Click

        LoadTasks()

        AddActivity("User viewed all tasks.")

    End Sub

    Private Sub btnDeleteTask_Click(sender As Object, e As EventArgs) Handles btnDeleteTask.Click

        If dgvTasks.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a task.")
            Return
        End If

        Dim id As Integer =
            Convert.ToInt32(dgvTasks.SelectedRows(0).Cells("TaskID").Value)

        db.DeleteTask(id)

        AddActivity("Task deleted: ID " & id)

        MessageBox.Show("Task deleted.")

        LoadTasks()

    End Sub

    Private Sub btnCompleteTask_Click(sender As Object, e As EventArgs) Handles btnCompleteTask.Click

        If dgvTasks.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a task.")
            Return
        End If

        Dim id As Integer =
            Convert.ToInt32(dgvTasks.SelectedRows(0).Cells("TaskID").Value)

        db.CompleteTask(id)

        AddActivity("Task completed: ID " & id)

        MessageBox.Show("Task marked as completed.")

        LoadTasks()

    End Sub

    Private Sub CheckReminders()

        Dim table As DataTable = db.GetTasks()

        For Each row As DataRow In table.Rows

            If Not CBool(row("IsCompleted")) Then

                Dim reminderDate As Date = CDate(row("ReminderDate"))

                If reminderDate.Date <= Date.Today Then

                    MessageBox.Show(
                    "Reminder!" & Environment.NewLine &
                    "Task: " & row("Title").ToString() &
                    Environment.NewLine &
                    "Description: " & row("Description").ToString(),
                    "Cybersecurity Reminder",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information)

                    AddActivity("Reminder shown for: " &
                            row("Title").ToString())

                End If

            End If

        Next

    End Sub

    Private Sub rtbChat_TextChanged(sender As Object, e As EventArgs) Handles rtbChat.TextChanged

    End Sub

    Private Function GetIntent(input As String) As String

        input = input.ToLower()

        '======================
        ' Greetings
        '======================
        If input = "hi" Or
   input = "hello" Or
   input = "hey" Or
   input = "good morning" Or
   input = "good afternoon" Or
   input = "good evening" Then

            Return "GREETING"

        ElseIf input.Contains("how are you") Or
   input.Contains("how's it going") Or
   input.Contains("how are things") Then

            Return "HOWAREYOU"

            '======================
            ' Farewell
            '======================
        ElseIf input.Contains("bye") Or
           input.Contains("goodbye") Or
           input.Contains("exit") Or
           input.Contains("quit") Then

            Return "EXIT"

            '======================
            ' Quiz
            '======================
        ElseIf input.Contains("quiz") Or
           input.Contains("game") Or
           input.Contains("play") Or
           input.Contains("test me") Or
           input.Contains("start quiz") Then

            Return "QUIZ"

            '======================
            ' Activity Log
            '======================
        ElseIf input.Contains("activity") Or
           input.Contains("log") Or
           input.Contains("what have you done") Or
           input.Contains("show history") Then

            Return "LOG"

            '======================
            ' Reminder
            '======================
        ElseIf input.Contains("remind") Or
           input.Contains("tomorrow") Or
           input.Contains("today") Or
           input.Contains("next week") Or
           input.Contains("next month") Or
           input.Contains("in 3 days") Or
           input.Contains("in 7 days") Then

            Return "REMINDER"

            '======================
            ' 2FA
            '======================
        ElseIf input.Contains("2fa") Or
           input.Contains("two factor") Or
           input.Contains("authentication") Or
           input.Contains("verification") Then

            Return "2FA"

            '======================
            ' Task
            '======================
        ElseIf input.Contains("task") Or
        input.Contains("add task") Or
        input.Contains("create task") Or
        input.Contains("new task") Or
        input.Contains("remember to") Or
        input.Contains("set reminder") Or
        input.Contains("review privacy settings") Or
        input.Contains("enable two factor") Or
        input.Contains("update password") Then

            Return "TASK"

            '======================
            ' Password
            '======================
        ElseIf input.Contains("password") Or
           input.Contains("passcode") Or
           input.Contains("login") Then

            Return "PASSWORD"

            '======================
            ' Phishing
            '======================
        ElseIf input.Contains("phishing") Or
           input.Contains("fake email") Or
           input.Contains("scam") Or
           input.Contains("fraud") Then

            Return "PHISHING"

            '======================
            ' Privacy
            '======================
        ElseIf input.Contains("privacy") Or
           input.Contains("facebook") Or
           input.Contains("instagram") Or
           input.Contains("data") Then

            Return "PRIVACY"

        ElseIf input.Contains("thanks") Or
   input.Contains("thank you") Then

            Return "THANKS"

        ElseIf input.Contains("who are you") Then

            Return "WHO"

        ElseIf input.Contains("what can you do") Then

            Return "HELP"

        End If

        Return "UNKNOWN"

    End Function

    Private Function GetSentiment(input As String) As String

        input = input.ToLower()

        If input.Contains("worried") Or
       input.Contains("afraid") Or
       input.Contains("scared") Or
       input.Contains("nervous") Then

            Return "NEGATIVE"

        ElseIf input.Contains("happy") Or
           input.Contains("great") Or
           input.Contains("excited") Or
           input.Contains("good") Then

            Return "POSITIVE"

        ElseIf input.Contains("confused") Or
           input.Contains("don't understand") Then

            Return "CONFUSED"

        End If

        Return "NEUTRAL"

    End Function

    Private Function ProcessSmartCommand(input As String) As Boolean

        input = input.ToLower()

        Dim reminder As Date = Date.Today

        If input.Contains("tomorrow") Then
            reminder = Date.Today.AddDays(1)

        ElseIf input.Contains("in 3 days") Then
            reminder = Date.Today.AddDays(3)

        ElseIf input.Contains("in 7 days") Then
            reminder = Date.Today.AddDays(7)

        ElseIf input.Contains("next week") Then
            reminder = Date.Today.AddDays(7)

        ElseIf input.Contains("next month") Then
            reminder = Date.Today.AddMonths(1)

        End If


        'Only continue if user is requesting a task

        If input.Contains("add") Or
       input.Contains("create") Or
       input.Contains("task") Or
       input.Contains("remind") Or
       input.Contains("remember") Then

            If input.Contains("password") Then

                db.AddTask(
                "Update Password",
                "Update your account password.",
                reminder)

                AddActivity("Task created through NLP: Update Password")

                rtbChat.AppendText(
                "Bot: Task added: Update Password." &
                Environment.NewLine)

                LoadTasks()

                Return True

            End If


            If input.Contains("2fa") Or
           input.Contains("two factor") Or
           input.Contains("authentication") Then

                db.AddTask(
                "Enable Two-Factor Authentication",
                "Enable 2FA on your accounts.",
                reminder)

                AddActivity("Task created through NLP: Enable Two-Factor Authentication")

                rtbChat.AppendText(
                "Bot: Task added: Enable Two-Factor Authentication." &
                Environment.NewLine)

                LoadTasks()

                Return True

            End If


            If input.Contains("privacy") Then

                db.AddTask(
                "Review Privacy Settings",
                "Review your account privacy settings.",
                reminder)

                AddActivity("Task created through NLP: Review Privacy Settings")

                rtbChat.AppendText(
                "Bot: Task added: Review Privacy Settings." &
                Environment.NewLine)

                LoadTasks()

                Return True

            End If

        End If

        Return False

    End Function

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        Dim input As String = txtChat.Text.Trim().ToLower()

        If input = "" Then Exit Sub

        rtbChat.AppendText("You: " & txtChat.Text & Environment.NewLine)

        AddActivity("User asked: " & input)

        txtChat.Clear()

        If ProcessSmartCommand(input) Then
            Exit Sub
        End If

        Dim intent As String = GetIntent(input)

        Dim sentiment As String = GetSentiment(input)

        Select Case sentiment

            Case "NEGATIVE"

                rtbChat.AppendText(
        "Bot: I understand your concern. Cybersecurity can seem overwhelming, but I'm here to help." &
        Environment.NewLine)

            Case "POSITIVE"

                rtbChat.AppendText(
        "Bot: I'm glad you're interested in improving your cybersecurity knowledge!" &
        Environment.NewLine)

            Case "CONFUSED"

                rtbChat.AppendText(
        "Bot: Don't worry. I'll explain everything as simply as possible." &
        Environment.NewLine)

        End Select

        Select Case intent

            Case "GREETING"

                rtbChat.AppendText("Bot: Hello! Welcome to the Cybersecurity Awareness Chatbot." &
                               Environment.NewLine)
                AddActivity("Bot greeted the user.")

            Case "HOWAREYOU"

                rtbChat.AppendText(
                "Bot: I'm doing great, thank you for asking! I'm ready to help you stay safe online." &
                Environment.NewLine)

                AddActivity("Bot responded to greeting.")

            Case "PASSWORD"

                rtbChat.AppendText(
    "Bot: Use a strong password with uppercase letters, lowercase letters, numbers and symbols. Avoid using birthdays or common words, and never reuse passwords." &
    Environment.NewLine)

                AddActivity("Password advice given.")

            Case "PHISHING"

                rtbChat.AppendText(
    "Bot: Phishing is a scam where criminals try to steal your personal information using fake emails, websites or messages. Never click suspicious links or share your passwords." &
    Environment.NewLine)

                AddActivity("Bot explained phishing.")

            Case "PRIVACY"

                If input.Contains("facebook") Then

                    rtbChat.AppendText(
        "Bot: Review your Facebook privacy settings, enable two-factor authentication and avoid accepting friend requests from strangers." &
        Environment.NewLine)

                ElseIf input.Contains("instagram") Then

                    rtbChat.AppendText(
        "Bot: Review your Instagram privacy settings and enable two-factor authentication." &
        Environment.NewLine)

                Else

                    rtbChat.AppendText(
        "Bot: Review your privacy settings regularly to protect your personal information." &
        Environment.NewLine)

                End If

                AddActivity("Bot explained privacy.")

            Case "2FA"

                rtbChat.AppendText(
    "Bot: Two-factor authentication (2FA) adds an extra layer of security by requiring a second verification step, making it much harder for attackers to access your account." &
    Environment.NewLine)

                AddActivity("2FA explained.")

            Case "TASK"

                If input.Contains("password") Then

                    rtbChat.AppendText(
        "Bot: Task added: Update Password. Would you like a reminder?" &
        Environment.NewLine)

                ElseIf input.Contains("privacy") Then

                    rtbChat.AppendText(
        "Bot: Task added: Review Privacy Settings. Would you like a reminder?" &
        Environment.NewLine)

                ElseIf input.Contains("2fa") Then

                    rtbChat.AppendText(
        "Bot: Task added: Enable Two-Factor Authentication. Would you like a reminder?" &
        Environment.NewLine)

                Else

                    rtbChat.AppendText(
        "Bot: Use the Task Assistant to manage cybersecurity tasks." &
        Environment.NewLine)

                End If

                AddActivity("Task assistant used.")

            Case "REMINDER"

                rtbChat.AppendText(
    "Bot: Reminder successfully set for your task." &
    Environment.NewLine)

                AddActivity("Reminder created.")

            Case "QUIZ"

                rtbChat.AppendText(
    "Bot: Starting the Cybersecurity Awareness Quiz..." &
    Environment.NewLine)

                AddActivity("Quiz started.")

                Dim quiz As New QuizForm()

                quiz.ShowDialog()

                AddActivity("Quiz completed.")

            Case "LOG"

                AddActivity("User viewed the activity log.")
                MessageBox.Show(ActivityLog.ShowLog(), "Activity Log")

            Case "THANKS"

                rtbChat.AppendText(
                "Bot: You're welcome! Stay safe online." &
                Environment.NewLine)

            Case "WHO"

                rtbChat.AppendText(
                "Bot: I'm your Cybersecurity Awareness Chatbot. I can answer cybersecurity questions, manage tasks, set reminders and test your knowledge." &
                Environment.NewLine)

            Case "HELP"

                rtbChat.AppendText(
                "Bot: I can help with passwords, phishing, privacy, two-factor authentication, reminders, tasks, quizzes and activity logs." &
                Environment.NewLine)

            Case "EXIT"

                rtbChat.AppendText("Bot: Goodbye! Stay safe online." &
                               Environment.NewLine)
                AddActivity("Bot ended the conversation.")

            Case Else

                rtbChat.AppendText("Bot: Sorry, I didn't understand. Could you rephrase?" &
                               Environment.NewLine)
                AddActivity("Bot could not understand the user's request.")

        End Select

    End Sub

    Private Sub btnActivityLog_Click(sender As Object, e As EventArgs) Handles btnActivityLog.Click

        Dim message As String = ""

        For Each item In ActivityLog.GetLogs()
            message &= item & Environment.NewLine
        Next

        If message = "" Then
            message = "No activity recorded yet."
        End If

        MessageBox.Show(message, "Activity Log")

    End Sub

    Private Sub lblHeading_Click(sender As Object, e As EventArgs) Handles lblHeading.Click

    End Sub
End Class