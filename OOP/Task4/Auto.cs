using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task4
{
    internal class Auto
    {
        public string mark;
        public string number;
        public int speed;
        public int payload;

        public Auto(string mark, string number, int speed, int payload) 
        {
            this.mark = mark;
            this.number = number;
            this.speed = speed;
            this.payload = payload;
        }

        public virtual void PrintInfo(Auto auto)
        {
            string type;

            switch (auto) 
            {
                case AutoType.PassengerCar:
                {
                    Console.Write($"Тип техники: Легковая машина, ");
                    break;
                }
                case AutoType.Motorbike:
                {
                    Console.Write($"Тип техники: Мотоцикл, ");
                    break;
                }
                case AutoType.Truck:
                {
                    Console.Write($"Тип техники: Грузовик, ");
                    break;
                }
            }

            Console.Write($"Марка: {auto.mark}, Номер: {auto.number}, Скорость: {auto.speed}, ");
        }
    }
}
