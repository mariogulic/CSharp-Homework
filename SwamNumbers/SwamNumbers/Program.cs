//Create new console application “SwapNumbers”. Input 2 numbers from the console and then swap the values of the variables so that the first variable has the second value and the second variable the first value. Please find example below:

//Test Data:
//Input the First Number: 5
//Input the Second Number: 8
//Expected Output:
//After Swapping:
//First Number: 8
//Second Number: 5


Console.Write("Enter first number:");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter second number:");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Number 1 is " + num1);
Console.WriteLine("Number 2 is " + num2);
num1 = num1 + num2;//num1=5+8=13 num1=13
num2 = num1 - num2;//num2=13-8=5 num2=5 slozeno malce
num1 = num1 - num2;//num1=13-5=8 num1=8
Console.WriteLine("After swaping number 1 is " + num1);
Console.WriteLine("After swaping number 2 is " + num2);