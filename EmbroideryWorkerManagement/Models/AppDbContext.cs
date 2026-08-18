using Microsoft.EntityFrameworkCore;

namespace EmbroideryWorkerManagement.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Worker> Workers { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
        public DbSet<AdvanceSalary> AdvanceSalaries { get; set; }
        public DbSet<MonthlyTarget> MonthlyTargets { get; set; }
        public DbSet<MachineWork> MachineWorks { get; set; }
        public DbSet<SalaryCalculationResult> salaryCalculationResults { get; set; }
        public DbSet<MonthlyPayment> MonthlyPayments { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<MonthlyPaymentHistory> MonthlyPaymentHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var property in entityType.GetProperties())
                {
                    if (property.ClrType == typeof(DateTime) || property.ClrType == typeof(DateTime?))
                    {
                        property.SetColumnType("timestamp without time zone");
                    }

                    // For decimal types, set precision 18,2 by default
                    if (property.ClrType == typeof(decimal) || property.ClrType == typeof(decimal?))
                    {
                        property.SetPrecision(18);
                        property.SetScale(2);
                    }
                }
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
