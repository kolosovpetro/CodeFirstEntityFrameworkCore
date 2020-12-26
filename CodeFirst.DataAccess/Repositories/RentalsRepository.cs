using CodeFirst.Context;
using CodeFirst.Models.Models;

namespace CodeFirst.Repositories
{
    public class RentalsRepository : BaseRepository<Rentals>
    {
        public RentalsRepository(BaseContext baseContext) : base(baseContext)
        {
        }
    }
}