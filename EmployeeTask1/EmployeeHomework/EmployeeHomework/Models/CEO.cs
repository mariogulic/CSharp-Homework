namespace EmployeeHomework.Models
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double SharesPrice { get; set; }
        public CEO(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }
        public double AddSharesPrice(double sharesPrice)
        {
            SharesPrice = sharesPrice;
            return SharesPrice;
        }
        public void PrintEmployees()
        {
            Console.WriteLine("Employees:");
            foreach (Employee emp in Employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}");
            }
        }
        public override double GetSalary()
        {
            return Salary + Shares * SharesPrice;
        }
    }
}
