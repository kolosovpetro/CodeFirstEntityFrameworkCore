using CodeFirst.Context;
using CodeFirst.Models.Models;

namespace CodeFirst.Repositories
{
    public class ActorsRepository : RepositoryBase<Actors>
    {
        public ActorsRepository(RentalContext rentalContext) : base(rentalContext)
        {
        }
    }
}