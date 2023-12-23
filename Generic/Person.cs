using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Person<T, K>
    {
        public T Id { get; }
        public K Code { get; set; }
        public string Name { get; }

        public Person(T id, K code, string name)
        {
            Id = id;
            Name = name;
            Code = code;
        }
    }
}
