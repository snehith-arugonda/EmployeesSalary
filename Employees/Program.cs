// See https://aka.ms/new-console-template for more information
using Employees;

PermanentEmployee emp = new()
{
    Name = "slkdc",
    Salary = 12000,
};

Console.WriteLine(emp.CalculateSalaray());
Console.WriteLine(emp.CalculateBonus());

public enum EmployeeType
{
    contract,
    permanent
}

