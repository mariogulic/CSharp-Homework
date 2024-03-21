using Task3Exercise.MyClasses;
Users[] users = new Users[] {
 new Users()
{
    FirstName = "Bob",
    LastName = "Bobsky",
    CardNumber = "1234-1234-1234-1234",
},
 new Users()
{
    FirstName = "John",
    LastName = "Johnsky",
    CardNumber = "4321-4321-4321-4321",
},
  new Users()
{
    FirstName = "Jill",
    LastName = "Owen",
    CardNumber = "9999-9999-9999-9999",
},
 new Users()
{
    FirstName = "Michale",
    LastName = "Jordan",
    CardNumber = "2323-2323-2323-2323",
}
};
Users bob = users[0];
bob.GivingPin(1234);
bob.GivingBalance(10000);
Users john = users[1];
john.GivingPin(4321);
john.GivingBalance(41784.321);
Users jill = users[2];
jill.GivingPin(9999);
jill.GivingBalance(3122.321);
Users michael = users[3];
michael.GivingPin(2323);
michael.GivingBalance(312312.12);

Console.WriteLine("Would you like to Login or Register:");
string firstAnswer = Console.ReadLine();

if (firstAnswer.ToLower() == "login")
{
    Login(users);
}
else if (firstAnswer.ToLower() == "register")
{
    Register(users);
}
else
{
    Console.WriteLine("Invalid choice.");
}





#region Methods
static void Register(Users[] users)
{
    Console.Write("Enter First Name:");
    string newFirstName = Console.ReadLine();
    Console.Write("Enter Last Name:");
    string newLastName = Console.ReadLine();
    Console.Write("Enter card number:");
    string newCardNumberToFormat = Console.ReadLine();
    newCardNumberToFormat.Replace(" ", "");
    string newCardNumber = string.Format("{0:####-####-####-####}", long.Parse(newCardNumberToFormat));
    foreach (Users user in users)
    {
        int index = 0;
        index++;
        if (user.FirstName == newFirstName && user.LastName == newLastName && user.CardNumber == newCardNumber)
        {
            Console.WriteLine("User already exists!!");
        }
        else
        {
            Array.Resize(ref users, users.Length + index);
            users[users.Length - 1] = new Users
            {
                FirstName = newFirstName,
                LastName = newLastName,
                CardNumber = newCardNumber,
            };
            Console.Write("Enter your pin:");
            int newPin = int.Parse(Console.ReadLine());
            users[users.Length - 1].GivingPin(newPin);
            users[users.Length - 1].GivingBalance(0);
            Console.WriteLine("Registration successful!");
            Console.WriteLine("Would you like to login?");
            string continueAnswer = Console.ReadLine();
            if (continueAnswer.ToLower() == "yes")
            {
                Login(users);
            }
        }
    }
}

static void Login(Users[] users)
{
    while (true)
    {
        Console.WriteLine("Please enter your card number:");
        string cardNumberToFormat = Console.ReadLine();
        cardNumberToFormat.Replace(" ", "");
        string cardNumber = string.Format("{0:####-####-####-####}", long.Parse(cardNumberToFormat));
        Console.Write("Please enter your PIN:");
        int pin = int.Parse(Console.ReadLine());
        Users foundUser = FindUser(cardNumber, pin, users);
        if (foundUser != null)
        {
            foundUser.Greeting();
            Console.WriteLine("1)Balance checking, 2)Cash Withdrawal, 3)Cash Deposition");
            string inputChoice = Console.ReadLine();
            switch (inputChoice)
            {
                case "1":
                    BalanceChecking(foundUser);
                    break;
                case "2":
                    CashWithdrawal(foundUser);
                    break;
                case "3":
                    CashDeposit(foundUser);
                    break;
                default:
                    Console.WriteLine("Invalid Choice! Try again.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("User not found");
        }
        Console.Write("Would you like to continue?");
        string continueAnswer = Console.ReadLine();
        if (continueAnswer.ToLower() == "yes")
        {
            continue;
        }
        else
        {
            Environment.Exit(0);
        }
    }
}

static Users FindUser(string cardNumber, int pin, Users[] users)
{
    foreach (Users user in users)
    {
        if (user.CardNumber == cardNumber && user.GetPin() == pin)
        {
            return user;
        }
    }
    return null;
}

static void BalanceChecking(Users foundUser)
{
    Console.WriteLine($"Your balance is: {foundUser.GetBalance()}");
}

static void CashWithdrawal(Users foundUser)
{
    Console.Write("How much would you like to withdraw:");
    double withdrawValue = double.Parse(Console.ReadLine());
    if (withdrawValue <= foundUser.GetBalance())
    {
        foundUser.Withdraw(withdrawValue);
        Console.WriteLine($"Withdrawal successful. Remaining balance: {foundUser.GetBalance()}");
    }
    else
    {
        Console.WriteLine("Insufficient funds!");
    }
}


static void CashDeposit(Users foundUser)
{
    Console.Write("How much would you like to deposit:");
    double depositValue = double.Parse(Console.ReadLine());
    foundUser.Deposit(depositValue);
    Console.WriteLine($"Deposit successful. Your new balance is {foundUser.GetBalance()}");
}

#endregion
