using CodeFirst.Context;
using CodeFirst.Models.Models;

namespace CodeFirst.Repositories
{
    public class ClientsRepository : RepositoryBase<Clients>
    {
        public ClientsRepository(RentalContext rentalContext) : base(rentalContext)
        {
        }
    }
}