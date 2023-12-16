using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Collections
{
    internal class Persons
    {
        public string FirstName { get; set; }
        public string LasttName { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Persons persons &&
                   FirstName == persons.FirstName &&
                   LasttName == persons.LasttName;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FirstName, LasttName);
        }
    }

}
