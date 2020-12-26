using CodeFirst.Context;
using CodeFirst.Models.Models;

namespace CodeFirst.Repositories
{
    public class StarringBaseRepository : BaseRepository<Starring>
    {
        public StarringBaseRepository(BaseContext baseContext) : base(baseContext)
        {
        }
    }
}