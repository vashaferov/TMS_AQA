using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Task1
{
    internal class Circle : Rectangle
    {
        private double r;

        protected Circle() {}
        public Circle(double r)
        {
            this.r = r;
        }

        public override double getArea()
        {
            double s = Math.PI * Math.Pow(r, 2);
            return s;
        }

        public override double getPerimeter()
        {
            double p = 2 * Math.PI * r;
            return p;
        }

        public override void Print()
        {
            Console.WriteLine($"Фигура: Круг, радиус {r}");
        }
    }
}
