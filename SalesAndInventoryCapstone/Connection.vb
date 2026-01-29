Imports System.IO
Imports System.Linq
Imports MySql.Data.MySqlClient

Module Connection
    Public Connstring As String = "Server=localhost;Port=3307;User Id=root;password=password;database=salesinventory"
    'Public Connstring As String = "Server=localhost;Port=3306;User Id=root;password=password;database=salesinventory"

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
        Dim schemaPath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dbSchema.sql")
        If Not File.Exists(schemaPath) Then
            MsgBox("Database schema file not found.", MsgBoxStyle.Critical, "Error")
            Application.Exit()
        End If

        Dim sqlScript As String = File.ReadAllText(schemaPath)

        Using connection As New MySqlConnection(Connstring)
            Try
                EnsureDatabaseExists()

                If DatabaseHasRequiredTables() Then
                    ' Schema already present; do not overwrite or alter existing data.
                    Exit Sub
                End If

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

    Private Sub EnsureDatabaseExists()
        Dim builder As New MySqlConnectionStringBuilder(Connstring)
        Dim databaseName As String = builder.Database
        builder.Database = ""

        Using serverConnection As New MySqlConnection(builder.ConnectionString)
            serverConnection.Open()

            Using cmd As New MySqlCommand("SELECT SCHEMA_NAME FROM information_schema.SCHEMATA WHERE SCHEMA_NAME = @db", serverConnection)
                cmd.Parameters.AddWithValue("@db", databaseName)
                Dim exists = cmd.ExecuteScalar()

                If exists Is Nothing Then
                    Using createCmd As New MySqlCommand($"CREATE DATABASE `{databaseName}`", serverConnection)
                        createCmd.ExecuteNonQuery()
                    End Using
                End If
            End Using
        End Using
    End Sub

    Private Function DatabaseHasRequiredTables() As Boolean
        Dim builder As New MySqlConnectionStringBuilder(Connstring)
        Dim databaseName As String = builder.Database
        builder.Database = ""

        Using serverConnection As New MySqlConnection(builder.ConnectionString)
            serverConnection.Open()

            Dim requiredTables As String() = {"categories", "products", "inventories", "sales", "saleitem", "users", "roles", "user_role", "notifications"}

            Using cmd As New MySqlCommand("SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = @db AND table_name IN (" &
                                         String.Join(", ", requiredTables.Select(Function(t) $"'{t}'")) & ")", serverConnection)
                cmd.Parameters.AddWithValue("@db", databaseName)
                Dim countObj = cmd.ExecuteScalar()
                Dim count As Integer = If(countObj IsNot Nothing, Convert.ToInt32(countObj), 0)
                Return count = requiredTables.Length
            End Using
        End Using
    End Function
End Module

