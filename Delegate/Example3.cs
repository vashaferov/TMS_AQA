using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Example3
    {
        public delegate void Notification();

        public void Run()
        {
            Notification noPrm = ShowMessage1;

            noPrm += ShowMessage2;

            noPrm.Invoke();
        }

        private void ShowMessage1() => Console.WriteLine("Have fun!");

        private void ShowMessage2() => Console.WriteLine("See you!");
    }
}