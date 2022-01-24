using CodeFirst.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.DataAccess.Repositories
{
    public class CopiesRepository : BaseRepository<Copies>
    {
        public CopiesRepository(DbContext baseContext) : base(baseContext)
        {
        }
    }
}