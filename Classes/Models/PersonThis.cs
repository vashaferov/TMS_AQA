using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    internal class PersonThis
    {
        // =============== Блок полей (переменных) ===============\\
        public string name = "Undefined";
        public int age;

        // =============== Блок конструкторов ===============\\

        public PersonThis()
        {
            name = "name";
            age = 1;
        }

        public PersonThis(string name)
        {
            this.name = name;
            age = 18;
        }

        public PersonThis(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // =============== Блок методов и свойств ===============\\
        public void Print()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
}
