using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PersonManagement.Models;

public partial class PersonManagementContext : DbContext
{
    public PersonManagementContext()
    {
    }

    public PersonManagementContext(DbContextOptions<PersonManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Pm01Person> Pm01People { get; set; }

    public virtual DbSet<Pm02MaritalStatus> Pm02MaritalStatuses { get; set; }

    public virtual DbSet<Pm03User> Pm03Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name = DevConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Pm01Person>(entity =>
        {
            entity.HasKey(e => e.IdPerson);

            entity.ToTable("PM01_Person");

            entity.Property(e => e.IdPerson).HasColumnName("Id_person");
            entity.Property(e => e.DateofBirth).HasColumnType("datetime");
            entity.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdMaritalstatus).HasColumnName("Id_maritalstatus");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PlaceofBirth)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Surname).HasMaxLength(50);
        });

        modelBuilder.Entity<Pm02MaritalStatus>(entity =>
        {
            entity.HasKey(e => e.IdMaritalStatus);

            entity.ToTable("PM02_MaritalStatus");

            entity.Property(e => e.IdMaritalStatus).HasColumnName("Id_MaritalStatus");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Pm03User>(entity =>
        {
            entity
                .ToTable("PM03_User");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IdUser)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_user");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Surname)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
