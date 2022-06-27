namespace Employees
{
    public class ComtractEmployee : Employee
    {
        public ComtractEmployee()
        {
            this.EmployeeType = EmployeeType.contract;
        }

        public override int CalculateSalary()
        {
            return this.Salary;
        }
    }
}

