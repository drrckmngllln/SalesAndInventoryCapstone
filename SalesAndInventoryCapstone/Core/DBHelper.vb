Imports MySql.Data.MySqlClient

Public Class DBHelper
    ' 📥 CREATE
    Public Function Create(tableName As String, data As Dictionary(Of String, Object)) As Boolean
        Try
            Dim columns As String = String.Join(", ", data.Keys)
            Dim parameters As String = String.Join(", ", data.Keys.Select(Function(k) "@" & k))
            Dim sql As String = $"INSERT INTO {tableName} ({columns}) VALUES ({parameters})"

            cmd = New MySqlCommand(sql, con)
            For Each kvp In data
                cmd.Parameters.AddWithValue("@" & kvp.Key, kvp.Value)
            Next

            con.Open()
            Dim result = cmd.ExecuteNonQuery()
            con.Close()

            Return result > 0
        Catch ex As Exception
            MsgBox("an error has occured: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

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
    Public Function Update(tableName As String, data As Dictionary(Of String, Object), whereClause As String) As Boolean
        Try
            Dim setClause As String = String.Join(", ", data.Keys.Select(Function(k) $"{k} = @{k}"))
            Dim sql As String = $"UPDATE {tableName} SET {setClause} WHERE {whereClause}"

            cmd = New MySqlCommand(sql, con)
            For Each kvp In data
                cmd.Parameters.AddWithValue("@" & kvp.Key, kvp.Value)
            Next

            con.Open()
            Dim result = cmd.ExecuteNonQuery()
            con.Close()

            Return result > 0
        Catch ex As Exception
            MsgBox($"an error has occurred: {ex.Message}", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    ' ❌ DELETE
    Public Function Delete(tableName As String, whereClause As String) As Boolean
        Try
            Dim sql As String = $"DELETE FROM {tableName} WHERE {whereClause}"
            cmd = New MySqlCommand(sql, con)

            con.Open()
            Dim result = cmd.ExecuteNonQuery()
            con.Close()

            Return result > 0
        Catch ex As Exception
            MsgBox($"an error has occurred: {ex.Message}", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

End Class
