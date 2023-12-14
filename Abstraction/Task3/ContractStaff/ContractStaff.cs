using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Task3.ContractStaff
{
    internal class ContractStaff : Document
    {
        private DateTime dateEnd;
        private string name;
        public ContractStaff() { }

        public ContractStaff(int numDoc, DateTime date, DateTime dateEnd, string name) : base(numDoc, date)
        {
            this.dateEnd = dateEnd;
            this.name = name;
        }
    }
}
