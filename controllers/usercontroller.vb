Imports System.Data.SqlClient

Public Class UserController
    Private ReadOnly ConnectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CordialSuiteDB.mdf;Integrated Security=True;"

    Public Function RegisterUser(user As User) As Boolean
        Dim query As String = "INSERT INTO Userstbl (UFirst_Name, ULast_Name, U_Address, U_PhoneNumber,U_DOB, U_Gender, User_Type, Username, Password) " &
                              "VALUES (@FirstName, @LastName, @Address, @PhoneNumber,@DOB, @Gender, @UserType, @Username, @Password)"

        Using connection As New SqlConnection(ConnectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@FirstName", user.FirstName)
                command.Parameters.AddWithValue("@LastName", user.LastName)
                command.Parameters.AddWithValue("@Address", user.Address)
                command.Parameters.AddWithValue("@PhoneNumber", user.DateOfBirth)
                command.Parameters.AddWithValue("@DOB", user.PhoneNumber)
                command.Parameters.AddWithValue("@Gender", user.Gender)
                command.Parameters.AddWithValue("@UserType", user.UserType)
                command.Parameters.AddWithValue("@Username", user.Username)
                command.Parameters.AddWithValue("@Password", user.Password)

                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                Return rowsAffected > 0
            End Using
        End Using
    End Function

    Public Function AuthenticateUser(username As String, password As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Userstbl WHERE Username = @Username AND Password = @Password"

        Using connection As New SqlConnection(ConnectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)

                connection.Open()
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function
End Class
