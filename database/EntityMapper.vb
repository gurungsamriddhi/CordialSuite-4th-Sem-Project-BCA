Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Metadata
Imports Microsoft.EntityFrameworkCore.SqlServer

Public Class BaseDbContext
    Inherits DbContext

    Public Sub New(options As DbContextOptions(Of BaseDbContext))
        MyBase.New(options)
    End Sub

    Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
        If Not optionsBuilder.IsConfigured Then
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\CordialSuiteDB.mdf;Integrated Security=True;Connect Timeout=30")
        End If
    End Sub

    Public Sub AddEntity(Of T As Class)(entity As T)
        Set(Of T)().Add(entity)
        SaveChanges()
    End Sub

    Public Sub DeleteEntity(Of T)(entity As T)
        Set(Of T)().Remove(entity)
        SaveChanges()
    End Sub

    Public Sub UpdateEntity(Of T)(entity As T)
        Entry(entity).State = EntityState.Modified
        SaveChanges()
    End Sub
End Class