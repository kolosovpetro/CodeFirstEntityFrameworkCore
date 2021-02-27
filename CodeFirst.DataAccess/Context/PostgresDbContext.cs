using System;
using CodeFirst.Configurations;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Context
{
    public class PostgresDbContext : BaseDbContext
    {
        public PostgresDbContext(DbContextOptions options) : base(options)
        {
        }

        public PostgresDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = Environment.GetEnvironmentVariable("POSTGRES_MOVIES_LOCAL_CONNSTR");
            optionsBuilder.UseNpgsql(connectionString
                                     ?? throw new NullReferenceException(
                                         $"Connection string is not got from environment {nameof(connectionString)}"));
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