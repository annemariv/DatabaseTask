using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseTask.Data.Models;

public partial class DatabaseTaskDbContext : DbContext
{
    public DatabaseTaskDbContext()
    {
    }

    public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AnonymousHint> AnonymousHints { get; set; }

    public virtual DbSet<Branch> Branches { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<HealthCheck> HealthChecks { get; set; }

    public virtual DbSet<IntranetPermission> IntranetPermissions { get; set; }

    public virtual DbSet<Kid> Kids { get; set; }

    public virtual DbSet<LoanableItem> LoanableItems { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<SickLeave> SickLeaves { get; set; }

    public virtual DbSet<Vacation> Vacations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DELL;Database=DatabaseTask;Trusted_Connection=true;MultipleActiveResultSets=true;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnonymousHint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Anonymou__3214EC0755B5C7ED");

            entity.ToTable("AnonymousHint");

            entity.Property(e => e.Comment).HasColumnName("comment");
            entity.Property(e => e.HintDate).HasColumnName("hintDate");
            entity.Property(e => e.HintType)
                .HasMaxLength(255)
                .HasColumnName("hintType");

            entity.HasOne(d => d.Company).WithMany(p => p.AnonymousHints)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AnonymousHint_Company");
        });

        modelBuilder.Entity<Branch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Branches__3214EC07A8A25E04");

            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.BranchName)
                .HasMaxLength(255)
                .HasColumnName("branchName");

            entity.HasOne(d => d.Company).WithMany(p => p.Branches)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Branches_Company");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Company__3214EC07B3B25649");

            entity.ToTable("Company");

            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(255)
                .HasColumnName("companyName");
            entity.Property(e => e.RegisterCode)
                .HasMaxLength(255)
                .HasColumnName("registerCode");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC079F754466");

            entity.ToTable("Employee");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
        });

        modelBuilder.Entity<HealthCheck>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HealthCh__3214EC07C7E84B87");

            entity.ToTable("HealthCheck");

            entity.Property(e => e.CheckDate).HasColumnName("checkDate");
            entity.Property(e => e.Comments).HasColumnName("comments");
            entity.Property(e => e.IsChecked).HasColumnName("isChecked");

            entity.HasOne(d => d.Employee).WithMany(p => p.HealthChecks)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HealthCheck_Employee");
        });

        modelBuilder.Entity<IntranetPermission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Intranet__3214EC07E500297B");

            entity.Property(e => e.Comments).HasColumnName("comments");
            entity.Property(e => e.PermissionEndDate).HasColumnName("permissionEndDate");
            entity.Property(e => e.PermissionGrantedDate).HasColumnName("permissionGrantedDate");
            entity.Property(e => e.PermissionName)
                .HasMaxLength(255)
                .HasColumnName("permissionName");

            entity.HasOne(d => d.Company).WithMany(p => p.IntranetPermissions)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IntranetPermissions_Company");

            entity.HasOne(d => d.Employee).WithMany(p => p.IntranetPermissions)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_IntranetPermissions_Employee");
        });

        modelBuilder.Entity<Kid>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Kids__3214EC079D3012BF");

            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);

            entity.HasOne(d => d.Employee).WithMany(p => p.Kids)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Kids_Employee");
        });

        modelBuilder.Entity<LoanableItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Loanable__3214EC07C9CF42DE");

            entity.Property(e => e.IsReturned).HasColumnName("isReturned");
            entity.Property(e => e.ItemName)
                .HasMaxLength(255)
                .HasColumnName("itemName");
            entity.Property(e => e.LoanEndingDate).HasColumnName("loanEndingDate");
            entity.Property(e => e.LoanStartingDate).HasColumnName("loanStartingDate");

            entity.HasOne(d => d.Company).WithMany(p => p.LoanableItems)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LoanableItems_Company");

            entity.HasOne(d => d.Employee).WithMany(p => p.LoanableItems)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LoanableItems_Employee");
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Request__3214EC0726B1EFCC");

            entity.ToTable("Request");

            entity.Property(e => e.Comment).HasColumnName("comment");
            entity.Property(e => e.RequestDate).HasColumnName("requestDate");
            entity.Property(e => e.RequestType)
                .HasMaxLength(255)
                .HasColumnName("requestType");

            entity.HasOne(d => d.Company).WithMany(p => p.Requests)
                .HasForeignKey(d => d.CompanyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Request_Company");

            entity.HasOne(d => d.Employee).WithMany(p => p.Requests)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Request_Employee");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Roles__3214EC078EA27C9F");

            entity.Property(e => e.RoleName)
                .HasMaxLength(255)
                .HasColumnName("roleName");

            entity.HasOne(d => d.Branch).WithMany(p => p.Roles)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Roles_Branches");

            entity.HasOne(d => d.Employee).WithMany(p => p.Roles)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Roles_Employee");
        });

        modelBuilder.Entity<SickLeave>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SickLeav__3214EC07CF269CEB");

            entity.ToTable("SickLeave");

            entity.Property(e => e.EndingDate).HasColumnName("endingDate");
            entity.Property(e => e.Replacement)
                .HasMaxLength(255)
                .HasColumnName("replacement");
            entity.Property(e => e.StartingDate).HasColumnName("startingDate");

            entity.HasOne(d => d.Employee).WithMany(p => p.SickLeaves)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SickLeave_Employee");
        });

        modelBuilder.Entity<Vacation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Vacation__3214EC074941A1E0");

            entity.Property(e => e.Comments).HasColumnName("comments");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.VacationDaysTotal).HasColumnName("vacationDaysTotal");

            entity.HasOne(d => d.Employee).WithMany(p => p.Vacations)
                .HasForeignKey(d => d.EmployeeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Vacations_Employee");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
