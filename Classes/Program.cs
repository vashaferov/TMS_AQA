namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 8, 14, -4, 0, 7 };

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
        }
    }
}