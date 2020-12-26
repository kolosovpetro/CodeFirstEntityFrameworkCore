using CodeFirst.Context;
using CodeFirst.Models.Models;

namespace CodeFirst.Repositories
{
    public class CopiesBaseRepository : BaseRepository<Copies>
    {
        public CopiesBaseRepository(BaseContext baseContext) : base(baseContext)
        {
        }
    }
}