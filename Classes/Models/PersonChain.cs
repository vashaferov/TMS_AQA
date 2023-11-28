using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    internal class PersonChain
    {
        public string name;
        public int age;

        public PersonChain() : this("caasd")
        {

        }

        public PersonChain(string name) : this(name, 18)
        {

        }

        public PersonChain(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
}
