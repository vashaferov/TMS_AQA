namespace StringApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            string message1;
            string message2 = null;
            string message3 = System.String.Empty; // вместо ""
            string oldPath = "c:\\Program Files\\tmp.txt";
            string newPath = @"c:\Program Files\tmp.txt";

            char[] letters = { 'A', 'B', 'C' };
            string alphabet = new string(letters);

            string s1 = "hello";
            string s2 = new String('a', 6); // результатом будет строка "aaaaaa"
            string s3 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' });
            string s4 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' }, 1, 3); // orl

            Console.WriteLine(s1);  // hello
            Console.WriteLine(s2);  // aaaaaaa
            Console.WriteLine(s3);  // world
            Console.WriteLine(s4);  // orl

            string msg1 = "hello";
            string msg2 = "hello";

            Console.WriteLine(msg1.Equals(msg2)); // сравнение строк

            Console.WriteLine(msg1[0]); // получение символа из строки через массив

            foreach (char c in msg1)     //
                Console.Write(c + " "); // вывод строки через символы

            // конкатинация
            Console.WriteLine();
            string s5 = "hello";
            string s6 = "world";
            Console.WriteLine(s5 + " " + s6);
            Console.WriteLine(string.Concat("Concat: ", s5, " ", s6, "!"));


            // многострочный текст """..."""
            string text = """                   
                          <element attr="content">
                            <body>
                            </body>
                          </element>
                          """;
            Console.WriteLine(text);

            string text_inter = $"""                   
                          <element attr="content">
                            <body>
                                {s1}
                            </body>
                          </element>
                          """;
            Console.WriteLine(text_inter);

            // Джоин
            string s7 = "s7";
            string s8 = "s8";
            string s9 = "s9";

            string[] value = { s7, s8, s9 };
            string str_final = string.Join(" : ", value);

            Console.WriteLine(str_final);

            // Сравнение посимвольно 

            string s10 = "hello";
            string[] compare_value = { "hello", "world", "about"};
            
            foreach (string item in compare_value)
                Console.WriteLine(s10.CompareTo(item));

            // IndexOf, IndexOfAny
            string f_str ="Hello World";

            Console.WriteLine($"IndexOf 'j': {f_str.IndexOf('j')}"); // символа нет
            Console.WriteLine($"IndexOf 'e': {f_str.IndexOf('e')}");
            Console.WriteLine($"IndexOf 'h': {f_str.IndexOf('h', StringComparison.OrdinalIgnoreCase)}"); // без учета регистра
            Console.WriteLine($"IndexOf 'l': {f_str.IndexOf('l', 3)}");

            char[] chars1 = { 'a', 'o', 'c', };

            Console.WriteLine($"IndexOfAny: {f_str.IndexOfAny(chars1)}");

            char findElement = 'o';

            for (int i = 0; i < f_str.Length; i++)
                if (i == f_str.IndexOf(findElement, i))
                    Console.Write(i + " ");
        }
    }
}