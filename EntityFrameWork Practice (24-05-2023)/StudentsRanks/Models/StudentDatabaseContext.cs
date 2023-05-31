using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentsRanks.Models;

public partial class StudentDatabaseContext : DbContext
{
    public StudentDatabaseContext()
    {
    }

    public StudentDatabaseContext(DbContextOptions<StudentDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Mark> Marks { get; set; }

    public virtual DbSet<StudentDetail> StudentDetails { get; set; }

    public DbSet<TopStudent> TopStudents { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Mark>(entity =>
        {
            entity.HasOne(d => d.Student).WithMany().HasConstraintName("FK__marks__studentid__25869641");
        });

        modelBuilder.Entity<StudentDetail>(entity =>
        {
            entity.HasKey(e => e.Studentid).HasName("PK__student___4D16D2644B3A5839");

            entity.Property(e => e.Studentid).ValueGeneratedNever();
        });
        modelBuilder.Entity<TopStudent>().HasNoKey();
        OnModelCreatingPartial(modelBuilder);
    }
   

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
