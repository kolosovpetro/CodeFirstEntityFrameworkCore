using System;
using System.Threading.Tasks;
using CodeFirst.Factories;
using CodeFirst.Repositories;
using FluentAssertions;
using NUnit.Framework;

namespace CodeFirst.DataAccess.Tests.SqlServerRepositoryTests
{
    [TestFixture]
    public class SqlServerRepoUpdateTest
    {
        [Test]
        public async Task SqlServerRepo_Update_Test()
        {
            var factory = new SqlServerDbContextFactory();
            var repo = new MoviesRepository(factory.CreateDbContext(Array.Empty<string>()));
            var movie = await repo.GetByIdAsync(2);
            movie.Should().NotBeNull();
            movie.MovieId.Should().Be(2);
            var previousTitle = movie.Title;
            movie.Title += " updated";
            repo.Update(movie);
            var success = await repo.SaveChangesAsync();
            success.Should().BeTrue();
            movie.Title = previousTitle;
            repo.Update(movie);
            success = await repo.SaveChangesAsync();
            success.Should().BeTrue();
        }
    }
}