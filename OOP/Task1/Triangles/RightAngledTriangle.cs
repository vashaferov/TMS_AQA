using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task1.Triangles
{
    internal class RightAngledTriangle : Triangle
    {
        public RightAngledTriangle(double a, double b, double c) : base(a, b, c) // прямоугольный
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override void Area()
        {
            Console.WriteLine("Треугольник прямоугольный");
            double s = 0.5 * (a * b);
            Console.WriteLine($"Площадь треугольника с катетами {a} и {b}, и гипотенузой {c}: {s}");
        }
    }
}
