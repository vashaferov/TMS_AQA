using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Task1
{
    internal class Rectangle : Triangle
    {
        private double x, y;
        protected Rectangle() { }
        public Rectangle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override double getArea()
        {
            double s = x * y;
            return s;
        }

        public override double getPerimeter()
        {
            double p = 2 * (x + y);
            return p;
        }

        public override void Print()
        {
            Console.WriteLine($"Фигура: Прямоугольник, стороны {x} и {y}");
        }
    }
}
