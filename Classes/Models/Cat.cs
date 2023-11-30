using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    internal class Cat
    {
        public string name;
        public int age;
        public int maxFood;

        public bool Feed(int foodCount)
        {
            return foodCount >= maxFood;
        }

    }
}
