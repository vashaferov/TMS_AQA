using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task1.Triangles
{
    internal class VersatileTriangle : Triangle
    {
        public VersatileTriangle(double a, double b, double c) : base(a, b, c) // разносторонний
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override void Area()
        {
            Console.WriteLine("Треугольник разносторонний");
            double p = (a + b + c) * 0.5;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"Площадь треугольника с катетами {a} и {b}, и гипотенузой {c}: {s}");
        }
    }
}
