using System.Text.RegularExpressions;

namespace StringApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            /* string message1;
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

             Console.WriteLine(str_final);*/

            bool flag = true;
            StreamReader streamReader;
            string text;

            while (flag)
            {
                Console.Write("-------\nВведите номер задания (от 1 до 7): ");
                string? task = Console.ReadLine();
                Console.Clear();

                switch (task)
                {
                    case "1":
                        {
                            Console.WriteLine("Задание 1\n");

                            char[] num = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

                            streamReader = new StreamReader(@"originalFiles\Task_1.txt");
                            text = streamReader.ReadToEnd();
                            Console.WriteLine("Исходный текст:\n" + text);
                            streamReader.Close();

                            text = text.Replace("test", "testing");
                            
                            for (int i = 0; i < text.Length; i++)
                                for (int j = 0; j < num.Length; j++)
                                    if (text[i] == num[j])
                                        text = text.Replace(text[i].ToString(), String.Empty);

                            Console.WriteLine("\nИзмененный текст:\n" + text);
                            break;
                        }

                    case "2":
                        {
                            Console.WriteLine("Задание 2\n");

                            string s1 = "Welcome";
                            string s2 = "to";
                            string s3 = "the";
                            string s4 = "TMS";
                            string s5 = "lesons";

                            Console.WriteLine(string.Concat("\"",s1, "\" \"", s2, "\" \"", s3, "\" \"", s4, "\" \"", s5, "\""));

                            break;
                        }

                    case "3":
                        {
                            Console.WriteLine("Задание 3\n");

                            text = "teamwithsomeofexcersicesabcwanttomakeitbetter";
                            string findText = "abc";
                            string substringBefore, substringAfter;
                            int index;

                            Console.WriteLine("Исходный текст:\n" + text);

                            index = text.IndexOf(findText);
                            Console.WriteLine($"В тексте найдено \"{findText}\":\n{text.Replace("abc", "|abc|")}");

                            substringBefore = text.Substring(0, index);
                            substringAfter = text.Substring(index + findText.Length);

                            Console.WriteLine("Измененный текст:\n" + substringBefore + "\n" + substringAfter);

                            break;
                        }

                    case "4":
                        {
                            Console.WriteLine("Задание 4\n");

                            text = "Плохой день.";
                            string findText = "плохой";
                            string newText = "Хороший";
                            int index;

                            Console.WriteLine("Исходный текст:\n" + text);

                            text = text.ToLower(); // т.к. в исходном тексте с заглавной буквы, а "нужно удалить" с маленькой
                            index = text.IndexOf(findText);                          
                            text = text.Substring(index + findText.Length);
                            text = text.Insert(index, newText);
                            text = text.Insert(text[text.Length - 1], "!!!!!!!!!");


                            Console.WriteLine("Измененный текст:\n" + text);
                            break;
                        }

                    case "5":
                        {
                            Console.WriteLine("Задание 5\n");

                            break;
                        }

                    case "6":
                        {
                            Console.WriteLine("Задание 6\n");

                            break;
                        }

                    case "7":
                        {
                            Console.WriteLine("Задание 7\n");

                            break;
                        }
                }
            }
        }
    }
}