using CodeFirst.Context;
using CodeFirst.Models.Models;

namespace CodeFirst.Repositories
{
    public class MoviesBaseRepository : BaseRepository<Movies>
    {
        public MoviesBaseRepository(BaseContext baseContext) : base(baseContext)
        {
        }
        
        
    }
}