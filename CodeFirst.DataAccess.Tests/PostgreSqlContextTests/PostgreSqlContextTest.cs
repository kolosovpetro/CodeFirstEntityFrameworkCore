using System;
using System.Linq;
using CodeFirst.Factories;
using FluentAssertions;
using NUnit.Framework;

namespace CodeFirst.DataAccess.Tests.PostgreSqlContextTests
{
    [TestFixture]
    public class PostgreSqlContextTest
    {
        [Test]
        public void Postgre_Context_Test()
        {
            var factory = new PostgresDbContextFactory();
            var postgreContext = factory.CreateDbContext(Array.Empty<string>());
            var mov = postgreContext.Movies.First(x => x.MovieId == 3);
            mov.Title.Should().Be("Terminator");
        }
    }
}