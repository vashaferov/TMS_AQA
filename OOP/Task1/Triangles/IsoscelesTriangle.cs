using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task1.Triangles
{
    internal class IsoscelesTriangle : Triangle
    {

        public IsoscelesTriangle(double a, double b, double c) : base(a, b, c) // равнобедренный 
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override void Area()
        {
            Console.WriteLine("Треугольник равнобедренный");
            double s = b / 4 * Math.Sqrt(4 * Math.Pow(a, 2) - Math.Pow(b, 2));
            Console.WriteLine($"Площадь треугольника с катетами {a} и {b}, и гипотенузой {c}: {s}");
        }
    }
}
