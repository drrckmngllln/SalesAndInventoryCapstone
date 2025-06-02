Imports MySql.Data.MySqlClient

Public Class DBHelper
    ' 📥 CREATE
    Public Async Function CreateAsync(tableName As String, data As Dictionary(Of String, Object)) As Task(Of Boolean)
        Try
            Dim columns As String = String.Join(", ", data.Keys)
            Dim parameters As String = String.Join(", ", data.Keys.Select(Function(k) "@" & k))
            Dim sql As String = $"INSERT INTO {tableName} ({columns}) VALUES ({parameters})"

            Using con As New MySqlConnection(Connstring)
                Await con.OpenAsync()

                Using cmd As New MySqlCommand(sql, con)
                    For Each kvp In data
                        cmd.Parameters.AddWithValue("@" & kvp.Key, kvp.Value)
                    Next

                    Dim result As Integer = Await cmd.ExecuteNonQueryAsync()
                    Return result > 0
                End Using
            End Using
        Catch ex As Exception
            MsgBox("An error has occurred: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    ' 📄 READ
    Public Async Function Fetch(query As String) As Task(Of DataSet)
        Dim ds As New DataSet()

        Using con As New MySqlConnection(Connstring)
            Await con.OpenAsync()

            Using cmd As New MySqlCommand(query, con)
                Using reader As MySqlDataReader = Await cmd.ExecuteReaderAsync()
                    Dim dt As New DataTable()
                    dt.Load(reader)
                    ds.Tables.Add(dt)
                End Using
            End Using
        End Using

        Return ds
    End Function

    ' ✏️ UPDATE
    Public Async Function UpdateAsync(tableName As String, data As Dictionary(Of String, Object), whereClause As String) As Task(Of Boolean)
        Try
            Dim setClause As String = String.Join(", ", data.Keys.Select(Function(k) $"{k} = @{k}"))
            Dim sql As String = $"UPDATE {tableName} SET {setClause} WHERE {whereClause}"

            Using con As New MySqlConnection(Connstring)
                Await con.OpenAsync()

                Using cmd As New MySqlCommand(sql, con)
                    For Each kvp In data
                        cmd.Parameters.AddWithValue("@" & kvp.Key, kvp.Value)
                    Next

                    Dim result As Integer = Await cmd.ExecuteNonQueryAsync()
                    Return result > 0
                End Using
            End Using
        Catch ex As Exception
            MsgBox($"An error has occurred: {ex.Message}", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function

    ' ❌ DELETE
    Public Async Function DeleteAsync(tableName As String, whereClause As String) As Task(Of Boolean)
        Try
            Dim sql As String = $"DELETE FROM {tableName} WHERE {whereClause}"

            Using con As New MySqlConnection(Connstring)
                Await con.OpenAsync()

                Using cmd As New MySqlCommand(sql, con)
                    Dim result As Integer = Await cmd.ExecuteNonQueryAsync()
                    Return result > 0
                End Using
            End Using
        Catch ex As Exception
            MsgBox($"An error has occurred: {ex.Message}", MsgBoxStyle.Critical, "Error")
            Return False
        End Try
    End Function


End Class
