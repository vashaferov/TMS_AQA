using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Task2.ExceptionsOrder
{
    internal class InvalidOrderNumberException : Exception
    {
        public InvalidOrderNumberException(string message) : base(message) { }
    }
}
