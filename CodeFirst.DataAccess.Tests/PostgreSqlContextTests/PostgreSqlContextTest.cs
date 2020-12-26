using System.Linq;
using CodeFirst.Context;
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
            BaseContext postgreContext = new PostgreSqlContext();
            var mov = postgreContext.Movies.First(x => x.MovieId == 3);
            mov.Title.Should().Be("Terminator");
        }
    }
}