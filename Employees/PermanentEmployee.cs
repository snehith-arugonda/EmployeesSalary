using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees;

public class PermanentEmployee : Employee
{
    public int BonusPercant { get; set; } = 10;
    public PermanentEmployee()
    {
        EmployeeType = EmployeeType.permanent;
    }

    public override int CalculateSalaray()
    {
        return this.Salary;
    }

    public int CalculateBonus()
    {
        return this.BonusPercant * this.Salary / 100;
    }

    public int CalculateSalaryWithBonus()
    {
        return this.Salary + this.CalculateBonus();
    }

}

