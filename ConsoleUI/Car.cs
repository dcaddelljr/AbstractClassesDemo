using System;
namespace ConsoleUI
{
	public class Car : Vehicle //Derived (Child) Class
	{
		public Car()
		{
		}

        public bool HasTrunk { get; set; }

        public override void DriveAbstract()
        {
            //Console.WriteLine("Car is Driveable.");
            Console.WriteLine($"This {GetType().Name} is abstractly in drive.");
            Console.WriteLine($"Has Trunk?: {HasTrunk}");
        }
    }
}

