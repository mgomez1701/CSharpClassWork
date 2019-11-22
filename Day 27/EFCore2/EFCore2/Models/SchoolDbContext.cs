using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFCore2.Models
{
    public partial class SchoolDbContext : DbContext
    {
        public SchoolDbContext()
        {
        }

        public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Grades> Grades { get; set; }
        public virtual DbSet<Instructors> Instructors { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
        public virtual DbSet<StudentCourses> StudentCourses { get; set; }
        public virtual DbSet<Students> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=SchoolDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Courses>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.InstructorId).HasColumnName("InstructorID");

                entity.Property(e => e.Language).HasMaxLength(25);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Instructor)
                    .WithMany(p => p.InverseInstructor)
                    .HasForeignKey(d => d.InstructorId)
                    .HasConstraintName("FK__Courses__Instruc__5441852A");
            });

            modelBuilder.Entity<Grades>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.Grades1).HasColumnName("Grades");

                entity.Property(e => e.LabName)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.StudentCourseId).HasColumnName("StudentCourseID");

                entity.HasOne(d => d.StudentCourse)
                    .WithMany(p => p.Grades)
                    .HasForeignKey(d => d.StudentCourseId)
                    .HasConstraintName("FK__Grades__StudentC__5AEE82B9");
            });

            modelBuilder.Entity<Instructors>(entity =>
            {
                entity.Property(e => e.HireDate).HasColumnType("date");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Instructors)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__Instructo__Perso__5070F446");
            });

            modelBuilder.Entity<Persons>(entity =>
            {
                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.InstructorId).HasColumnName("InstructorID");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.HasOne(d => d.Instructor)
                    .WithMany(p => p.Persons)
                    .HasForeignKey(d => d.InstructorId)
                    .HasConstraintName("FK__Persons__Instruc__5165187F");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.InverseStudent)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__Persons__Student__4CA06362");
            });

            modelBuilder.Entity<StudentCourses>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.StudentId).HasColumnName("StudentID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.StudentCourses)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__StudentCo__Cours__5812160E");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.StudentCourses)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__StudentCo__Stude__571DF1D5");
            });

            modelBuilder.Entity<Students>(entity =>
            {
                entity.Property(e => e.Gpa).HasColumnName("GPA");

                entity.Property(e => e.GradDate).HasColumnType("date");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.PersonId)
                    .HasConstraintName("FK__Students__Person__4BAC3F29");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
