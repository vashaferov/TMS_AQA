using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task2.Doctors
{
    internal class Surgeon : Doctor
    {
        public override void Heal()
        {
            Console.WriteLine("Хирург обследовал пациента и назначил ему операцию. Операция прошла успешно.");
            base.Heal();
        }
    }
}
