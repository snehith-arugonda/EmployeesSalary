using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees;

public class ComtractEmployee : Employee
{
    public ComtractEmployee()
    {
        EmployeeType = EmployeeType.contract;
    }
    public override int CalculateSalaray()
    {
        return this.Salary;
    }
}

