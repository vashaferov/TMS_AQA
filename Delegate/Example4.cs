using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Example4
    {
        public delegate void NoParameters();

        public void Run()
        {
            NoParameters noPrm = delegate
            {
                Console.WriteLine("Have fun!");
            };

            noPrm();
        }
    }
}