using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<AnonymousHint> AnonymousHint { get; set; }
        public DbSet<Branches> Branches { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<HealthCheck> HealthCheck { get; set; }
        public DbSet<IntranetPermissions> IntranetPermissions { get; set; }
        public DbSet<Kids> Kids { get; set; }
        public DbSet<LoanableItems> LoanableItems { get; set; }
        public DbSet<Request> Request { get; set; }
        public DbSet<Roles> Roles { get; set; }
        public DbSet<SickLeave> SickLeave { get; set; }
        public DbSet<Vacations> Vacations { get; set; }
    }
}
