using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Person
    {
        // Свойства
        private string name;

        public string Name
        {
            get // чтение 
            { 
                return name; 
            }
            set // запись
            { 
                name = value; 
            } 
        }

        public string Age { get; set; } // автоматическое свойство, сам создаст переменную

        public string ID { get; init; } = "xxx - 715";
        public Person(string id) => ID = id; 
    }
}
