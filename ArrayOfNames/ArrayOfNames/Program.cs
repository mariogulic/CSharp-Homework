//Create an array with names
//Give an option to the user to enter a name from the keyboard
//After entering the name put it in the array
//Ask the user if they want to enter another name (Y/N)
//Do the same process over and over untill the user enter N
//Print all the names after user enters N   

string[] arrayNames = new string[0];
int index = 0;

while (true)
{
    Console.WriteLine("Enter a name (or 'N' to stop):");
    string input = Console.ReadLine();

    if (input == "N")
        break;

    Array.Resize(ref arrayNames, index + 1);
    arrayNames[index] = input;
    index++;
}

Console.WriteLine("Names entered:");
foreach (string name in arrayNames)
{
    Console.WriteLine(name);
}