Imports MySql.Data.MySqlClient
Imports System.Data

Public Class DatabaseHelper

    Private ReadOnly connectionString As String =
        "server=localhost;user=root;password=Vwpolo1.6;database=CybersecurityChatbotDB;"

    '==========================
    'ADD TASK
    '==========================
    Public Sub AddTask(title As String, description As String, reminder As Date)

        Using conn As New MySqlConnection(connectionString)

            conn.Open()

            Dim sql As String =
                "INSERT INTO Tasks (Title, Description, ReminderDate, IsCompleted)
                 VALUES (@title,@description,@reminder,FALSE)"

            Using cmd As New MySqlCommand(sql, conn)

                cmd.Parameters.AddWithValue("@title", title)
                cmd.Parameters.AddWithValue("@description", description)
                cmd.Parameters.AddWithValue("@reminder", reminder)

                cmd.ExecuteNonQuery()

            End Using

        End Using

    End Sub

    '==========================
    'GET TASKS
    '==========================
    Public Function GetTasks() As DataTable

        Dim table As New DataTable()

        Using conn As New MySqlConnection(connectionString)

            conn.Open()

            Dim sql As String =
                "SELECT TaskID,
                        Title,
                        Description,
                        ReminderDate,
                        IsCompleted
                 FROM Tasks"

            Dim adapter As New MySqlDataAdapter(sql, conn)

            adapter.Fill(table)

        End Using

        Return table

    End Function

    '==========================
    'DELETE TASK
    '==========================
    Public Sub DeleteTask(taskID As Integer)

        Using conn As New MySqlConnection(connectionString)

            conn.Open()

            Dim sql As String =
                "DELETE FROM Tasks WHERE TaskID=@id"

            Using cmd As New MySqlCommand(sql, conn)

                cmd.Parameters.AddWithValue("@id", taskID)

                cmd.ExecuteNonQuery()

            End Using

        End Using

    End Sub

    '==========================
    'COMPLETE TASK
    '==========================
    Public Sub CompleteTask(taskID As Integer)

        Using conn As New MySqlConnection(connectionString)

            conn.Open()

            Dim sql As String =
                "UPDATE Tasks
                 SET IsCompleted=TRUE
                 WHERE TaskID=@id"

            Using cmd As New MySqlCommand(sql, conn)

                cmd.Parameters.AddWithValue("@id", taskID)

                cmd.ExecuteNonQuery()

            End Using

        End Using

    End Sub

End Class