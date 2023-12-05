using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task1
{
    internal class EquilateralTriangle : Triangle // равносторонний
    {
        

        public EquilateralTriangle()
        {
            
        }

        public double AreaOfTriangle()
        {
            return Math.Sqrt(3) / 4 * Math.Pow(a, 2);
        }
    }
}
