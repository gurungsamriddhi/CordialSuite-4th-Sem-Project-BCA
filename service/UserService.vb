
Public Interface IUserService
    Sub AddUser(user As User)
    Function GetUserById(userId As Integer) As User
    Function GetAllUsers() As List(Of User)
    Sub UpdateUser(user As User)
    Sub DeleteUser(userId As Integer)
End Interface

Public Class UserService
    Implements IUserService

    Private ReadOnly _context As UserContext

    Public Sub New()
        Dim dbContext As New UserContext()
        _context = dbContext
    End Sub

    Public Sub AddUser(user As User) Implements IUserService.AddUser
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
End Class
