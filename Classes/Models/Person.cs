using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Person
    {
        // =============== Блок полей (переменных) ===============\\
        public string name = "Undefined";
        public int age;

        // =============== Блок методов и свойств ===============\\
        public void Print()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        // =============== Блок конструкторов ===============\\


    }
}
