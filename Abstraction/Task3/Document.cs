using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Task3
{
    abstract class Document
    {
        public int numDoc;
        public DateTime date;
        protected Document() { }

        protected Document(int numDoc, DateTime date)
        {
            this.numDoc = numDoc;
            this.date = date;
        }

        public abstract void PrintInfo();
    }
}
