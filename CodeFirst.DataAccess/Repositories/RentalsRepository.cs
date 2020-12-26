using CodeFirst.Context;
using CodeFirst.Models.Models;

namespace CodeFirst.Repositories
{
    public class RentalsRepository : RepositoryBase<Rentals>
    {
        public RentalsRepository(RentalContext rentalContext) : base(rentalContext)
        {
        }
    }
}