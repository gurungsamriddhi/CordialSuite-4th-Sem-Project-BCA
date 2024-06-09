
Imports System.Diagnostics.Eventing.Reader
Imports System.IO

Public Interface IUserService
    Sub AddUser(user As User)  'bydefault all the functions and sub procedures becomes public also only contains declarations 
    Function GetUserById(userId As Integer) As User
    Function GetAllUsers() As List(Of User)
    Sub UpdateUser(user As User)
    Function getuserbyusername(username As String) As User
    Sub DeleteUser(userId As Integer)
    Function ValidateUsername(username As String) As Boolean

    Function authenticateuser(username As String, password As String) As String
    Function getuserstable() As DataTable
End Interface

Public Class UserService
    Implements IUserService

    Private ReadOnly _context As UserContext

    Public Sub New()
        Dim dbContext As New UserContext()
        _context = dbContext
    End Sub

    Public Sub AddUser(user As User) Implements IUserService.AddUser
        ' Check if a user with the same username already exists
        If _context.Users.Any(Function(u) u.Username = user.Username) Then
            ' Handle the case where the username is already taken
            ' For example, throw an exception or return an error message
            MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        ' If username is unique, proceed with adding the user
        _context.AddEntity(user)
    End Sub


    Public Function GetUserById(userId As Integer) As User Implements IUserService.GetUserById
        Return _context.Users.Find(userId)
    End Function

    Public Function GetAllUsers() As List(Of User) Implements IUserService.GetAllUsers
        Return _context.Users.ToList()
    End Function

    Public Sub UpdateUser(user As User) Implements IUserService.UpdateUser
        _context.UpdateEntity(user)
    End Sub

    Public Sub DeleteUser(userId As Integer) Implements IUserService.DeleteUser
        Dim user = _context.Users.Find(userId)
        If user IsNot Nothing Then
            _context.DeleteEntity(user)
        End If
    End Sub
    Public Function getuserbyusername(username As String) As User Implements IUserService.getuserbyusername
        Return _context.Users.Find(username)
    End Function

    Public Function authenticateuser(username As String, password As String) As String Implements IUserService.authenticateuser
        Dim user = _context.GetUserbyusername(username)
        If user IsNot Nothing AndAlso user.Password = password Then
            Return user.UserType
        Else
            Return "error"
        End If
    End Function

    Public Function ValidateUsername(username As String) As Boolean Implements IUserService.ValidateUsername
        ' Check if a user with the given username already exists in the database
        Dim existingUser = _context.GetUserByUsername(username)
        Return existingUser IsNot Nothing
    End Function


    Public Function GetUsersTable() As DataTable Implements IUserService.getuserstable
        Dim users = _context.Users.ToList()

        Dim table As New DataTable()
        table.Columns.Add("UserID", GetType(Integer))
        table.Columns.Add("FirstName", GetType(String))
        table.Columns.Add("LastName", GetType(String))
        table.Columns.Add("Address", GetType(String))
        table.Columns.Add("PhoneNumber", GetType(String))
        table.Columns.Add("Gender", GetType(String))
        table.Columns.Add("Username", GetType(String))
        table.Columns.Add("Password", GetType(String))

        For Each user In users
            table.Rows.Add(user.UserID, user.FirstName, user.LastName, user.Address, user.PhoneNumber, user.Gender, user.Username, user.Password)
        Next

        Return table
    End Function
End Class
