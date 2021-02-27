using System.Threading.Tasks;
using CodeFirst.Context;
using CodeFirst.Repositories;
using FluentAssertions;
using NUnit.Framework;

namespace CodeFirst.DataAccess.Tests.PostgreRepositoryTests
{
    [TestFixture]
    public class PostgreRepoUpdateTest
    {
        [Test]
        public async Task PostgreRepo_Update_Test()
        {
            var repo = new MoviesRepository(new PostgresDbContext());
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