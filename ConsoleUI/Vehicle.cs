using System;
namespace ConsoleUI
{
    public abstract class Vehicle //Base (Parent) Class
    {
        public Vehicle()
        {
        }
        public string Year { get; set; } = "Default Year";
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            //Console.WriteLine("The car does drive virtual");
            Console.WriteLine($"This {GetType().Name} is virtually driving.");
        }
    }
}

