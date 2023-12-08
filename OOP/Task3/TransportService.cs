using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task3
{
    internal class TransportService
    {
        public void PrintTransportType(Transport transport)
        {
            Console.WriteLine($"Тип транспорта: {TrasportType(transport)}, номер: {transport.number} пункт назначения: {transport.destination}, время отправления: {transport.departureTime}, число мест: {transport.numberSeats}");
        }

        private string TrasportType(Transport transport)
        {
            switch (transport)
            {
                case Transports.Bus:
                    return "Автобус";
                case Transports.Electric:
                    return "Электричка";
                case Transports.Rail:
                    return "Поезд";
                case Transports.Tramcar:
                    return "Трамвай";
                case Transports.Trolleybus:
                    return "Троллейбус";
                default:
                    return "Что ты такое?..";

            }
        }
    }
}
