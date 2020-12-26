using CodeFirst.Configurations;
using CodeFirst.ConnectionStrings;
using CodeFirst.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Context
{
    public class SqlServerContext : BaseContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Connection.SqlServerConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MoviesConfiguration());
            modelBuilder.ApplyConfiguration(new CopiesConfiguration());
            modelBuilder.ApplyConfiguration(new ActorsConfiguration());
            modelBuilder.ApplyConfiguration(new StarringConfiguration());
            modelBuilder.ApplyConfiguration(new RentalsConfiguration());
            modelBuilder.ApplyConfiguration(new ClientsConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeesConfiguration());
        }
    }
}