Imports Microsoft.EntityFrameworkCore

Public Class UserContext
    Inherits basedbcontext

    Public Property Users As DbSet(Of User)

    Protected Overrides Sub OnModelCreating(modelBuilder As ModelBuilder)
        MyBase.OnModelCreating(modelBuilder)

        ' Configure entity properties and relationships if needed
        modelBuilder.Entity(Of User)().ToTable("users")
    End Sub

    ' Create
    Public Sub AddUser(user As User)
        AddEntity(user)
    End Sub

    ' Read
    Public Function GetUserById(userId As Integer) As User
        Return Users.Find(userId)
    End Function

    Public Function GetAllUsers() As List(Of User)
        Return Users.ToList()
    End Function

    ' Update
    Public Sub UpdateUser(user As User)
        UpdateEntity(user)
    End Sub

    ' Delete
    Public Sub DeleteUser(user As User)
        DeleteEntity(user)
    End Sub
End Class
