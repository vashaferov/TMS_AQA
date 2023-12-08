using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task4.AutoType
{
    internal class Motorbike : Auto
    {
        public bool availabilityStroller;

        public Motorbike(string mark, string number, int speed, int payload, bool availabilityStroller) : base(mark, number, speed, payload)
        {
            if (!availabilityStroller)
                this.payload = 0;
            this.availabilityStroller = availabilityStroller;
        }

        public override void PrintInfo(Auto auto)
        {
            base.PrintInfo(auto);

            if (availabilityStroller)
                Console.WriteLine($"Коляска: да, Грузоподъемность: {auto.payload}");
            else
                Console.WriteLine($"Коляска: нет, Грузоподъемность: {auto.payload}");                
        }
    }
}
