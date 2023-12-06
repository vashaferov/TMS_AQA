using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task1
{
    internal class SquareAndRectangle : FigureType
    {
        public double a; 
        public double b;

        public SquareAndRectangle(double a, double b) : base(a, b)
        {
            this.a = a;
            this.b = b;
        }

        public override void Area()
        {
            if (a == b)
                Console.WriteLine($"Расчет площади квадрата со стороной {a}: {a * a}");
            else
                Console.WriteLine($"Расчет площади прямоугольника со сторонами {a} и {b}: {a * b}");
        }
    }
}
