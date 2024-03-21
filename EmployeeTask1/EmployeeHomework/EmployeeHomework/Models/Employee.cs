namespace EmployeeHomework.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public virtual double GetSalary()
        {
            return Salary;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"FirstName: {FirstName} LastName: {LastName} Salary: {GetSalary()}");
        }
    }
}
