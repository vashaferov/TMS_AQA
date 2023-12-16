using Collections.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.ISet
{
    internal class HashSetExample
    {
        public void Run()
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("A");
            set.Add("B");
            set.Add("C");
            set.Add("A");

            PrintHelper.PrintCollection(set);

            
        }
    }
}
