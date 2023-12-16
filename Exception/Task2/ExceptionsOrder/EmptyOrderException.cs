using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Task2.ExceptionsOrder
{
    internal class EmptyOrderException : Exception
    {
        public EmptyOrderException(string message) : base(message) { }
    }
}
