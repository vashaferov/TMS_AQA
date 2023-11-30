using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    internal class Student
    {
        public string name;
        public int group;
        public int diplomMark;

        public Student(string name)
        {
            this.name = name;
            group = 1;
            diplomMark = new Random().Next(1, 10);
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name}, Group: {group}, Mark: {diplomMark}");
        }

    }
}
