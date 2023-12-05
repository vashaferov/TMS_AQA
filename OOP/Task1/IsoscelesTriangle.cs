using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task1
{
    internal class IsoscelesTriangle
    {
        public double a;
        public double b;

        public IsoscelesTriangle(double a, double b) // равнобедренный 
        {
            this.a = a;
            this.b = b;
        }

        public double AreaOfTriangle()
        {
            return b / 4 * Math.Sqrt(4*Math.Pow(a, 2) - Math.Pow(b, 2));
        }
    }
}
