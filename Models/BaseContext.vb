Imports System
Imports System.Collections.Generic
Imports Microsoft.EntityFrameworkCore

Namespace Models
    Partial Public Class BaseContext
        Inherits DbContext

        Public Sub New()
        End Sub

        Public Sub New(options As DbContextOptions(Of BaseContext))
            MyBase.New(options)
        End Sub

        Public Overridable Property Clientes As DbSet(Of Cliente)

        Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
            'TODO /!\ To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            optionsBuilder.UseSqlServer("Data Source=PCJC\SQLEXPRESS;Initial Catalog=ejerciciofinal;Persist Security Info=True;User ID=sa;Password=ats475;TrustServerCertificate=True")
        End Sub

        Protected Overrides Sub OnModelCreating(modelBuilder As ModelBuilder)
            modelBuilder.Entity(Of Cliente)(
                Sub(entity)
                    entity.Property(Function(e) e.Id).ValueGeneratedNever()
                    entity.Property(Function(e) e.Apellido).
                        HasMaxLength(50).
                        IsUnicode(False).
                        HasColumnName("apellido")
                    entity.Property(Function(e) e.Edad).HasColumnName("edad")
                    entity.Property(Function(e) e.Nombre).
                        HasMaxLength(50).
                        IsUnicode(False).
                        HasColumnName("nombre")
                End Sub)

            OnModelCreatingPartial(modelBuilder)
        End Sub

        Partial Private Sub OnModelCreatingPartial(modelBuilder As ModelBuilder)
        End Sub
    End Class
End Namespace
