using Microsoft.EntityFrameworkCore;

namespace InterviewPrep;

internal class AppDBContext : DbContext
{
    public DbSet<Employee> Employee { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=.;Database=InterviewPrep;Trusted_Connection=True;TrustServerCertificate=True;")
            .LogTo(Console.WriteLine)
            .EnableSensitiveDataLogging();
    }
}
