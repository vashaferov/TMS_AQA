using Collections.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.IList
{
    internal class ListExample
    {
        public void Run()
        {
            List<string> stringList = new List<string>();
            List<string> stringList1 = new List<string>(16);

            Console.WriteLine("Capacity stringList: " + stringList.Capacity);
            Console.WriteLine("Capacity stringList1: " + stringList1.Capacity);

            stringList.Add("Первый");
            stringList.Add("Второй");
            stringList.Add("Третий");

            stringList.Insert(1, "new Первый"); // вставка элемента

            Console.WriteLine("\nСписок:");
            PrintHelper.PrintCollection(stringList);

            string tmp = stringList[2]; // получение по индексу
            Console.WriteLine("\nЭлемент с индексом 2: " + tmp);

            bool contEl = stringList.Contains("Третий"); // поиск
            Console.WriteLine("\nСписок содержит слово 'Третий': " + contEl);

            stringList.Sort(); // сортировка
            Console.WriteLine("\nКоллекция после Sort():");
            PrintHelper.PrintCollection(stringList);

            var item = stringList.BinarySearch("Первый"); // бинарный поиск
            Console.WriteLine("\nБинарный поиск 'Первы': " +  item);

            var index = stringList.IndexOf("Новый первый"); // поиск индекса
            Console.WriteLine("Поиск индекса 'Новый первый': " + index);

            //stringList.RemoveAt(1); // по индексу
            //Console.WriteLine("\nRemoveAt(1)");
            //bool result = stringList.Remove("Новый Второй"); // по значению
            //Console.WriteLine("Удаление элемента 'Новый Второй': " + result);

            stringList.Reverse(); // реверс элементов | Reverse(1, stringList.Count - 1) - в определенном диапазоне
            Console.WriteLine("\nReverse: ");
            PrintHelper.PrintCollection(stringList);

            stringList.Clear();
            Console.WriteLine("Clear, capacity: " + stringList.Capacity);
        }
    }
}
