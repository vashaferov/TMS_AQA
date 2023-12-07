using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task2.Doctors
{
    internal class Dentist : Doctor
    {
        public override void Heal()
        {
            Console.WriteLine("Дантист обследовал пациента и удалил ему зуб мудрости.");
            base.Heal();
        }
    }
}
