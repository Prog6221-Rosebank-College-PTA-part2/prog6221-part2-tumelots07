Public Class Question

    Public Property QuestionText As String

    Public Property OptionA As String

    Public Property OptionB As String

    Public Property OptionC As String

    Public Property OptionD As String

    Public Property CorrectAnswer As String

    Public Property Explanation As String

    Public Sub New(question As String,
                   a As String,
                   b As String,
                   c As String,
                   d As String,
                   answer As String,
                   explanation As String)

        QuestionText = question

        OptionA = a
        OptionB = b
        OptionC = c
        OptionD = d

        CorrectAnswer = answer

        explanation = explanation

    End Sub

End Class