namespace RaceCars.Models
{
    class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public int CalculateSpeed()
        {
            return Speed * Driver.Skill;
        }

        public static void RaceCars(Car car1, Car car2)
        {
            int car1Speed = car1.CalculateSpeed();
            int car2Speed = car2.CalculateSpeed();

            if (car1Speed > car2Speed)
            {
                Console.WriteLine($"Car {car1.Model} driven by {car1.Driver.Name} was faster and was driving with{car1Speed}!!!!");
            }
            else if (car1Speed < car2Speed)
            {
                Console.WriteLine($"Car {car2.Model} driven by {car2.Driver.Name} was faster and was driving with{car2Speed}!!!!");
            }
            else
            {
                Console.WriteLine("It's a tie!!!");
            }
        }
    }

}
