using System.Threading.Tasks;
using CodeFirst.Context;
using CodeFirst.Models.Models;
using CodeFirst.Repositories;
using FluentAssertions;
using NUnit.Framework;

namespace CodeFirst.DataAccess.Tests.PostgreRepositoryTests
{
    [TestFixture]
    public class PostgreRepoCreateTest
    {
        [Test]
        public async Task Postgre_Repo_Create_Test()
        {
            var repo = new MoviesRepository(new PostgreSqlContext());
            var movie = new Movies
            {
                Title = "Lord of the rings",
                AgeRestriction = 12,
                Price = 10.2f,
                Year = 2003
            };

            await repo.AddAsync(movie);
            var success = await repo.SaveChangesAsync();
            success.Should().BeTrue();
        }
    }
}