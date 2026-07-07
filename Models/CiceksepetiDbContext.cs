using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace yigit2324.Models;

public partial class CiceksepetiDbContext : DbContext
{
    public CiceksepetiDbContext()
    {
    }

    public CiceksepetiDbContext(DbContextOptions<CiceksepetiDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Urunler> Urunlers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server= ZOWYEL; Database=ciceksepetiDB; Trusted_Connection=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Urunler>(entity =>
        {
            entity.ToTable("urunler");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Resim)
                .HasMaxLength(50)
                .HasColumnName("resim");
            entity.Property(e => e.Stokdurumu)
                .HasMaxLength(50)
                .HasColumnName("stokdurumu");
            entity.Property(e => e.Urunadi)
                .HasMaxLength(200)
                .HasColumnName("urunadi");
            entity.Property(e => e.Urundetayi).HasColumnName("urundetayi");
            entity.Property(e => e.Urunfiyati)
                .HasMaxLength(100)
                .HasColumnName("urunfiyati");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
