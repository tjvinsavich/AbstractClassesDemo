using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }

        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("I'm a motorcycle that drives abstractly!");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("No no no, more specifically, I am a motorcycle that drives virtually.");
        }
    }
}
