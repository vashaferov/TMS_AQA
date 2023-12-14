using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.IDictionary
{
    internal class DictionaryExample
    {
        public void Run()
        {
            // создание
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            myDictionary.Add("a", 1);
            myDictionary.Add("b", 2);
            myDictionary.Add("c", 3);

            // проверка наличия
            bool contKey = myDictionary.ContainsKey("a");
            bool contVal = myDictionary.ContainsValue(1);
            Console.WriteLine("ContainsKey 'a': " + contKey + "\nContainsValue '1': " + contVal);

            // получение значения
            int result1 = myDictionary["b"];
            Console.WriteLine("Key 'b': " + result1);

            // удаление
            myDictionary.Remove("c");

            // очистка
            myDictionary.Clear();
        }

    }
}
