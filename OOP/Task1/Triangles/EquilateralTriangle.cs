using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task1.Triangles
{
    internal class EquilateralTriangle : Triangle // равносторонний
    {
        public EquilateralTriangle(double a, double b, double c) : base(a, b, c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override void Area()
        {
            Console.WriteLine("Треугольник равносторонний");
            double s = Math.Sqrt(3) / 4 * Math.Pow(a, 2);
            Console.WriteLine($"Площадь треугольника с катетами {a} и {b}, и гипотенузой {c}: {s}");
        }
    }
}
