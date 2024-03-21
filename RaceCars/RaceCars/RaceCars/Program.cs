using RaceCars.Models;
using System;


Racing();
static void Racing()
{
    Driver[] drivers = new Driver[]
    {
    new Driver("Bob", 8),
    new Driver("Greg", 7),
    new Driver("Jill", 9),
    new Driver("Anne", 6)

    };


    Car[] cars = new Car[]
    {
    new Car("Hyundai", 200),
    new Car("Mazda", 180),
    new Car("Ferrari", 300),
    new Car("Porsche", 250)
    };
    while (true)
    {
        Console.WriteLine("Choose a car no.1:");
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {cars[i].Model}");
        }

        bool parsingFirstCar = int.TryParse(Console.ReadLine(), out int firstCar);
        if (!parsingFirstCar || firstCar > 4 || firstCar < 0)
        {
            Console.WriteLine("Please choose number from 1 to 4");
            continue;
        }
        else
        {
            firstCar = firstCar - 1;
        }

        Console.WriteLine("Choose Driver:");
        for (int i = 0; i < drivers.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {drivers[i].Name}");
        }

        bool parsingFirstDriver = int.TryParse(Console.ReadLine(), out int firstDriver);
        if (!parsingFirstDriver || firstDriver > 4 || firstDriver < 0)
        {
            Console.WriteLine("Please choose number from 1 to 4");
            continue;
        }
        else
        {
            firstDriver = firstDriver - 1;
        }

        Console.WriteLine("Choose a car no.2:");
        for (int i = 0; i < cars.Length; i++)
        {
            if (i != firstCar)
            {
                Console.WriteLine($"{i + 1}. {cars[i].Model}");
            }
        }

        bool parsingSecondCar = int.TryParse(Console.ReadLine(), out int secondCar);
        if (!parsingSecondCar || secondCar > 3 || secondCar < 0)
        {
            Console.WriteLine("Please choose number from 1 to 3");
            continue;
        }
        else
        {
            secondCar = secondCar - 1;
        }
        Console.WriteLine("Choose Driver:");
        for (int i = 0; i < drivers.Length; i++)
        {
            if (i != firstDriver)
                Console.WriteLine($"{i + 1}. {drivers[i].Name}");

        }
        bool parsingSecondDriver = int.TryParse(Console.ReadLine(), out int secondDriver);
        if (!parsingSecondDriver || secondDriver > 3 || secondCar < 0)
        {
            Console.WriteLine("Please choose number from 1 to 4");
            continue;
        }
        else
        {
            secondDriver = secondDriver - 1;
        }
        Car car1 = cars[firstCar];
        car1.Driver = drivers[firstDriver];

        Car car2 = cars[secondCar];
        car2.Driver = drivers[secondDriver];

        Car.RaceCars(car1, car2);
        break;
    }
}



while (true)
{
    Console.WriteLine("Would you like to race again?");
    string continueAnwser = Console.ReadLine();
    if (continueAnwser.ToLower() == "yes")
    {
        Racing();
    }
    else
    {
        break;
    }
}