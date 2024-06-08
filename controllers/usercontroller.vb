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
End Class
