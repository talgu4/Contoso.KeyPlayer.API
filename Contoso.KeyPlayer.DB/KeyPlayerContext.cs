using System;
using Contoso.KeyPlayer.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Contoso.KeyPlayer.DB
{
    partial class KeyPlayerContext : DbContext
    {
        public KeyPlayerContext()
        {
        }

        public KeyPlayerContext(DbContextOptions<KeyPlayerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<KpactivePlayer> KpactivePlayer { get; set; }
        public virtual DbSet<Kpteam> Kpteam { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                throw new InvalidOperationException("Context not Initialized....");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KpactivePlayer>(entity =>
            {
                entity.HasKey(e => e.PlayerId);

                entity.ToTable("KPActivePlayer");

                entity.Property(e => e.PlayerId).HasColumnName("PlayerID");

                entity.Property(e => e.Birthdate).HasColumnType("date");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TeamId).HasColumnName("TeamID");
            });

            modelBuilder.Entity<Kpteam>(entity =>
            {
                entity.HasKey(e => e.TeamId);

                entity.ToTable("KPTeam");

                entity.Property(e => e.TeamId).HasColumnName("TeamID");

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TeamName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
