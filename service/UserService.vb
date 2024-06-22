
Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Imports Microsoft.EntityFrameworkCore

Public Interface IUserService
    Sub AddUser(user As User)  'bydefault all the functions and sub procedures becomes public also only contains declarations 
    Function GetUserById(userId As Integer) As User
    Function GetAllUsers() As List(Of User)
    Sub UpdateUser(user As User)
    Function getuserbyusername(username As String) As User
    Sub DeleteUser(userId As Integer)
    Function ValidateUsername(username As String) As Boolean

    Function authenticateuser(username As String, password As String) As String
    Function ValidateSuperAdminCredentials(username As String, password As String) As Boolean



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
            MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' If username is unique, proceed with adding the user
        _context.AddEntity(user)
        _context.SaveChanges() ' Make sure to save changes to the database
    End Sub

    Public Function GetUserById(userId As Integer) As User Implements IUserService.GetUserById
        Return _context.Users.Find(userId)
    End Function

    Public Function GetAllUsers() As List(Of User) Implements IUserService.GetAllUsers
        Return _context.Users.ToList()
    End Function

    Public Sub UpdateUser(user As User) Implements IUserService.UpdateUser
        _context.UpdateEntity(user)
        _context.SaveChanges() ' Make sure to save changes to the database
    End Sub

    Public Sub DeleteUser(userId As Integer) Implements IUserService.DeleteUser
        Dim user = _context.Users.Find(userId)
        If user IsNot Nothing Then
            _context.DeleteEntity(user)
            _context.SaveChanges() ' Make sure to save changes to the database
        End If
    End Sub

    Public Function GetUserByUsername(username As String) As User Implements IUserService.getuserbyusername
        Return _context.Users.FirstOrDefault(Function(u) u.Username = username)
    End Function

    Public Function AuthenticateUser(username As String, password As String) As String Implements IUserService.authenticateuser
        Dim user = GetUserByUsername(username)
        If user IsNot Nothing AndAlso user.Password = password Then
            Return user.UserType
        Else
            Return "error"
        End If
    End Function

    Public Function ValidateUsername(username As String) As Boolean Implements IUserService.ValidateUsername
        ' Check if a user with the given username already exists in the database
        Dim existingUser = GetUserByUsername(username)
        Return existingUser IsNot Nothing
    End Function

    Public Function ValidateSuperAdminCredentials(username As String, password As String) As Boolean Implements IUserService.ValidateSuperAdminCredentials
        Dim superAdmin = GetUserByUsername(username)
        If superAdmin IsNot Nothing AndAlso superAdmin.UserType = "superadmin" AndAlso superAdmin.Password = password Then
            Return True
        End If
        Return False
    End Function

End Class
