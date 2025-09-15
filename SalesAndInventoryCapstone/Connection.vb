Imports System.IO
Imports MySql.Data.MySqlClient

Module Connection
    'Public Connstring As String = "Server=localhost;Port=3307;User Id=root;password=password;database=salesinventory"
    Public Connstring As String = "Server=localhost;Port=3306;User Id=root;password=password;database=salesinventory"

    Public con As New MySqlConnection(Connstring)

    Public da As New MySqlDataAdapter
    Public ds As New DataSet
    Public cmd As New MySqlCommand

    Public Function IsLoggedIn() As Boolean
        Dim path As String = "session.txt"
        Return File.Exists(path)
    End Function

    Public Sub Logout()
        If MsgBox("Are you sure you want to log out?", MsgBoxStyle.YesNo, "Logout Confirmation") = MsgBoxResult.Yes Then
            If File.Exists("session.txt") Then
                File.Delete("session.txt")
            End If
            Application.Restart()
        End If
    End Sub

    Public Sub MigrateDatabase()
        Dim path As String = "/dbSchema.sql"
        If Not File.Exists(path) Then
            MsgBox("Database schema file not found.", MsgBoxStyle.Critical, "Error")
            Application.Exit()
        End If

        Dim sqlScript As String = File.ReadAllText(path)

        Using connection As New MySqlConnection(Connstring)
            Try
                connection.Open()
                Dim command As New MySqlCommand(sqlScript, connection)
                command.ExecuteNonQuery()
                MsgBox("Database migration completed successfully.", MsgBoxStyle.Information, "Migration Success")
            Catch ex As Exception
                MsgBox($"An error occurred during migration: {ex.Message}", MsgBoxStyle.Critical, "Migration Error")
            Finally
                connection.Close()
            End Try
        End Using
    End Sub
End Module
