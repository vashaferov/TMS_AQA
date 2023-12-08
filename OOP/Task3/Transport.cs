﻿using OOP.Task3.Transports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task3
{
    internal class Transport
    {
        public string destination;
        public string departureTime;
        public int number;
        public int numberSeats;

        public virtual void GetTransportType(){ }                

        public string Destination { get { return destination; } set { destination = value; } }
        public string DepartureTime { get { return departureTime; } set { departureTime = value; } }
        public int Number { get { return number; } set { number = value; } }
        public int NumberSeats { get { return numberSeats; } set { numberSeats = value; } }
    }
}