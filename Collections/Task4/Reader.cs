using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Task4
{
    internal class Reader
    {
        private string name;
        private Guid libraryCardNumber;

        public Reader(string name, Guid libraryCardNumber) 
        { 
            this.name = name;
            this.libraryCardNumber = libraryCardNumber;
        }

        public string Name { get => name; }
        public string LibraryCardNumber { get => libraryCardNumber.ToString(); }
    }
}
