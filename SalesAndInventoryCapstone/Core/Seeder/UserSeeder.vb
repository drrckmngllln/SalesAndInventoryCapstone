Imports MySql.Data.MySqlClient

Public Class UserSeeder
    Public Shared Sub RoleSeeder()
        da = New MySqlDataAdapter("select Id from users", con)
        ds = New DataSet
        da.Fill(ds, "users")

        If ds.Tables(0).Rows.Count <= 0 Then
            Try
                Dim result As Integer = 0

                result += CreateUser("Admin", "Admin", "admin", "password")
                result += CreateUser("Sales", "Sales", "sales", "password")
                result += CreateUser("Inventory", "Inventory", "inventory", "password")

            Catch ex As Exception
                MsgBox("An error has occurred" & ex.Message)
            Finally
                con.Close()
            End Try
        End If
    End Sub

    Public Shared Function CreateUser(lastName As String, firstName As String, username As String, password As String) As Integer
        Dim hashedPassword As String = HashPassword(password)

        con.Open()
        cmd = New MySqlCommand("insert into users(LastName, FirstName, Username, Password) values(@1, @2, @3, @4)", con)
        cmd.Parameters.AddWithValue("@1", lastName)
        cmd.Parameters.AddWithValue("@2", firstName)
        cmd.Parameters.AddWithValue("@3", username)
        cmd.Parameters.AddWithValue("@4", hashedPassword)

        Dim result As Integer = cmd.ExecuteNonQuery()
        con.Close()
        Return result
    End Function

    Public Shared Function HashPassword(password As String) As String
        Return BCrypt.Net.BCrypt.HashPassword(password)
    End Function
End Class
