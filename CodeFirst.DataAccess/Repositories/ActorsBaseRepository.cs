using CodeFirst.Context;
using CodeFirst.Models.Models;

namespace CodeFirst.Repositories
{
    public class ActorsBaseRepository : BaseRepository<Actors>
    {
        public ActorsBaseRepository(BaseContext baseContext) : base(baseContext)
        {
        }
    }
}