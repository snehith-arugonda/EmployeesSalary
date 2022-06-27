// See https://aka.ms/new-console-template for more information
using Employees;

var emp = new PermanentEmployee()
{
    Name = "slkdc",
    Salary = 12000,
};

Console.WriteLine(emp.CalculateSalary());
Console.WriteLine(emp.CalculateBonus());

public enum EmployeeType
{
    contract,
    permanent
}

