using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions.Task2.ExceptionsOrder
{
    internal class DeliveryInformationMissingException : Exception
    {
        public DeliveryInformationMissingException(string message) : base(message) { }
    }
}
