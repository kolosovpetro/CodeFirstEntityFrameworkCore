using System;
using CodeFirst.Configurations;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Context
{
    public class SqlServerDbContext : BaseDbContext
    {
        public SqlServerDbContext(DbContextOptions options) : base(options)
        {
        }

        public SqlServerDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = Environment.GetEnvironmentVariable("SQLSERVER_MOVIES_LOCAL_CONNSTR");
            optionsBuilder.UseSqlServer(connectionString
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