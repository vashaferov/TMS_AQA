using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task4.AutoType
{
    internal class PassengerCar : Auto
    {
        public PassengerCar(string mark, string number, int speed, int payload) : base(mark, number, speed, payload)
        {
        }

        public override void PrintInfo(Auto auto)
        {
            base.PrintInfo(auto);
            Console.WriteLine($"Грузоподъемность: {auto.payload}");
        }
    }
}
