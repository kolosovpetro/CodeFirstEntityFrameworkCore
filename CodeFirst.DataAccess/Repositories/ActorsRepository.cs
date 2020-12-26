using CodeFirst.Context;
using CodeFirst.Models.Models;

namespace CodeFirst.Repositories
{
    public class ActorsRepository : BaseRepository<Actors>
    {
        public ActorsRepository(BaseContext baseContext) : base(baseContext)
        {
        }
    }
}