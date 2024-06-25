Imports System.Data.SqlClient

Public Class userssql
    Private connectionString As String = "Data Source=LOCALHOST\SQLEXPRESS;AttachDbFilename=E:\CordialSuiteDB.mdf;Integrated Security=True;"

    ' Method to execute non-query (INSERT, UPDATE, DELETE)
    Public Sub ExecuteNonQuery(query As String)
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error executing query: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Method to execute SELECT query and return results
    Public Sub ExecuteQuery(query As String, datagridview As DataGridView)
        Dim dataTable As New DataTable()

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        dataTable.Load(reader)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error executing query: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        datagridview.DataSource = dataTable


    End Sub


    Public Sub SearchUsers(query As String, username As String, dataGridView As DataGridView)
        Dim dataTable As New DataTable()

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Username", "%" & username & "%")
                    Using reader As SqlDataReader = command.ExecuteReader()
                        dataTable.Load(reader)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error executing query: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        dataGridView.DataSource = dataTable
    End Sub


    Public Sub ExecuteNonQueryWithParameters(query As String, parameters As List(Of SqlParameter))
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddRange(parameters.ToArray())
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function ExecuteScalarWithParameters(query As String, parameters As List(Of SqlParameter)) As Object
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddRange(parameters.ToArray())
                connection.Open()
                Return command.ExecuteScalar()
            End Using
        End Using
    End Function

End Class

