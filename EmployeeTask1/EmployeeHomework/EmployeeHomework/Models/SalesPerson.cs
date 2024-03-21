namespace EmployeeHomework.Models
{
    public class SalesPerson : Employee
    {
        public SalesPerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = Role.Sales;
            Salary = 500;
        }
    }
}
