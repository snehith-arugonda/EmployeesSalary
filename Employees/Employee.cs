namespace Employees
{
    public class Employee
    {
        private static int SerialId = 0;

        public int EmployeeId { get; } = ++SerialId;

        public string Name { get; set; }

        public int Salary { get; set; }

        public EmployeeType EmployeeType { get; protected set; }

        public int CalculateSalary()
        {
            return this.Salary;
        }
    }
}

