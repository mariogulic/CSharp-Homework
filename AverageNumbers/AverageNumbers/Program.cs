//Create new console application “AverageNumber” that takes four numbers as input to calculate and print the average.
//Test Data:
//Enter the First number: 10
//Enter the Second number: 15
//Enter the third number: 20
//Enter the four number: 30
//Expected Output:
//The average of 10, 15, 20 and 30 is: 18


Console.Write("Enter the first number:");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter the second number:");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Enter the third number:");
int num3 = int.Parse(Console.ReadLine());
Console.Write("Enter the fourth number:");
int num4 = int.Parse(Console.ReadLine());
int result = (num1 + num2 + num3 + num4) / 4;
Console.WriteLine(result);