//Make a console application called SumOfEven. Inside it create an array of 6 integers. Get numbers from the input, find and print the sum of the even numbers from the array:

//Test Data:
//Enter integer no.1:
//4
//Enter integer no.1:
//3
//Enter integer no.1:
//7
//Enter integer no.1:
//3
//Enter integer no.1:
//2
//Enter integer no.1:
//8
//Expected Output:
//The result is: 14
Console.Write("Enter the first number: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Enter the second number: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Enter the third number: ");
int num3 = int.Parse(Console.ReadLine());
Console.Write("Enter the fourth number: ");
int num4 = int.Parse(Console.ReadLine());
Console.Write("Enter the fifth number: ");
int num5 = int.Parse(Console.ReadLine());
Console.Write("Enter the sixth number: ");
int num6 = int.Parse(Console.ReadLine());
int[] sumOfEven = { num1, num2, num3, num4, num5, num6 };
int sumOfNumbers = 0;
for (int i = 0; i < sumOfEven.Length; i++)
{
    if (sumOfEven[i] % 2 == 0)
    {
        sumOfNumbers += sumOfEven[i];
    }
}
Console.Write(sumOfNumbers);