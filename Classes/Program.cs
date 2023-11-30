using Classes.Models;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //=================================\\
            //============= Методы ==============\\
            //=====================================\\
            /* int[] array = { 1, 8, 14, -4, 0, 7 };

             DisplayGreeting("Hello");
             DisplayGreeting("Hello", "Slava");

             Console.WriteLine(GetInfo());

             PrintArrayWithoutParameters();

             Array.Reverse(array);

             PrintArrayParameters(array);


             void PrintArrayWithoutParameters()
             {
                 foreach (var i in array)
                 {
                     Console.Write($"{i}\t");
                 }
                 Console.WriteLine();
             }

             void PrintArrayParameters(int[] arrayParameters)
             {
                 foreach (var i in arrayParameters)
                 {
                     Console.Write($"{i}\t");
                 }
                 Console.WriteLine();
             }

             string GetInfo()
             {
                 return "Reverse:";
             }

             void DisplayGreeting(string message, string name = "Гость") // с параметром по умолчанию
             {
                 Console.WriteLine(message + ", " + name);
             }

             // =============== Передача параметров по ссылке

             static void OutAdd (int x, int y, out int ans)              // out
             {
                 ans = x + y;
             }

             OutAdd(90, 90, out int ans);                                // ref
             Console.WriteLine("Out: " + ans);

             void ModifyValue(ref int value)
             {
                 value = value * 2;
             }

             int mainValue = 5;
             Console.WriteLine("Ref: " + mainValue);

             // =============== Возврат нескольких значений (кортеж)

             (string, int) GetPersonInfo()
             {
                 return ("Slava", 25);
             }

             var person1 = GetPersonInfo();
             Console.WriteLine($"Name: {person1.Item1}, Age: {person1.Item2}");

             // =============== Рекурсия

             int Factorial(int n)
             {
                 if (n == 1) return 1;

                 return n * Factorial(n - 1);
             }

             int factorial4 = Factorial(4);*/

            //=================================\\
            //============= Классы ==============\\
            //=====================================\\

            /*EmptyClass emptyClass = new EmptyClass();
            Person person = new Person();

            person.Print();

            person.name = "Slava";
            person.age = 25;
            person.Print();

            // =============== Конструктор

            PersonWithConstructor personWithConstructor = new PersonWithConstructor();
            personWithConstructor.Print();

            CustomConstructor customConstructor1 = new CustomConstructor(10);
            CustomConstructor customConstructor2 = new CustomConstructor("text");
            customConstructor1 = new CustomConstructor("newText");

            PersonThis personThis = new PersonThis();

            // Цепочки

            PersonChain personChain1 = new PersonChain();
            PersonChain personChain2 = new PersonChain("Slava");
            PersonChain personChain3 = new PersonChain("Slava", 25);

            personChain1.Print();
            personChain2.Print();
            personChain3.Print();*/

              //=================================\\
             //============ Практика =============\\
            //=====================================\\

            // =============== Задача 1
            Student[] students = new Student[14];

            Console.WriteLine("Студенты:");

            for (int i = 0; i < 14; i++)
            {
                students[i] = new Student("Slava " + i);
                students[i].Print();
            }

            Console.WriteLine("---------");

            foreach (Student student in students)
            {
                if (student.diplomMark == 9 || student.diplomMark == 10)
                    student.Print();
            }

            // =============== Задача 2
            Cat cat = new Cat();
            cat.name = "Феликс";
            cat.age = 1;
            cat.maxFood = 3;

            Console.WriteLine("Наелся? - {0}", cat.Feed(3) ? "Да" : "Нет");
        }
    }
}