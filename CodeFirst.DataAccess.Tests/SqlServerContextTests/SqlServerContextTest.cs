using System.Linq;
using CodeFirst.Context;
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
            RentalContext postgreContext = new PostgreSqlContext();
            var mov = postgreContext.Movies.First(x => x.MovieId == 3);
            mov.Title.Should().Be("Terminator");
        }
    }
}