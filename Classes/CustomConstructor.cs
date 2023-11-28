using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class CustomConstructor
    {
        public int sizeMain;
        public string textMain;

        public CustomConstructor(int size)
        {
            sizeMain = size;
        }

        public CustomConstructor(string text)
        {
            textMain = text;
        }

    }
}
