using System;
using System.Linq;
using CodeFirst.Factories;
using FluentAssertions;
using NUnit.Framework;

namespace CodeFirst.DataAccess.Tests.SqlServerContextTests
{
    [TestFixture]
    public class SqlServerContextTest
    {
        [Test]
        public void SqlServer_Context_Test()
        {
            var factory = new SqlServerDbContextFactory();
            var sqlServerContext = factory.CreateDbContext(Array.Empty<string>());
            var mov = sqlServerContext.Movies.First(x => x.MovieId == 3);
            mov.Title.Should().Be("Terminator");
        }
    }
}