Public Class QuizForm

    Private Questions As New List(Of Question)

    Private CurrentQuestion As Integer = 0

    Private Score As Integer = 0

    '=========================
    'LOAD QUESTIONS
    '=========================
    Private Sub LoadQuestions()

        Questions.Clear()

        Questions.Add(New Question("What should you do if you receive an email asking for your password?",
                               "Reply with your password",
                               "Delete the email",
                               "Report it as phishing",
                               "Ignore it",
                               "C",
                               "Reporting phishing emails helps stop scams."))

        Questions.Add(New Question("What makes a strong password?",
                               "123456",
                               "Your birthday",
                               "A mix of letters, numbers and symbols",
                               "password",
                               "C",
                               "Strong passwords are difficult to guess."))

        Questions.Add(New Question("What does 2FA stand for?",
                               "Two-Factor Authentication",
                               "Two File Access",
                               "Two Fast Accounts",
                               "Two Free Apps",
                               "A",
                               "2FA adds another layer of security."))

        Questions.Add(New Question("Which website is safer?",
                               "http://example.com",
                               "https://example.com",
                               "Both are the same",
                               "Neither",
                               "B",
                               "HTTPS encrypts your connection."))

        Questions.Add(New Question("True or False: You should use the same password everywhere.",
                               "True",
                               "False",
                               "",
                               "",
                               "B",
                               "Each account should have a unique password."))

        Questions.Add(New Question("What should you do before clicking a link?",
                               "Click immediately",
                               "Check where it leads",
                               "Forward it",
                               "Ignore everything",
                               "B",
                               "Always verify links before opening them."))

        Questions.Add(New Question("What is phishing?",
                               "A fishing hobby",
                               "A cyber scam",
                               "A browser",
                               "An antivirus",
                               "B",
                               "Phishing tricks people into revealing personal information."))

        Questions.Add(New Question("Which one is personal information?",
                               "Your favourite colour",
                               "Your password",
                               "Today's weather",
                               "The time",
                               "B",
                               "Never share your passwords."))

        Questions.Add(New Question("What should you do if your account is hacked?",
                               "Ignore it",
                               "Change your password immediately",
                               "Create another email",
                               "Delete your computer",
                               "B",
                               "Changing your password is the first step."))

        Questions.Add(New Question("What software helps protect against malware?",
                               "Calculator",
                               "Antivirus",
                               "Paint",
                               "Notepad",
                               "B",
                               "Antivirus software helps detect malware."))

        Questions.Add(New Question("What is social engineering?",
                           "A programming language",
                           "Tricking people into giving information",
                           "A type of firewall",
                           "A browser setting",
                           "B",
                           "Social engineering manipulates people into revealing sensitive info."))

        Questions.Add(New Question("What should you do if a website looks suspicious?",
                                   "Enter your details",
                                   "Close it immediately",
                                   "Bookmark it",
                                   "Refresh repeatedly",
                                   "B",
                                   "Suspicious websites should be avoided and closed immediately."))

    End Sub

    '=========================
    'FORM LOAD
    '=========================
    Private Sub QuizForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadQuestions()

        LoadQuestion()

    End Sub

    '=========================
    'DISPLAY QUESTION
    '=========================
    Private Sub LoadQuestion()

        lblQuestion.Text = Questions(CurrentQuestion).QuestionText

        rbA.Text = Questions(CurrentQuestion).OptionA
        rbB.Text = Questions(CurrentQuestion).OptionB
        rbC.Text = Questions(CurrentQuestion).OptionC
        rbD.Text = Questions(CurrentQuestion).OptionD

        rbA.Checked = False
        rbB.Checked = False
        rbC.Checked = False
        rbD.Checked = False

        lblScore.Text = "Score: " & Score

    End Sub

    '=========================
    'CHECK ANSWER
    '=========================
    Private Sub CheckAnswer()

        Dim answer As String = ""

        If rbA.Checked Then answer = "A"
        If rbB.Checked Then answer = "B"
        If rbC.Checked Then answer = "C"
        If rbD.Checked Then answer = "D"

        If answer = Questions(CurrentQuestion).CorrectAnswer Then

            Score += 1

            MessageBox.Show(
                "Correct!" &
                Environment.NewLine &
                Questions(CurrentQuestion).Explanation)

        Else

            MessageBox.Show(
                "Incorrect!" &
                Environment.NewLine &
                Questions(CurrentQuestion).Explanation)

        End If

    End Sub

    '=========================
    'NEXT BUTTON
    '=========================
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        CheckAnswer()

        CurrentQuestion += 1

        If CurrentQuestion >= Questions.Count Then

            ActivityLog.AddLog("Quiz completed. Score: " & Score & "/" & Questions.Count)

            Dim feedback As String

            If Score >= 9 Then

                feedback = "Excellent! You're a cybersecurity expert!"

            ElseIf Score >= 7 Then

                feedback = "Great job! You have good cybersecurity knowledge."

            ElseIf Score >= 5 Then

                feedback = "Good effort! Keep practising."

            Else

                feedback = "Keep learning to stay safe online."

            End If

            MessageBox.Show(
    "Quiz Complete!" &
    Environment.NewLine &
    "Final Score: " & Score & "/" & Questions.Count &
    Environment.NewLine &
    feedback)

            Me.Close()

            Exit Sub

        End If

        LoadQuestion()

    End Sub

End Class