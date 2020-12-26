using CodeFirst.Context;
using CodeFirst.Models.Models;

namespace CodeFirst.Repositories
{
    public class EmployeesRepository : RepositoryBase<Employees>
    {
        public EmployeesRepository(RentalContext rentalContext) : base(rentalContext)
        {
        }
    }
}