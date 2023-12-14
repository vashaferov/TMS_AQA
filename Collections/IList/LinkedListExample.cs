using Collections.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.IList
{
    internal class LinkedListExample
    {
        public void Run()
        {
            LinkedList<string> linkedList = new LinkedList<string>();

            // добавление в конец списка
            linkedList.AddLast("a");
            linkedList.AddLast("b");
            linkedList.AddLast("c");

            // добавление в начало списка
            linkedList.AddFirst("a1");
            linkedList.AddFirst("b1");
            linkedList.AddFirst("c1");

            Console.WriteLine("Список:");
            PrintHelper.PrintCollection(linkedList);

            // первый и последний элемент
            var first = linkedList.First;
            LinkedListNode<string> last = linkedList.Last;
            Console.WriteLine("Первый: " + first.Value);
            Console.WriteLine("Последний: " + last.Value);

            // проверка наличия
            bool containsEl = linkedList.Contains("a");
            Console.WriteLine(containsEl);

            // поиск 
            LinkedListNode<string> findEl = linkedList.Find("b");
            Console.WriteLine("Найден: " + findEl.Value);

            // вставка перед элементом
            linkedList.AddBefore(findEl, "test");
            Console.WriteLine("Список:");
            PrintHelper.PrintCollection(linkedList);

            // удаление
            linkedList.Remove("c");
            Console.WriteLine("Список:");
            PrintHelper.PrintCollection(linkedList);
        } 
    }
}
