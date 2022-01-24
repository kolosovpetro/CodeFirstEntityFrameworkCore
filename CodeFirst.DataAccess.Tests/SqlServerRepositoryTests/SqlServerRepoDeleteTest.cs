using System;
using System.Threading.Tasks;
using CodeFirst.DataAccess.Factories;
using CodeFirst.DataAccess.Repositories;
using FluentAssertions;
using NUnit.Framework;

namespace CodeFirst.DataAccess.Tests.SqlServerRepositoryTests
{
    [TestFixture]
    public class SqlServerRepoDeleteTest
    {
        [Test]
        public async Task SqlServerRepo_Delete_Test()
        {
            var factory = new SqlServerDbContextFactory();
            var repo = new MoviesRepository(factory.CreateDbContext(Array.Empty<string>()));
            var movie = await repo.GetByIdAsync(1);
            movie.Should().NotBeNull();
            movie.MovieId.Should().Be(1);
            repo.Delete(movie);
            var success = await repo.SaveChangesAsync();
            success.Should().BeTrue();
        }
    }
}