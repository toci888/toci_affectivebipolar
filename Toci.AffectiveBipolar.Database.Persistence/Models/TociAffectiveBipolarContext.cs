using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Toci.AffectiveBipolar.Database.Persistence.Models
{
    public partial class TociAffectiveBipolarContext : DbContext
    {
        public TociAffectiveBipolarContext()
        {
        }

        public TociAffectiveBipolarContext(DbContextOptions<TociAffectiveBipolarContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Affectivebipolarstate> Affectivebipolarstates { get; set; }
        public virtual DbSet<Consciousmoodchangereason> Consciousmoodchangereasons { get; set; }
        public virtual DbSet<Consumptionorderhistory> Consumptionorderhistories { get; set; }
        public virtual DbSet<Medicament> Medicaments { get; set; }
        public virtual DbSet<Mood> Moods { get; set; }
        public virtual DbSet<Substance> Substances { get; set; }
        public virtual DbSet<Unconsciousmoodchangereason> Unconsciousmoodchangereasons { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Usercurrentstate> Usercurrentstates { get; set; }
        public virtual DbSet<Usermedicamentdose> Usermedicamentdoses { get; set; }
        public virtual DbSet<Userorderedmedicament> Userorderedmedicaments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Host=localhost;Database=Toci.AffectiveBipolar;Username=postgres;Password=beatka");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Polish_Poland.1250");

            modelBuilder.Entity<Affectivebipolarstate>(entity =>
            {
                entity.ToTable("affectivebipolarstates");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Consciousmoodchangereason>(entity =>
            {
                entity.ToTable("consciousmoodchangereason");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Currentdate).HasColumnName("currentdate");

                entity.Property(e => e.Idmood).HasColumnName("idmood");

                entity.Property(e => e.Iduser).HasColumnName("iduser");

                entity.Property(e => e.Percentagetransition).HasColumnName("percentagetransition");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.HasOne(d => d.IdmoodNavigation)
                    .WithMany(p => p.Consciousmoodchangereasons)
                    .HasForeignKey(d => d.Idmood)
                    .HasConstraintName("consciousmoodchangereason_idmood_fkey");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Consciousmoodchangereasons)
                    .HasForeignKey(d => d.Iduser)
                    .HasConstraintName("consciousmoodchangereason_iduser_fkey");
            });

            modelBuilder.Entity<Consumptionorderhistory>(entity =>
            {
                entity.ToTable("consumptionorderhistory");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dose).HasColumnName("dose");

                entity.Property(e => e.Enddate).HasColumnName("enddate");

                entity.Property(e => e.Idmedicament).HasColumnName("idmedicament");

                entity.Property(e => e.Iduser).HasColumnName("iduser");

                entity.Property(e => e.Startdate).HasColumnName("startdate");

                entity.HasOne(d => d.IdmedicamentNavigation)
                    .WithMany(p => p.Consumptionorderhistories)
                    .HasForeignKey(d => d.Idmedicament)
                    .HasConstraintName("consumptionorderhistory_idmedicament_fkey");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Consumptionorderhistories)
                    .HasForeignKey(d => d.Iduser)
                    .HasConstraintName("consumptionorderhistory_iduser_fkey");
            });

            modelBuilder.Entity<Medicament>(entity =>
            {
                entity.ToTable("medicaments");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Idsubstance).HasColumnName("idsubstance");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.HasOne(d => d.IdsubstanceNavigation)
                    .WithMany(p => p.Medicaments)
                    .HasForeignKey(d => d.Idsubstance)
                    .HasConstraintName("medicaments_idsubstance_fkey");
            });

            modelBuilder.Entity<Mood>(entity =>
            {
                entity.ToTable("moods");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Mood1).HasColumnName("mood");
            });

            modelBuilder.Entity<Substance>(entity =>
            {
                entity.ToTable("substances");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Unconsciousmoodchangereason>(entity =>
            {
                entity.ToTable("unconsciousmoodchangereason");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Currentdate).HasColumnName("currentdate");

                entity.Property(e => e.Idmood).HasColumnName("idmood");

                entity.Property(e => e.Iduser).HasColumnName("iduser");

                entity.Property(e => e.Percentagetransition).HasColumnName("percentagetransition");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.HasOne(d => d.IdmoodNavigation)
                    .WithMany(p => p.Unconsciousmoodchangereasons)
                    .HasForeignKey(d => d.Idmood)
                    .HasConstraintName("unconsciousmoodchangereason_idmood_fkey");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Unconsciousmoodchangereasons)
                    .HasForeignKey(d => d.Iduser)
                    .HasConstraintName("unconsciousmoodchangereason_iduser_fkey");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<Usercurrentstate>(entity =>
            {
                entity.ToTable("usercurrentstate");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Currentdate).HasColumnName("currentdate");

                entity.Property(e => e.Idaffectivebipolarstate).HasColumnName("idaffectivebipolarstate");

                entity.Property(e => e.Iduser).HasColumnName("iduser");

                entity.HasOne(d => d.IdaffectivebipolarstateNavigation)
                    .WithMany(p => p.Usercurrentstates)
                    .HasForeignKey(d => d.Idaffectivebipolarstate)
                    .HasConstraintName("usercurrentstate_idaffectivebipolarstate_fkey");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Usercurrentstates)
                    .HasForeignKey(d => d.Iduser)
                    .HasConstraintName("usercurrentstate_iduser_fkey");
            });

            modelBuilder.Entity<Usermedicamentdose>(entity =>
            {
                entity.ToTable("usermedicamentdose");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Consumptiondate).HasColumnName("consumptiondate");

                entity.Property(e => e.Dose).HasColumnName("dose");

                entity.Property(e => e.Idmedicament).HasColumnName("idmedicament");

                entity.Property(e => e.Iduser).HasColumnName("iduser");

                entity.HasOne(d => d.IdmedicamentNavigation)
                    .WithMany(p => p.Usermedicamentdoses)
                    .HasForeignKey(d => d.Idmedicament)
                    .HasConstraintName("usermedicamentdose_idmedicament_fkey");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Usermedicamentdoses)
                    .HasForeignKey(d => d.Iduser)
                    .HasConstraintName("usermedicamentdose_iduser_fkey");
            });

            modelBuilder.Entity<Userorderedmedicament>(entity =>
            {
                entity.ToTable("userorderedmedicament");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dose).HasColumnName("dose");

                entity.Property(e => e.Idmedicament).HasColumnName("idmedicament");

                entity.Property(e => e.Iduser).HasColumnName("iduser");

                entity.Property(e => e.Timeofday).HasColumnName("timeofday");

                entity.Property(e => e.Typeofdose).HasColumnName("typeofdose");

                entity.HasOne(d => d.IdmedicamentNavigation)
                    .WithMany(p => p.Userorderedmedicaments)
                    .HasForeignKey(d => d.Idmedicament)
                    .HasConstraintName("userorderedmedicament_idmedicament_fkey");

                entity.HasOne(d => d.IduserNavigation)
                    .WithMany(p => p.Userorderedmedicaments)
                    .HasForeignKey(d => d.Iduser)
                    .HasConstraintName("userorderedmedicament_iduser_fkey");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
