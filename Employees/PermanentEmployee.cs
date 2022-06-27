namespace Employees
{
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee()
        {
            this.EmployeeType = EmployeeType.permanent;
        }

        public int BonusPercent { get; set; }

        public override int CalculateSalary()
        {
            return this.Salary;
        }

        public int CalculateBonus()
        {
            return this.BonusPercent * this.Salary / 100;
        }

        public int CalculateSalaryWithBonus()
        {
            return this.Salary + this.CalculateBonus();
        }
    }
}