using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic.Task2
{
    internal class GenericArray<T>
    {
        public T[] ArrayGeneric { get; set; }

        public GenericArray(int lengthArray) 
        {
            ArrayGeneric = new T[lengthArray];
        }

        public void Add(T element)
        {
            var tmp = new List<T>(ArrayGeneric);
            tmp.Add(element);
            ArrayGeneric = tmp.ToArray();
        }

        public void Remove(int index) 
        {
            if (index < 0 || index > ArrayGeneric.Length)
                Console.WriteLine("Индекс за приделом массива");
            else
            {
                var tmp = new List<T>(ArrayGeneric);
                tmp.RemoveAt(index);
                ArrayGeneric = tmp.ToArray();
            }                
        }

        public void Find(int index)
        {
            if (index < 0 || index > ArrayGeneric.Length - 1)
                Console.WriteLine("Индекс за приделом массива");
            else
                Console.WriteLine($"По индексу {index} в массиве найден элемент: {ArrayGeneric[index]}" );
        }

        public void Length()
        {
            Console.WriteLine("Длина массива: " + ArrayGeneric.Length);
        }

        public void Print()
        {
            Console.Write("Массив:");

            foreach (var item in ArrayGeneric) 
                Console.Write(" " + item);

            Console.WriteLine();
        }
    }  
}
