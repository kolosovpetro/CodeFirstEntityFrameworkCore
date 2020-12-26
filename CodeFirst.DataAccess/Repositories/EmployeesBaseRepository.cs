using CodeFirst.Context;
using CodeFirst.Models.Models;

namespace CodeFirst.Repositories
{
    public class EmployeesBaseRepository : BaseRepository<Employees>
    {
        public EmployeesBaseRepository(BaseContext baseContext) : base(baseContext)
        {
        }
    }
}