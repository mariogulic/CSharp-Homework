
namespace Task3Exercise.MyClasses
{
    public class Users
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardNumber { get; set; }
        private int Pin { get; set; }
        private double Balance { get; set; }

        public void Greeting()
        {
            Console.WriteLine($"Hello {FirstName} {LastName}.");
        }
        public void GivingPin(int pin)
        {
            Pin = pin;
        }
        public void GivingBalance(double balance)
        {
            Balance = balance;
        }
        public int GetPin()
        {
            return Pin;
        }

        public double GetBalance()
        {
            return Balance;
        }
        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
