﻿using System;
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
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Car car1 = new Car()
            {
                Year = "2002",
                Make = "Toyota",
                Model = "Corolla",
                HasTrunk = true
            };
            Motorcycle motor1 = new Motorcycle()
            {
                Year = "2020",
                Make = "Honda",
                Model = "CBR1000RR-R Fireblade",
                HasSideCart = false
            };
            Vehicle car2 = new Car()
            {
                Year = "2012",
                Make = "Honda",
                Model = "CR-V",
                HasTrunk = true
            };
            Vehicle motor2 = new Motorcycle()
            {
                Year = "2020",
                Make = "BMW",
                Model = "F900 XR",
                HasSideCart = false
            };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(car1);
            vehicles.Add(motor1);
            vehicles.Add(car2);
            vehicles.Add(motor2);

            foreach (var v in vehicles)
            {
                Console.WriteLine(v.Year);
                Console.WriteLine(v.Make);
                Console.WriteLine(v.Model);
                Console.WriteLine();
            }

            // Call each of the drive methods for one car and one motorcycle
            Console.WriteLine("Car 1's Turn: ");
            car1.DriveAbstract();
            car1.DriveVirtual();

            Console.WriteLine("\n");
            Console.WriteLine("Motorcycle 1's Turn: ");
            motor1.DriveAbstract();
            motor1.DriveVirtual();


            #endregion
            Console.ReadLine();
        }
    }
}
