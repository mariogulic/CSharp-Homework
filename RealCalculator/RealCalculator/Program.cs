//Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done ( +, - , * , / ). Then it returns the result.

//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the Operation: +
//Expected Output:
//The result is: 25

Console.Write("Enter the first number:");
int num1 = int.Parse(Console.ReadLine());
Console.Write("What operation would you like to use:");
string operation = Console.ReadLine();
Console.Write("Enter the second number:");
int num2 = int.Parse(Console.ReadLine());
int result = 0;
if (operation == "+")
{
    result = num1 + num2;

}
else if (operation == "-")
{
    result = num1 - num2;
}
else if (operation == "*")
{
    result = num1 * num2;
}
else if (operation == "/")
{
    result = num1 / num2;
}
else
{
    Console.WriteLine("INVALID INPUTS!!!");
}
Console.WriteLine(result);