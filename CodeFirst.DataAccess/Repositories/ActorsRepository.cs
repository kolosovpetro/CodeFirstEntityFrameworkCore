using CodeFirst.Context;
using CodeFirst.Models.Models;

namespace CodeFirst.Repositories
{
    public class ActorsRepository : BaseRepository<Actors>
    {
        public ActorsRepository(BaseDbContext baseContext) : base(baseContext)
        {
        }
    }
}