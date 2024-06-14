Imports System.Data.SqlClient

Module sql
    Public Class sqlconnector
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
        Public Function ExecuteQuery(query As String) As DataTable
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

            Return dataTable
        End Function


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
    End Class
End Module
