using CodeFirst.Context;
using CodeFirst.Models.Models;

namespace CodeFirst.Repositories
{
    public class MoviesRepository : RepositoryBase<Movies>
    {
        public MoviesRepository(RentalContext rentalContext) : base(rentalContext)
        {
        }
        
        
    }
}