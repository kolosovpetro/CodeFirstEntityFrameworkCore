using System;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst.Factories;
using CodeFirst.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.ConsoleUI
{
    public static class Program
    {
        private static async Task Main()
        {
            var postFactory = new PostgresDbContextFactory();
            var postgreRepo = new MoviesRepository(postFactory.CreateDbContext(Array.Empty<string>()));
            var movies = await postgreRepo.GetAllAsync();
            movies.ToList().ForEach(Console.WriteLine);
            var getById = await postgreRepo.GetByIdAsync(3);
            Console.WriteLine(getById.Title);

            var sqlFactory = new SqlServerDbContextFactory();
            var sqlServerRepo = new MoviesRepository(sqlFactory.CreateDbContext(Array.Empty<string>()));
            movies = await sqlServerRepo.GetAllAsync();
            movies.ToList().ForEach(Console.WriteLine);
            getById = await sqlServerRepo.GetByIdAsync(3);
            Console.WriteLine(getById.Title);

            await using var context = sqlFactory.CreateDbContext(Array.Empty<string>());
            var query = context.Movies.Include(x => x.Copies);
            Console.WriteLine(query.ToQueryString());
        }
    }
}