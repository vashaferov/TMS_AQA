using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate.Task1
{
    internal class DelegateForRandomNumbers
    {
        public delegate int Randoms();

        public void Run()
        {
            Randoms randoms = RandomNumber;
            int r = randoms();

            Console.WriteLine($"Рандомное число: {r}");           
        }

        private int RandomNumber()
        {
            Random r = new Random();
            
            return r.Next(10);
        }
    }
}
