using System;
using System.Collections.Generic;
using DTO.Entities;
using Microsoft.EntityFrameworkCore;

namespace DTO;

public partial class SanPhamDbContext : DbContext
{
    public SanPhamDbContext()
    {
    }

    public SanPhamDbContext(DbContextOptions<SanPhamDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<System.Attribute> Attributes { get; set; }

    public virtual DbSet<GroupAttribute> GroupAttributes { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductAttribute> ProductAttributes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(local);Database= SanPhamDB;UID=sa;PWD=sa123456;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Entities.Attribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Attribut__3214EC27D5B5027C");

            entity.ToTable("Attribute");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AttrName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AttrValue)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Groupid).HasColumnName("GROUPID");
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.Group).WithMany(p => p.Attributes)
                .HasForeignKey(d => d.Groupid)
                .HasConstraintName("FK__Attribute__GROUP__4BAC3F29");
        });

        modelBuilder.Entity<GroupAttribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GROUP_AT__3214EC2724D15618");

            entity.ToTable("GROUP_ATTRIBUTE");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Product__B40CC6ED8C3FF486");

            entity.ToTable("Product");

            entity.Property(e => e.ProductId)
                .ValueGeneratedNever()
                .HasColumnName("ProductID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ProductAttribute>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ProductA__3214EC2784D101A8");

            entity.ToTable("ProductAttribute");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.AttributeId).HasColumnName("AttributeID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Attribute).WithMany(p => p.ProductAttributes)
                .HasForeignKey(d => d.AttributeId)
                .HasConstraintName("FK__ProductAt__Attri__5165187F");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductAttributes)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__ProductAt__Produ__5070F446");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
