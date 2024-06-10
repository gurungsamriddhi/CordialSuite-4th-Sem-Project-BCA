Imports Microsoft.EntityFrameworkCore

Public Class UserController
    Private ReadOnly _userService As IUserService

    Public Sub New()
        Dim userService As New UserService()
        _userService = userService
    End Sub

    Public Sub AddUser(viewModel As User)
        _userService.AddUser(viewModel)
    End Sub

    Public Sub UpdateUser(viewModel As User)
        _userService.UpdateUser(viewModel)
    End Sub

    Public Sub DeleteUser(userId As Integer)
        _userService.DeleteUser(userId)
    End Sub

    Public Function validusername(username As String) As Boolean
        Return _userService.ValidateUsername(username)

    End Function
    Public Function authenticateuser(username As String, password As String) As String
        Return _userService.authenticateuser(username, password)

    End Function
    Public Function GetUsersDataTable() As DataTable
        Return _userService.getuserstable()
    End Function


    Public Function ValidateSuperAdminCredentials(username As String, password As String) As Boolean
        Return _userService.ValidateSuperAdminCredentials(username, password)
    End Function
End Class
