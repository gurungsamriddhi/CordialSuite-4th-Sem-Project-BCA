Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Metadata
Imports Microsoft.EntityFrameworkCore.SqlServer
Imports System.Data.SqlClient
Public Class basedbcontext
    Inherits DbContext

    Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
        If Not optionsBuilder.IsConfigured Then
            optionsBuilder.UseSqlServer("data source=(localdb)\mssqllocaldb;attachdbfilename=e:\cordialsuitedb.mdf;integrated security=true;")
        End If
    End Sub

    Public Sub AddEntity(Of T As Class)(entity As T)

        MyBase.Set(Of T)().Add(entity)

        SaveChanges()

    End Sub


    Public Sub DeleteEntity(Of T As Class)(entity As T)
        MyBase.Set(Of T)().Remove(entity)
        SaveChanges()
    End Sub

    Public Sub UpdateEntity(Of T As Class)(entity As T)
        MyBase.Entry(entity).State = EntityState.Modified
        SaveChanges()
    End Sub

    Public Function ExecuteSqlRaw(query As String, ParamArray parameters As SqlParameter()) As Integer
        Return Database.ExecuteSqlRaw(query, parameters)
    End Function
End Class
