// See https://aka.ms/new-console-template for more information
using Collections;
using Collections.Task1;
using System.Collections;

/*
//new ArrayListExample().Run();

//new ListExample().Run();

//new LinkedListExample().Run();

//new DictionaryExample().Run();

//new SortedListExample().Run();

//new SortedDictionaryExample().Run();

//new HashSetExample().Run();

//new StackExample().Run();

//new QueueExample().Run();

Persons persons1 = new Persons()
{
    FirstName = "A",
    LasttName = "B"
};

Persons persons2 = new Persons()
{
    FirstName = "A",
    LasttName = "B"
};

Console.WriteLine(persons1.Equals(persons2));

IEnumerable<int> GeneratrNum(int count)
{
    for(int i = 0; i < count; i++)
    {
        yield return i;
    }
}

foreach(var number in GeneratrNum(5))
{
    Console.WriteLine(number);
}
*/


bool flag = true;
string task;

while (flag)
{
    Console.Write("-------\nВведите номер задания (от 1 до 3): ");
    task = Console.ReadLine();
    Console.Clear();

    switch (task)
    {
        case "1":
            {
                Console.WriteLine("ЗАДАНИЕ 1\n");

                bool exitFlag = false;
                ArrayList libBook = new ArrayList();

                while (!exitFlag)
                {

                    Console.Write($"-------------------\nВ списке {libBook.Count} книг\n1) Добавление книги\n2) Отображение списка книг\n3) Поиск книги по автору\n4) Удаление книги\n'q' - Выход из программы\nВведите номер операции: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            {
                                try
                                {
                                    Console.Clear();

                                    Console.Write("Введите название книги: ");
                                    string bookName = Console.ReadLine();
                                    Console.Write("Введите автора книги: ");
                                    string bookAuthor = Console.ReadLine();
                                    Console.Write("Введите год публикации книги: ");
                                    int bookYearPublication = Convert.ToInt32(Console.ReadLine());

                                    libBook.Add(Book.AddBook(bookName, bookAuthor, bookYearPublication));
                                } catch (EmptyBookInfoException ex)
                                {
                                    Console.WriteLine("Ошибка: " + ex.Message);
                                }

                                break;
                            }
                        case "2":
                            {
                                Console.Clear();

                                foreach (Book book in libBook)
                                {
                                    Console.WriteLine($"Название: {book.BookName}, Автор: {book.BookAuthor}, Год публикации: {book.BookYearPublication}");
                                }

                                break;
                            }
                        case "3":
                            {
                                Console.Clear() ;

                                Console.Write("Введите имя автора: ");
                                string bookAuthorFind = Console.ReadLine();

                                Book.FindBookAuthor(bookAuthorFind, libBook);

                                break;
                            }
                        case "4":
                            {
                                Console.Clear();

                                int i = 0;

                                Console.WriteLine("Список книг в системе: ");
                                foreach (Book book in libBook)
                                {
                                    Console.WriteLine($"№: {i}. Название: {book.BookName}, Автор: {book.BookAuthor}, Год публикации: {book.BookYearPublication}");
                                    i++;
                                }

                                Console.Write("Введите номер книги для удаления: ");
                                int removeIndex = Convert.ToInt32(Console.ReadLine());
                                if (removeIndex > libBook.Count - 1 || removeIndex < 0)
                                    Console.WriteLine("Ошибка, индекс за пределами списка");
                                else
                                {
                                    libBook.RemoveAt(removeIndex);
                                    Console.WriteLine("Книга удалена из списка");
                                }
                                    
                                break;
                            }
                        case "q":
                            {
                                exitFlag = true;

                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Неверный номер операции (от 1 до 4 или 'q')!");

                                break;
                            }
                    }

                }

                break;
            }
        case "2":
            {
                Console.WriteLine("ЗАДАНИЕ 2\n");

                break;
            }
        case "3":
            {
                Console.WriteLine("ЗАДАНИЕ 3\n");

                break;
            }
        default:
            {
                Console.WriteLine("Не найден номер задачи. Повторите ввод номера (от 1 до 3)");

                break;
            }
    }
}