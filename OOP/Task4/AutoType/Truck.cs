using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task4.AutoType
{
    internal class Truck : Auto
    {
        public bool availabilityTrailer;

        public Truck(string mark, string number, int speed, int payload, bool availabilityTrailer) : base(mark, number, speed, payload)
        {
            if (availabilityTrailer)
                this.payload = payload * 2;
            this.availabilityTrailer = availabilityTrailer;
        }

        public override void PrintInfo(Auto auto)
        {
            base.PrintInfo(auto);

            if (availabilityTrailer)                
                Console.WriteLine($"Прицеп: да, Грузоподъемность: {auto.payload}");                  
            else
                Console.WriteLine($"Прицеп: нет, Грузоподъемность: {auto.payload}");
        }
    }
}
