using Microsoft.EntityFrameworkCore;
using PrimeiraAPI.Model;

namespace PrimeiraAPI.infraestrutura
{
    public class ConnectionContext : DbContext
    {

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-L184CU4;Database=PrimeiraApi;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
