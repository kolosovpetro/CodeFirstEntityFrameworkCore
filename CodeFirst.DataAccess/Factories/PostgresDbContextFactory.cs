using System;
using CodeFirst.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CodeFirst.Factories
{
    public class PostgresDbContextFactory : IDesignTimeDbContextFactory<PostgresDbContext>
    {
        public PostgresDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PostgresDbContext>();
            var connectionString = Environment.GetEnvironmentVariable("POSTGRES_MOVIES_LOCAL_CONNSTR");
            optionsBuilder.UseNpgsql(connectionString
                                     ?? throw new NullReferenceException(
                                         $"Connection string is not got from environment {nameof(connectionString)}"));

            return new PostgresDbContext(optionsBuilder.Options);
        }
    }
}