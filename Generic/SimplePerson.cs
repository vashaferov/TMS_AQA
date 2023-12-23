using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class SimplePerson
    {
        public int Id { get; }
        public string Name { get; }

        public SimplePerson(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
