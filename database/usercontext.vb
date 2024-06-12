Imports Microsoft.EntityFrameworkCore

Public Class UserContext
    Inherits basedbcontext

    Public Property Users As DbSet(Of User)

    Protected Overrides Sub OnModelCreating(modelBuilder As ModelBuilder)
        MyBase.OnModelCreating(modelBuilder)

        ' Configure entity properties and relationships if needed
        modelBuilder.Entity(Of User)().ToTable("users")
        modelBuilder.Entity(Of User)().HasIndex(Function(u) u.Username).IsUnique()
        modelBuilder.Entity(Of User)().Property(Function(u) u.Username).IsRequired().HasMaxLength(50).HasColumnName("Username").IsUnicode(True)
    End Sub

    ' Create using raw SQL 
    Public Sub AddUser(user As User)
        Dim sql = "INSERT INTO users (Firstname, Lastname, Address, Phonenumber, Age, Gender, Usertype, Username, Password) " &
                  "VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)"
        Database.ExecuteSqlRaw(sql, user.FirstName, user.LastName, user.Address, user.PhoneNumber, user.Age, user.Gender, user.UserType, user.Username, user.Password)
    End Sub

    ' Read using raw SQL
    Public Function GetUserById(userId As Integer) As User
        Dim sql = "SELECT * FROM users WHERE id = @p0"
        Return Users.FromSqlRaw(sql, userId).AsNoTracking().FirstOrDefault()
    End Function

    ' Read all users using raw SQL
    Public Function GetAllUsers() As List(Of User)
        Dim sql = "SELECT * FROM users"
        Return Users.FromSqlRaw(sql).AsNoTracking().ToList()
    End Function

    ' Update using raw SQL
    Public Sub UpdateUser(user As User)
        Dim sql = "UPDATE users SET Firstname = @p0, Lastname = @p1, Address = @p2, Phonenumber = @p3, Age = @p4, Gender = @p5, Usertype = @p6, username = @p7, password = @p8 WHERE id = @p9"
        Database.ExecuteSqlRaw(sql, user.FirstName, user.LastName, user.Address, user.PhoneNumber, user.Age, user.Gender, user.UserType, user.Username, user.Password, user.UserID
                               )
    End Sub

    ' Get user by username using raw SQL
    Public Function GetUserByUsername(username As String) As User
        Dim sql = "SELECT * FROM users WHERE Username = @p0"
        Return Users.FromSqlRaw(sql, username).AsNoTracking().FirstOrDefault()
    End Function

    ' Delete using raw SQL
    Public Sub DeleteUser(user As User)
        Dim sql = "DELETE FROM users WHERE id = @p0"
        Database.ExecuteSqlRaw(sql, user.UserID)
    End Sub




End Class
