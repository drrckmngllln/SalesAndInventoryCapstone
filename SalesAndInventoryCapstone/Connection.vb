Imports System.IO
Imports MySql.Data.MySqlClient

Module Connection
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


End Module
