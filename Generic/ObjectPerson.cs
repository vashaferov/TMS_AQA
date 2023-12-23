using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class ObjectPerson
    {
        public object Id { get; }
        public string Name { get; }

        public ObjectPerson(object id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
