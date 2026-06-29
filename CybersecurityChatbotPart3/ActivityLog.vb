Public Class ActivityLog

    Private Shared Logs As New List(Of String)

    Public Shared Sub AddLog(action As String)

        Logs.Add(DateTime.Now.ToString("g") & " - " & action)

        If Logs.Count > 10 Then
            Logs.RemoveAt(0)
        End If

    End Sub

    Public Shared Function GetLogs() As List(Of String)

        Return Logs

    End Function

    Public Shared Function ShowLog() As String

        If Logs.Count = 0 Then
            Return "No activity recorded yet."
        End If

        Return String.Join(Environment.NewLine, Logs)

    End Function

End Class