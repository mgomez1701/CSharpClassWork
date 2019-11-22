using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Day_27___SessionsRecap.Models
{
    public partial class MOVIE_DbContext : DbContext
    {
        public MOVIE_DbContext()
        {
        }

        public MOVIE_DbContext(DbContextOptions<MOVIE_DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Movies> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=MOVIE_Db;Trusted_Connection=True)");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movies>(entity =>
            {
                entity.Property(e => e.Category).HasMaxLength(20);

                entity.Property(e => e.Director)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.LeadActor).HasMaxLength(40);

                entity.Property(e => e.ReleaseDate).HasColumnType("date");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
