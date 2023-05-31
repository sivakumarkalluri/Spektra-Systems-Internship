using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CRUD_APPLICATION.Models;

public partial class EfDemoDbContext : DbContext
{
    public EfDemoDbContext()
    {
    }

    public EfDemoDbContext(DbContextOptions<EfDemoDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Standard> Standards { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentAddress> StudentAddresses { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    public virtual DbSet<VwStudentCourse> VwStudentCourses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.CourseId).HasName("PK__Course__C92D71A7F33E1612");

            entity.HasOne(d => d.Teacher).WithMany(p => p.Courses).HasConstraintName("FK__Course__TeacherI__29572725");
        });

        modelBuilder.Entity<Standard>(entity =>
        {
            entity.HasKey(e => e.StandardId).HasName("PK__Standard__BB33D20CFC50FE92");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Student__32C52B99703816B9");

            entity.HasOne(d => d.Standard).WithMany(p => p.Students).HasConstraintName("FK__Student__Standar__2C3393D0");

            entity.HasMany(d => d.Courses).WithMany(p => p.Students)
                .UsingEntity<Dictionary<string, object>>(
                    "StudentCourse",
                    r => r.HasOne<Course>().WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__StudentCo__Cours__32E0915F"),
                    l => l.HasOne<Student>().WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__StudentCo__Stude__31EC6D26"),
                    j =>
                    {
                        j.HasKey("StudentId", "CourseId").HasName("PK__StudentC__5E57FC834DD80B77");
                        j.ToTable("StudentCourse");
                    });
        });

        modelBuilder.Entity<StudentAddress>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__StudentA__32C52B999F6C519D");

            entity.Property(e => e.StudentId).ValueGeneratedNever();

            entity.HasOne(d => d.Student).WithOne(p => p.StudentAddress)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StudentAd__Stude__2F10007B");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.TeacherId).HasName("PK__Teacher__EDF2596422FB81A0");

            entity.HasOne(d => d.Standard).WithMany(p => p.Teachers).HasConstraintName("FK__Teacher__Standar__267ABA7A");
        });

        modelBuilder.Entity<VwStudentCourse>(entity =>
        {
            entity.ToView("vwStudentCourse");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
