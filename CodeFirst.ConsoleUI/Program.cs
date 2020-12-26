using System;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst.Context;
using CodeFirst.Models.Models;
using CodeFirst.Repositories;

namespace CodeFirst.ConsoleUI
{
    public static class Program
    {
        private static async Task Main()
        {
            var postgreRepo = new MoviesRepository(new PostgreSqlContext());
            var movies = await postgreRepo.GetAllAsync();
            movies.ToList().ForEach(Console.WriteLine);
            var getById = await postgreRepo.GetByIdAsync(3);
            Console.WriteLine(getById.Title);
            
            var sqlServerRepo = new MoviesRepository(new SqlServerContext());
            movies = await sqlServerRepo.GetAllAsync();
            movies.ToList().ForEach(Console.WriteLine);
            getById = await sqlServerRepo.GetByIdAsync(3);
            Console.WriteLine(getById.Title);
        }
    }
}