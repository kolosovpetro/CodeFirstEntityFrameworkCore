using CodeFirst.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.DataAccess.Repositories
{
    public class MoviesRepository : BaseRepository<Movies>
    {
        public MoviesRepository(DbContext baseContext) : base(baseContext)
        {
        }
    }
}