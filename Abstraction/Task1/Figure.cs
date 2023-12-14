using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Task1
{
    internal abstract class Figure
    {
        protected Figure() { }
        public abstract double getPerimeter();
        public abstract double getArea();
        public abstract void Print();
    }
}
