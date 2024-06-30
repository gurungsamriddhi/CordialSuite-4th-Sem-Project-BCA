Imports System.Data.SqlClient

Public Class reservationsSql
    Private connectionString As String = "Data Source=LOCALHOST\SQLEXPRESS;AttachDbFilename=E:\CordialSuiteDB.mdf;Integrated Security=True;"

    ' Method to execute non-query (INSERT, UPDATE, DELETE) for reservations
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

    ' Method to execute SELECT query and return results for reservations
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

    ' Method to search reservations by guest name or room number
    Public Sub SearchReservations(query As String, keyword As String, dataGridView As DataGridView)
        Dim dataTable As New DataTable()

        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@keyword", "%" & keyword & "%")
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

    ' Method to execute non-query (INSERT, UPDATE, DELETE) with parameters for reservations
    Public Sub ExecuteNonQueryWithParameters(query As String, parameters As List(Of SqlParameter))
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddRange(parameters.ToArray())
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Method to check if a reservation exists for a given guest ID and room ID
    Public Function ReservationExists(guestID As Integer, roomID As Integer) As Boolean
        Dim exists As Boolean = False

        Using conn As New SqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT COUNT(*) FROM reservations WHERE GuestID = @GuestID AND RoomID = @RoomID"

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@GuestID", guestID)
                cmd.Parameters.AddWithValue("@RoomID", roomID)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If count > 0 Then
                    exists = True
                End If
            End Using
        End Using

        Return exists
    End Function

    ' Method to execute a scalar query and return a single value for reservations
    Public Function ExecuteScalar(query As String) As Integer
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Return Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using
    End Function


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
