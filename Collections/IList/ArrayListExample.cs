using Collections.Helper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.IList
{
    internal class ArrayListExample
    {
        public void Run()
        {
            ArrayList stringList = new ArrayList();

            stringList.Add("Первый");
            stringList.Add("Второй");
            stringList.Add("Третий");

            ArrayList stringList1 =
            [
                "Первый",
                2,
                false,
                new StringBuilder("obj")
            ];

            Console.WriteLine("Элементы stringList:");
            PrintHelper.PrintCollection(stringList);

            Console.WriteLine("\nЭлементы stringList1:");
            PrintHelper.PrintCollection(stringList1);
        }
    }
}
