using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Task3
{
    internal abstract class Engines
    {
    }

    internal class DieselEngines: Engines
    {
    }

    internal class PetrolEngines: DieselEngines
    {
    }

    internal class ElectricEngines : PetrolEngines
    {
    }
}
