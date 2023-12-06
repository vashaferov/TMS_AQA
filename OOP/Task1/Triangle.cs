using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP.Task1.Triangles;

namespace OOP.Task1
{
    internal class Triangle : FigureType
    {
        public double a;
        public double b;
        public double c;

        public Triangle(double a, double b, double c) : base(a, b, c)
        {
            double temp;

            if (a > c)
            {
                temp = c; 
                c = a; 
                a = temp;
            }
            if (b > c)
            {
                temp = c; 
                c = b; 
                b = temp;
            }

            this.a = a;
            this.b = b;
            this.c = c;
            
        }
        
        public FigureType CheckTriangle()
        {
            if (a == b && a == c) // равносторонний 
            {
                EquilateralTriangle equilateralTriangle = new EquilateralTriangle(a, b, c);
                return equilateralTriangle;
            }
            else if (a == b || a == c || b == c) // равнобедренный
            {
                IsoscelesTriangle isoscelesTriangle = new IsoscelesTriangle(a, b, c);                
                return isoscelesTriangle;
            }
            else if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2)) // прямоугольный
            {
                RightAngledTriangle rightAngledTriangle = new RightAngledTriangle(a, b, c);                
                return rightAngledTriangle;
            }
            else // разносторонний
            {
                VersatileTriangle versatileTriangle = new VersatileTriangle(a, b, c);                
                return versatileTriangle;
            }
        }
    }
}
