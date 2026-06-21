using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TransformiceAPI.DAL.Models;

namespace TransformiceAPI.DAL.Context;

public partial class DatabaseContext : DbContext
{
    public DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<account> accounts { get; set; }

    public virtual DbSet<account_level> account_levels { get; set; }

    public virtual DbSet<account_title> account_titles { get; set; }

    public virtual DbSet<gender> genders { get; set; }

    public virtual DbSet<level> levels { get; set; }

    public virtual DbSet<title> titles { get; set; }

    public virtual DbSet<user> users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<account>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__account__3213E83F0C7854D0");

            entity.Property(e => e.id_user).HasDefaultValue(1);

            entity.HasOne(d => d.id_genderNavigation).WithMany(p => p.accounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__account__id_gend__5165187F");

            entity.HasOne(d => d.id_titleNavigation).WithMany(p => p.accounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__account__id_titl__52593CB8");

            entity.HasOne(d => d.id_userNavigation).WithMany(p => p.accounts)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__account__id_user__628FA481");
        });

        modelBuilder.Entity<account_level>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__account___3213E83F89B05258");

            entity.HasOne(d => d.id_accountNavigation).WithMany(p => p.account_levels)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__account_l__id_ac__5629CD9C");

            entity.HasOne(d => d.id_levelNavigation).WithMany(p => p.account_levels)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__account_l__id_le__5535A963");
        });

        modelBuilder.Entity<account_title>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__account___3213E83FD3EE80A9");

            entity.HasOne(d => d.id_accountNavigation).WithMany(p => p.account_titles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__account_t__id_ac__59FA5E80");

            entity.HasOne(d => d.id_titleNavigation).WithMany(p => p.account_titles)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__account_t__id_ac__59063A47");
        });

        modelBuilder.Entity<gender>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__gender__3213E83FA04CF0B9");
        });

        modelBuilder.Entity<level>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__level__3213E83F6177C0D1");
        });

        modelBuilder.Entity<title>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__title__3213E83F8D087AE4");
        });

        modelBuilder.Entity<user>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__user__3213E83F1A51AEBC");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
