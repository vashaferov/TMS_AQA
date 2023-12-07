using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.FinalExample
{
    internal abstract class Test
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public abstract void Run();
    }
}
