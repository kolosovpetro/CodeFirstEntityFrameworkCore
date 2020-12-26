using CodeFirst.Context;
using CodeFirst.Models.Models;

namespace CodeFirst.Repositories
{
    public class MoviesRepository : BaseRepository<Movies>
    {
        public MoviesRepository(BaseContext baseContext) : base(baseContext)
        {
        }
    }
}