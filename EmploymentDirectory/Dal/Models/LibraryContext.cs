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

    public virtual DbSet<Employer> Employers { get; set; }

    public virtual DbSet<Professional> Professionals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\טאוב רינה\\Desktop\\FinalProject\\EmploymentDirectory\\DB\\EmploymentDirectory.mdf\";Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Addresse__3214EC07CE11E122");

            entity.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<BussinesDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bussines__3214EC07DD6DE2FB");

            entity.Property(e => e.BusinessName)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("businessName");
            entity.Property(e => e.PriceRange)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ProfessionalId).HasColumnName("ProfessionalID");

            entity.HasOne(d => d.City).WithMany(p => p.BussinesDetails)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BussinesDetails_ToAddresses");

            entity.HasOne(d => d.Professional).WithMany(p => p.BussinesDetails)
                .HasForeignKey(d => d.ProfessionalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BussinesDetails_ToProfessionals");
        });

        modelBuilder.Entity<Employer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employer__3214EC0722E42C41");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ProfessionalId).HasColumnName("ProfessionalID");

            entity.HasOne(d => d.Address).WithMany(p => p.Employers)
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employers_ToAddresses");

            entity.HasOne(d => d.Professional).WithMany(p => p.Employers)
                .HasForeignKey(d => d.ProfessionalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Employers_ToProfessionals");
        });

        modelBuilder.Entity<Professional>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Professi__3214EC07E3231F7C");

            entity.Property(e => e.BussinesDetailsId).HasColumnName("BussinesDetailsID");
            entity.Property(e => e.EmployersId).HasColumnName("EmployersID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
