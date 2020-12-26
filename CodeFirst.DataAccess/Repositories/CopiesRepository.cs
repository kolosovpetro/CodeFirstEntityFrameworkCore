using CodeFirst.Context;
using CodeFirst.Models.Models;

namespace CodeFirst.Repositories
{
    public class CopiesRepository : BaseRepository<Copies>
    {
        public CopiesRepository(BaseContext baseContext) : base(baseContext)
        {
        }
    }
}