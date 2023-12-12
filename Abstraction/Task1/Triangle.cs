using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Task1
{
    internal class Triangle : Figure
    {
        double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a; 
            this.b = b; 
            this.c = c;
        }

        public override double getArea()
        {
            double pp = 0.5 * getPerimeter();
            double s = Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));
            return Math.Round(s);
        }

        public override double getPerimeter()
        {
            double p = a + b + c;
            return Math.Round(p);
        }

        public override void Print()
        {
            Console.WriteLine($"Фигура: Треугольник, стороны {a}, {b} и {c}");
        }
    }
}
