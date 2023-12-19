using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Task1
{
    internal class EmptyBookInfoException : Exception
    {
        public EmptyBookInfoException(string message) : base(message) { }
    }
}
