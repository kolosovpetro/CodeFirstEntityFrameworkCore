using CodeFirst.Context;
using CodeFirst.Models.Models;

namespace CodeFirst.Repositories
{
    public class RentalsBaseRepository : BaseRepository<Rentals>
    {
        public RentalsBaseRepository(BaseContext baseContext) : base(baseContext)
        {
        }
    }
}