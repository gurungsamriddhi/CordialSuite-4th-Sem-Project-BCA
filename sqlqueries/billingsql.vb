Imports System.Data.SqlClient

Public Class billingSql
    Private connectionString As String = "Data Source=LOCALHOST\SQLEXPRESS;AttachDbFilename=E:\CordialSuiteDB.mdf;Integrated Security=True;"

    ' Method to execute non-query (INSERT, UPDATE, DELETE) for billing
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

    Public Sub ExecuteNonQueryWithParameters(query As String, parameters As List(Of SqlParameter))
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddRange(parameters.ToArray())
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Function ExecuteQueryWithParameters(query As String, parameters As List(Of SqlParameter)) As DataTable
        Dim dt As New DataTable()

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddRange(parameters.ToArray())
                Dim adapter As New SqlDataAdapter(cmd)
                adapter.Fill(dt)
            End Using
        End Using

        Return dt
    End Function

    Public Sub ExecuteQuery(query As String, dgv As DataGridView)
        Using connection As New SqlConnection(connectionString)
            Dim command As New SqlCommand(query, connection)
            Dim adapter As New SqlDataAdapter(command)
            Dim table As New DataTable()

            Try
                connection.Open()
                adapter.Fill(table)
                dgv.DataSource = table
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Function ExecuteScalarWithParameters(query As String, parameters As List(Of SqlParameter)) As Object
        Dim result As Object = Nothing
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                For Each param As SqlParameter In parameters
                    command.Parameters.Add(param)
                Next
                connection.Open()
                result = command.ExecuteScalar()
            End Using
        End Using
        Return result
    End Function

End Class