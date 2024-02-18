using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dal.Models;

public partial class LibraryContext : DbContext
{
    public LibraryContext()
    {
    }

    public LibraryContext(DbContextOptions<LibraryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<BussinesDetail> BussinesDetails { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Employer> Employers { get; set; }

    public virtual DbSet<Professional> Professionals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=H:\\C#\\FinalProject\\EmploymentDirectory\\DB\\EmploymentDirectory.mdf;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Addresse__3214EC07CE11E122");

            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<BussinesDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__tmp_ms_x__3214EC07C1139495");

            entity.Property(e => e.BusinessName)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("businessName");
            entity.Property(e => e.PriceRange)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Clients__3214EC07AF9957B2");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.EmailAddress)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.PhoneNumber)
                .IsRequired()
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<Employer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employer__3214EC07ECE06E02");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.BussinesDetailsId).HasColumnName("BussinesDetailsID");
            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50);
        });

        modelBuilder.Entity<Professional>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Professi__3214EC07C9F8D53D");

            entity.Property(e => e.Professional1)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Professional");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
