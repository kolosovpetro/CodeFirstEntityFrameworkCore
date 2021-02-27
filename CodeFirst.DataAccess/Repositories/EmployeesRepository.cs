using CodeFirst.Context;
using CodeFirst.Models.Models;

namespace CodeFirst.Repositories
{
    public class EmployeesRepository : BaseRepository<Employees>
    {
        public EmployeesRepository(BaseDbContext baseContext) : base(baseContext)
        {
        }
    }
}