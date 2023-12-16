using Collections.Helper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.IList
{
    internal class SortedListExample
    {
        public void Run()
        {
            SortedList<string, int> mySortedList = new SortedList<string, int>();

            mySortedList.Add("a", 1);
            mySortedList.Add("c", 3);
            mySortedList.Add("b", 2);

            Console.WriteLine("Sorted List:");
            PrintHelper.PrintCollection(mySortedList);

            bool containsKey = mySortedList.ContainsKey("a");
            bool containsValue = mySortedList.ContainsValue(1);
        }
    }
}
