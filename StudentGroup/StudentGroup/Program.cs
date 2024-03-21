﻿//Make a new console application called StudentGroup
//Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names.
//Get a number from the console between 1 and 2 and print the students from that group in the console.
//Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
//Test Data:
//Enter student group: (there are 1 and 2 )
//1
//Expected Output:
//The Students in G1 are:
//Zdravko
//Petko
//Stanko
//Branko
//Trajko

string[] firstGroup = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
string[] secondGroup = { "Angel", "Krume", "Kristijan", "Borce", "Mitre" };
Console.Write("Would you like to see group 1 or group 2?");
int selectGroup = int.Parse(Console.ReadLine());
if (selectGroup == 1)
{
    foreach (string student in firstGroup)
    {
        Console.WriteLine(student);
    }
}
else if (selectGroup == 2)
{
    foreach (string student in secondGroup)
    {
        Console.WriteLine(student);
    }
}
else
{
    Console.WriteLine("Invalid input");
}