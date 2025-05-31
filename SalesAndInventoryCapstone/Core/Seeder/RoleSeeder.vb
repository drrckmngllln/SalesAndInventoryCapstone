Imports MySql.Data.MySqlClient

Public Class RoleSeeder

    'This is a function that seeds the database with default roles
    Public Shared Sub SeedRoles()
        Dim da = New MySqlDataAdapter("select Id from roles limit 10", con)
        Dim ds = New DataSet
        da.Fill(ds, "roles")

        If ds.Tables(0).Rows.Count <= 0 Then
            Try
                Dim result As Integer = 0

                result += CreateRole("Admin")
                result += CreateRole("Sales")
                result += CreateRole("Inventory")

                If result > 0 Then
                    MsgBox($"{result} roles created successfully.")
                End If

            Catch ex As Exception
                MsgBox("An error has occured" & ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    'This is a function that creates a role in the database
    Public Shared Function CreateRole(roleName As String) As Integer
        con.Open()
        Dim cmd = New MySqlCommand("insert into roles(Name) values(@1)", con)
        cmd.Parameters.AddWithValue("@1", roleName)
        Dim result As Integer = cmd.ExecuteNonQuery()
        con.Close()
        Return result
    End Function
End Class
