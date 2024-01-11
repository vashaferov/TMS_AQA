using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Task3
{
    internal class Car<T>
    {
        private T Engine { get; set; }

        public Car(T engine) 
        {
            Engine = engine;
            
        }

        public void Move()
        {
            if (Engine is ElectricEngines)
                Console.WriteLine("И никуда не едем, на улице зима");
            else
                Console.WriteLine("Врум-Врум...");
        }
    }
}
