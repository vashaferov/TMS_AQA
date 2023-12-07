using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task2.Doctors
{
    internal class Therapist : Doctor
    {
        public override void Heal()
        {
            Console.WriteLine("Терапевт обследовал пациента и назначил ему нужные лекарства.");
            base.Heal();
        }
    }
}
