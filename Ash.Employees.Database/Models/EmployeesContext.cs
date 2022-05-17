using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Ash.Employees.Database.Models
{
    public partial class EmployeesContext : DbContext
    {
        public EmployeesContext()
        {
        }

        public EmployeesContext(DbContextOptions<EmployeesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<HourlyEmployee> HourlyEmployees { get; set; } = null!;
        public virtual DbSet<Manager> Managers { get; set; } = null!;
        public virtual DbSet<Supervisor> Supervisors { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.Address1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HourlyEmployee>(entity =>
            {
                entity.ToTable("HourlyEmployee");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.PayPerHour).HasColumnType("decimal(5, 2)");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.HourlyEmployee)
                    .HasForeignKey<HourlyEmployee>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HourlyEmployee_Employee");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Manager");

                entity.Property(e => e.MaxExpenseAmount).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Manager_Supervisor");
            });

            modelBuilder.Entity<Supervisor>(entity =>
            {
                entity.ToTable("Supervisor");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AnnualSalary).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.IdNavigation)
                    .WithOne(p => p.Supervisor)
                    .HasForeignKey<Supervisor>(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Supervisor_Employee");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
