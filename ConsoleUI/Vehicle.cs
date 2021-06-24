using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{         
    public abstract class Vehicle
    {
        public Vehicle()
        {
        }

        public string Year { get; set; } = "2003";
        public string Make { get; set; } = "Honda";
        public string Model { get; set; } = "Civic";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("Wow, look at this vehicle drive virtually!");
        }
        
    }
}
