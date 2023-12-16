using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Example
    {

        public void Run()
        {
            Dictionary<string, List<int>> studentsGrades = new Dictionary<string, List<int>>();

            studentsGrades.Add("Саша", new List<int> { 7, 9, 10 });
            studentsGrades.Add("Маша", new List<int> { 10, 9, 10, 8 });
            studentsGrades.Add("Паша", new List<int> { 5, 9, 10 });

            foreach (var student in studentsGrades)
            {
                var averageMark = student.Value.Average();
                Console.WriteLine($"Ср. оценка: {averageMark}");
            }
        }
    }
}
