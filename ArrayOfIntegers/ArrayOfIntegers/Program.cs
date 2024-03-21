//Declare a new array of integers with 5 elements
//Initialize the array elements with values from input
//Sum all the values and print the result in the console

int[] integerArray = new int[5];
int sumOfNumbers = 0;
for (int i = 0; i < 5; i++)
{
    Console.Write("Enter number for the array:");
    integerArray[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < integerArray.Length; i++)
{
    sumOfNumbers += integerArray[i];
}
Console.WriteLine(sumOfNumbers);