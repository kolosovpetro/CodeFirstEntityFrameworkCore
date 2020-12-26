using CodeFirst.Context;
using CodeFirst.Models.Models;

namespace CodeFirst.Repositories
{
    public class StarringRepository : RepositoryBase<Starring>
    {
        public StarringRepository(RentalContext rentalContext) : base(rentalContext)
        {
        }
    }
}