using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle //Derived (Child) Class
    {
		public Motorcycle()
		{
		}

        public bool HasSideCar { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcylce can drive.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Motorcylce does drive virtual.");
            Console.WriteLine($"Has Side Car?: {HasSideCar}");
        }
    }
}

