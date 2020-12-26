using System.Threading.Tasks;
using CodeFirst.Context;
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
            var repo = new MoviesRepository(new SqlServerContext());
            var movie = await repo.GetByIdAsync(2);
            movie.Should().NotBeNull();
            movie.MovieId.Should().Be(2);
            movie.Title = "Ghostbusters";
            repo.Update(movie);
            var success = await repo.SaveChangesAsync();
            success.Should().BeTrue();
        }
    }
}