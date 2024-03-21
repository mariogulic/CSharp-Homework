using EmployeeHomework.Models;

Manager bob = new Manager("Bob", "Bobsky", 1232.32, "HR");
Manager john = new Manager("John", "Johnsky", 1450, "HR");

SalesPerson tony = new SalesPerson("Tony", "Tonsky");
SalesPerson brian = new SalesPerson("Brian", "Briansky");
Contractor cole = new Contractor()
{
    FirstName = "Cole",
    LastName = "Colesky",
    WorkHours = 45,
    PayPerHour = 20,
    Responsible = bob
};
Contractor jane = new Contractor()
{
    FirstName = "Jane",
    LastName = "Janesky",
    WorkHours = 40,
    PayPerHour = 25,
    Responsible = john
};

tony.GetSalary();
brian.GetSalary();
cole.GetSalary();
jane.GetSalary();
Console.WriteLine(cole.CurrentPosition());
Console.WriteLine(jane.CurrentPosition());
tony.PrintInfo();
bob.PrintInfo();
bob.AddBonus(300);
bob.PrintInfo();
john.PrintInfo();
brian.PrintInfo();
cole.PrintInfo();
jane.PrintInfo();

//Task2

Employee[] Company = { cole, jane, bob, john, tony };

CEO mario = new CEO("Mario", "Gulicoski", 10000)
{
    Employees = Company,
    Shares = 100,
};

mario.AddSharesPrice(100);
mario.PrintInfo();
mario.GetSalary();
mario.PrintEmployees();