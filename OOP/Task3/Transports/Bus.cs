using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task3.Transports
{
    internal class Bus : Transport
    {
        

        public override void GetTransportType()
        {
            Console.WriteLine("Тип транспорта: Автобус");
        }
    }
}
