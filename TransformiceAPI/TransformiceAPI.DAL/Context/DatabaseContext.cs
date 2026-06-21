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

    public virtual DbSet<account_shop_item> account_shop_items { get; set; }

    public virtual DbSet<account_shop_item_color> account_shop_item_colors { get; set; }

    public virtual DbSet<account_shop_outfit> account_shop_outfits { get; set; }

    public virtual DbSet<account_shop_outfit_item> account_shop_outfit_items { get; set; }

    public virtual DbSet<account_shop_outfit_item_color> account_shop_outfit_item_colors { get; set; }

    public virtual DbSet<account_title> account_titles { get; set; }

    public virtual DbSet<account_wallet> account_wallets { get; set; }

    public virtual DbSet<gender> genders { get; set; }

    public virtual DbSet<level> levels { get; set; }

    public virtual DbSet<shop_item> shop_items { get; set; }

    public virtual DbSet<shop_item_category> shop_item_categories { get; set; }

    public virtual DbSet<shop_item_color> shop_item_colors { get; set; }

    public virtual DbSet<shop_item_type> shop_item_types { get; set; }

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

        modelBuilder.Entity<account_shop_item>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__account___3213E83F2905DC16");

            entity.HasOne(d => d.id_accountNavigation).WithMany(p => p.account_shop_items)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__account_s__id_ac__70DDC3D8");

            entity.HasOne(d => d.id_shop_itemNavigation).WithMany(p => p.account_shop_items)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__account_s__id_sh__71D1E811");
        });

        modelBuilder.Entity<account_shop_item_color>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__account___3213E83F7086A4E2");

            entity.HasOne(d => d.id_account_shop_itemNavigation).WithMany(p => p.account_shop_item_colors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__account_s__id_ac__74AE54BC");
        });

        modelBuilder.Entity<account_shop_outfit>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__account___3213E83FEB9C2FD3");

            entity.HasOne(d => d.id_accountNavigation).WithMany(p => p.account_shop_outfits)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__account_s__id_ac__778AC167");
        });

        modelBuilder.Entity<account_shop_outfit_item>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__account___3213E83FCB0991F7");

            entity.HasOne(d => d.id_account_shop_itemNavigation).WithMany(p => p.account_shop_outfit_items)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__account_s__id_ac__7B5B524B");

            entity.HasOne(d => d.id_account_shop_outfitNavigation).WithMany(p => p.account_shop_outfit_items)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__account_s__id_ac__7A672E12");
        });

        modelBuilder.Entity<account_shop_outfit_item_color>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__account___3213E83F3D7C8EA5");

            entity.HasOne(d => d.id_account_shop_outfit_itemNavigation).WithMany(p => p.account_shop_outfit_item_colors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__account_s__id_ac__7E37BEF6");
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

        modelBuilder.Entity<account_wallet>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__account___3213E83FF60921B9");

            entity.HasOne(d => d.id_accountNavigation).WithMany(p => p.account_wallets)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__account_w__id_ac__01142BA1");
        });

        modelBuilder.Entity<gender>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__gender__3213E83FA04CF0B9");
        });

        modelBuilder.Entity<level>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__level__3213E83F6177C0D1");
        });

        modelBuilder.Entity<shop_item>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__shop_ite__3213E83F81D4B171");

            entity.HasOne(d => d.id_shop_item_typeNavigation).WithMany(p => p.shop_items)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__shop_item__id_sh__6B24EA82");
        });

        modelBuilder.Entity<shop_item_category>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__shop_ite__3213E83FD79FDA6C");
        });

        modelBuilder.Entity<shop_item_color>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__shop_ite__3213E83F555E4FEA");

            entity.HasOne(d => d.id_shop_itemNavigation).WithMany(p => p.shop_item_colors)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__shop_item__id_sh__6E01572D");
        });

        modelBuilder.Entity<shop_item_type>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__shop_ite__3213E83F3537875B");

            entity.HasOne(d => d.id_shop_item_categoryNavigation).WithMany(p => p.shop_item_types)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__shop_item__id_sh__68487DD7");
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
