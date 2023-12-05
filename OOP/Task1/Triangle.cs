using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task1
{
    internal class Triangle // базовый класс
    {
        public double a;
        public double b;
        public double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            if (a == b && a == c) // равносторонний 
            {
                
            } else if (a == b || a == c || b == c) // равнобедренный
            {

            } else if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2)) // прямоугольный
            {

            }
            else // разносторонний
            {

            }
        }
    }
}
