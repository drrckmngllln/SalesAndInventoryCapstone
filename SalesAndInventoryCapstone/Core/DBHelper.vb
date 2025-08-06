Imports System.Reflection
Imports MySql.Data.MySqlClient

Public Class DBHelper
    ' 📥 CREATE
    Public Shared Async Function CreateAsync(Of T)(tableName As String, entity As T) As Task(Of Boolean)
        Try
            ' Get all public properties with both getter and setter (exclude complex/navigational properties)
            Dim properties = GetType(T).GetProperties(BindingFlags.Public Or BindingFlags.Instance) _
            .Where(Function(p) p.CanRead AndAlso p.GetValue(entity, Nothing) IsNot Nothing)

            Dim columns As String = String.Join(", ", properties.Select(Function(p) p.Name))
            Dim parameters As String = String.Join(", ", properties.Select(Function(p) "@" & p.Name))
            Dim sql As String = $"INSERT INTO {tableName} ({columns}) VALUES ({parameters})"

            Using con As New MySqlConnection(Connstring)
                Await con.OpenAsync()

                Using cmd As New MySqlCommand(sql, con)
                    For Each prop In properties
                        cmd.Parameters.AddWithValue("@" & prop.Name, prop.GetValue(entity))
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
    Public Shared Async Function Fetch(query As String) As Task(Of DataSet)
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
    Public Shared Async Function UpdateAsync(Of T)(tableName As String, entity As T, whereClause As String) As Task(Of Boolean)
        Try
            ' Get all readable properties (filtering nulls and potentially keys like Id)
            Dim properties = GetType(T).GetProperties(BindingFlags.Public Or BindingFlags.Instance) _
            .Where(Function(p) p.CanRead AndAlso p.GetValue(entity) IsNot Nothing)

            ' Build SET clause
            Dim setClause As String = String.Join(", ", properties.Select(Function(p) $"{p.Name} = @{p.Name}"))
            Dim sql As String = $"UPDATE {tableName} SET {setClause} WHERE {whereClause}"

            Using con As New MySqlConnection(Connstring)
                Await con.OpenAsync()

                Using cmd As New MySqlCommand(sql, con)
                    For Each prop In properties
                        cmd.Parameters.AddWithValue("@" & prop.Name, prop.GetValue(entity))
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

    ' ❌ DELETE
    Public Shared Async Function DeleteAsync(tableName As String, id As Object, Optional keyName As String = "Id") As Task(Of Boolean)
        Try
            If String.IsNullOrWhiteSpace(tableName) Then
                Throw New ArgumentException("Table name must be specified.")
            End If

            If String.IsNullOrWhiteSpace(keyName) Then
                Throw New ArgumentException("Key name must be specified.")
            End If

            Dim sql = $"DELETE FROM {tableName} WHERE {keyName} = @{keyName}"

            Using con As New MySqlConnection(Connstring)
                Await con.OpenAsync()

                Using cmd As New MySqlCommand(sql, con)
                    cmd.Parameters.AddWithValue("@" & keyName, id)

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
