Queue<int> numbersQueue = new Queue<int>();
while (true)
{
    Console.WriteLine("Please enter number: ");
    int.TryParse(Console.ReadLine(), out int numberInput);
    numbersQueue.Enqueue(numberInput);
    Console.WriteLine("Would you like to continue: ");
    string continueAnswer = Console.ReadLine();
    if (continueAnswer.ToLower() == "yes")
    {
        continue;
    }
    else
    {
        break;
    }

}
foreach (int number in numbersQueue)
{
    Console.WriteLine(number);
}