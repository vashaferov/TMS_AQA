using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task1
{
    internal class FigureType
    {
        public double a;
        public double b;
        public double c;

        public FigureType(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public FigureType(double a, double b, double c) : this(a, b)
        {
            this.c = c;
        }

        public virtual void Area()
        {
            Console.WriteLine("Расчет площади");
        }
    }
}
