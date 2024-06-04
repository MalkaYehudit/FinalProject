using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<BussinesDetail> BussinesDetails { get; set; }

    public virtual DbSet<Profession> Professions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=H:\\FinalProject\\EmploymentDirectory\\server\\DB\\EmploymentDirectory.mdf;Integrated Security = True; Connect Timeout = 30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Password).HasName("PK__Accounts__87909B14414A9D8A");

            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

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
            entity.HasKey(e => e.Id).HasName("PK__Bussines__3214EC07A579C961");

            entity.Property(e => e.AccountId)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("AccountID");
            entity.Property(e => e.AddressId).HasColumnName("AddressID");
            entity.Property(e => e.BussinesName)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PriceRange)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.ProfessionId).HasColumnName("ProfessionID");

            entity.HasOne(d => d.Account).WithMany(p => p.BussinesDetails)
                .HasForeignKey(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BussinesDetails_ToAccounts");

            entity.HasOne(d => d.Address).WithMany(p => p.BussinesDetails)
                .HasForeignKey(d => d.AddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BussinesDetails_ToAddresses");

            entity.HasOne(d => d.Profession).WithMany(p => p.BussinesDetails)
                .HasForeignKey(d => d.ProfessionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BussinesDetails_ToProfession");
        });

        modelBuilder.Entity<Profession>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Professi__3214EC0760D197E3");

            entity.Property(e => e.Profession1)
                .IsRequired()
                .HasMaxLength(50)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasColumnName("Profession");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
