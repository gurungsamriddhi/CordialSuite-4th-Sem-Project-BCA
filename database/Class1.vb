'Imports Microsoft.EntityFrameworkCore

'Public Class UserContext
'    Inherits BaseDbContext

'    Public Property Users As DbSet(Of User)

'    Protected Overrides Sub OnModelCreating(modelBuilder As ModelBuilder)
'        modelBuilder.Entity(Of User)(
'            Sub(entity)
'                entity.Property(Function(e) e.Id).ValueGeneratedOnAdd()
'                entity.Property(Function(e) e.Username).IsRequired()
'                entity.Property(Function(e) e.Password).IsRequired()
'            End Sub)
'    End Sub
'End Class