using CodeFirst.Context;
using CodeFirst.Models.Models;

namespace CodeFirst.Repositories
{
    public class RentalsRepository : BaseRepository<Rentals>
    {
        public RentalsRepository(BaseDbContext baseContext) : base(baseContext)
        {
        }
    }
}