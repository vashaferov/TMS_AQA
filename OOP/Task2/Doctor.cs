using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task2
{
    internal class Doctor
    {
        public Doctor() { }

        public virtual void Heal()
        {
            Console.WriteLine("Пациент здоров!");
        }
    }
}
