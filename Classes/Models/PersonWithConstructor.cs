using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    internal class PersonWithConstructor
    {
        // =============== Блок полей (переменных) ===============\\
        public string name = "Undefined";
        public int age;

        // =============== Блок конструкторов ===============\\

        public PersonWithConstructor()
        {
            name = "name";
            age = 1;
        }

        // =============== Блок методов и свойств ===============\\
        public void Print()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        

    }
}
