// See https://aka.ms/new-console-template for more information
using Employees;

var emp = new PermanentEmployee()
{
    Name = "slkdc",
    Salary = 12000,
};

var emp2 = new ContractEmployee()
{
    Name = "sdv",
    Salary = 11000,
};

var emp3 = new PermanentEmployee()
{
    Name = "kjhjh",
    Salary = 20000,
};

var emp4 = new Employee()
{
    Name = "rexgfch",
    Salary = 19000,
};

var emp5 = new ContractEmployee()
{
    Name = "hbjnbjb",
    Salary = 7000,
};

Console.WriteLine(emp.CalculateSalary());
Console.WriteLine(emp.CalculateBonus());
Console.WriteLine(emp2.CalculateSalary());
Console.WriteLine(emp3.CalculateBonus());
Console.WriteLine(emp4.CalculateSalary());

