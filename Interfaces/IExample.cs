using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IExample
    {
        const int minSpeed = 0;
        static int maxSpeed = 100;

        void Move();

        string Name { get; set; }
    }
}