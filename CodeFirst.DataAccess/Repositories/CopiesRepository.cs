using CodeFirst.Context;
using CodeFirst.Models.Models;

namespace CodeFirst.Repositories
{
    public class CopiesRepository : RepositoryBase<Copies>
    {
        public CopiesRepository(RentalContext rentalContext) : base(rentalContext)
        {
        }
    }
}