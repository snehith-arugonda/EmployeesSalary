namespace Employees
{
    public class PermanentEmployee : Employee
    {
        public PermanentEmployee()
        {
            this.EmployeeType = EmployeeType.Permanent;
        }

        public int BonusPercent { get; set; }

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