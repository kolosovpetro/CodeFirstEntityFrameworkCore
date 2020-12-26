using CodeFirst.Context;
using CodeFirst.Models.Models;

namespace CodeFirst.Repositories
{
    public class StarringRepository : BaseRepository<Starring>
    {
        public StarringRepository(BaseContext baseContext) : base(baseContext)
        {
        }
    }
}