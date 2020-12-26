using CodeFirst.Context;
using CodeFirst.Models.Models;

namespace CodeFirst.Repositories
{
    public class ClientsBaseRepository : BaseRepository<Clients>
    {
        public ClientsBaseRepository(BaseContext baseContext) : base(baseContext)
        {
        }
    }
}