using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task2
{
    internal class Patient
    {
        public string name;
        public int age;
        public int treatmentPlan;
        public string doctor;

        public Patient(string name, int age, int treatmentPlan)
        {
            this.name = name;
            this.age = age;
            this.treatmentPlan = treatmentPlan;
        }
    }
}
