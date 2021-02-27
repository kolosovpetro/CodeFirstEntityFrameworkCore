using CodeFirst.Context;
using CodeFirst.Models.Models;

namespace CodeFirst.Repositories
{
    public class ClientsRepository : BaseRepository<Clients>
    {
        public ClientsRepository(BaseDbContext baseContext) : base(baseContext)
        {
        }
    }
}