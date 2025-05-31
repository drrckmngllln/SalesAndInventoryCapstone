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

    ' 📥 CREATE
    Public Sub Create(tableName As String, data As Dictionary(Of String, Object))
        Dim columns As String = String.Join(", ", data.Keys)
        Dim parameters As String = String.Join(", ", data.Keys.Select(Function(k) "@" & k))
        Dim sql As String = $"INSERT INTO {tableName} ({columns}) VALUES ({parameters})"

        cmd = New MySqlCommand(sql, con)
        For Each kvp In data
            cmd.Parameters.AddWithValue("@" & kvp.Key, kvp.Value)
        Next

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    ' 📄 READ
    Public Function Fetch(query As String) As DataSet
        Dim ds As New DataSet()

        Using con As New MySqlConnection(Connstring)
            Dim da As New MySqlDataAdapter(query, con)
            da.Fill(ds)
        End Using

        Return ds
    End Function

    ' ✏️ UPDATE
    Public Sub Update(tableName As String, data As Dictionary(Of String, Object), whereClause As String)
        Dim setClause As String = String.Join(", ", data.Keys.Select(Function(k) $"{k} = @{k}"))
        Dim sql As String = $"UPDATE {tableName} SET {setClause} WHERE {whereClause}"

        cmd = New MySqlCommand(sql, con)
        For Each kvp In data
            cmd.Parameters.AddWithValue("@" & kvp.Key, kvp.Value)
        Next

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    ' ❌ DELETE
    Public Sub Delete(tableName As String, whereClause As String)
        Dim sql As String = $"DELETE FROM {tableName} WHERE {whereClause}"
        cmd = New MySqlCommand(sql, con)

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

End Module
