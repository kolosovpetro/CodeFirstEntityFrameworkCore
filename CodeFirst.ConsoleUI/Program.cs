using System;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst.Context;
using CodeFirst.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.ConsoleUI
{
    public static class Program
    {
        private static async Task Main()
        {
            // var postgreRepo = new MoviesRepository(new PostgresDbContext());
            // var movies = await postgreRepo.GetAllAsync();
            // movies.ToList().ForEach(Console.WriteLine);
            // var getById = await postgreRepo.GetByIdAsync(3);
            // Console.WriteLine(getById.Title);
            //
            // var sqlServerRepo = new MoviesRepository(new SqlServerDbContext());
            // movies = await sqlServerRepo.GetAllAsync();
            // movies.ToList().ForEach(Console.WriteLine);
            // getById = await sqlServerRepo.GetByIdAsync(3);
            // Console.WriteLine(getById.Title);

            using (var context = new SqlServerDbContext())
            {
                var query = context.Movies.Include(x => x.Copies);
                Console.WriteLine(query.ToQueryString());
            }
        }
    }
}