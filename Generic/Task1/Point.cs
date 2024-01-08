using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Task1
{
    internal class Point<T>
    {
        private T x;
        private T y;

        public T X { get => x; }
        public T Y { get => y; }

        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine($"X: {x}, Y: {y}");
        }
    }
}
