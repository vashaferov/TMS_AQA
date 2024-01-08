using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Helper
{
    internal class EmptyInfoException : Exception
    {
        public EmptyInfoException(string message) : base(message) { }
    }
}
