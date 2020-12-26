namespace CodeFirst.Models.Models
{
    public class Employees
    {
        public int EmployeeId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public float? Salary { get; set; } // yeah, salary might be nullable, why not :)
        public string City { get; set; }
    }
}