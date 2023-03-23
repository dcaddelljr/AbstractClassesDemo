using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 
           
            var vehicles = new List<Vehicle>();
         
            var car1 = new Car(){ HasTrunk = true, Year = "2023", Make = "Chevy", Model = "Cobalt", };

            var motorcylce1 = new Motorcycle() { HasSideCar = true, Year = "2021", Make = "Yamaha", Model = "Supersport", };

            Vehicle car2 = new Car() { Year = "2020", Make = "Ford", Model = "F150", HasTrunk = false}; //explicit using the Vehicle class

            Vehicle motorcycle2 = new Motorcycle() { Year = "2016", Make = "Kawasaki", Model = "Ninja", HasSideCar = false};

            vehicles.Add(car1);
            vehicles.Add(motorcylce1);
            vehicles.Add(car2);
            vehicles.Add(motorcycle2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine();
                
            }
            #endregion            
            Console.ReadLine();
        }
    }
}
