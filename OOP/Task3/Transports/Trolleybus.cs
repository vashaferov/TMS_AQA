using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task3.Transports
{
    internal class Trolleybus : Transport
    {
        public string Destination { get { return destination; } set { destination = value; } }
        public string DepartureTime { get { return departureTime; } set { departureTime = value; } }
        public int Number { get { return number; } set { number = value; } }
        public int NumberSeats { get { return numberSeats; } set { numberSeats = value; } }

        public override void GetTransportType()
        {
            Console.WriteLine("Тип транспорта: Троллейбус");
        }
    }
}
