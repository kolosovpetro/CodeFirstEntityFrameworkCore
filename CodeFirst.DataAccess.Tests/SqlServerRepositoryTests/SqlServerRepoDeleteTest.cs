﻿using System.Threading.Tasks;
using CodeFirst.Context;
using CodeFirst.Repositories;
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
            var repo = new MoviesRepository(new SqlServerDbContext());
            var movie = await repo.GetByIdAsync(1);
            movie.Should().NotBeNull();
            movie.MovieId.Should().Be(1);
            repo.Delete(movie);
            var success = await repo.SaveChangesAsync();
            success.Should().BeTrue();
        }
    }
}