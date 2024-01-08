// See https://aka.ms/new-console-template for more information
using Collections;
using Collections.Helper;
using Collections.Task1;
using Collections.Task2;
using Collections.Task4;
using System.Collections;
using System.Collections.Generic;

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
    Console.Write("-------\nВведите номер задания (от 1 до 4): ");
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

                                    libBook.Add(Books.AddBook(bookName, bookAuthor, bookYearPublication));
                                } catch (EmptyInfoException ex)
                                {
                                    Console.WriteLine("Ошибка: " + ex.Message);
                                }

                                break;
                            }
                        case "2":
                            {
                                Console.Clear();

                                foreach (Books book in libBook)
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

                                Books.FindBookAuthor(bookAuthorFind, libBook);

                                break;
                            }
                        case "4":
                            {
                                Console.Clear();

                                int i = 0;

                                Console.WriteLine("Список книг в системе: ");
                                foreach (Books book in libBook)
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

                Dictionary<int, Product> productD = new Dictionary<int, Product>();
                bool exitFlag = false;
                
                while (!exitFlag)
                {
                    Console.Write($"-------------------\nВ списке {productD.Count} товаров\n1) Добавление товара\n2) Отображение списка товаров\n3) Поиск товара по идентификатору\n4) Обновление информации о товаре\n5) Удаление товара\n'q' - Выход из программы\nВведите номер операции: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            {
                                bool flagAdd = false;
                                int n = 0;

                                Console.Clear();

                                Console.Write("Введите название товара: ");
                                string productName = Console.ReadLine();
                                Console.Write("Введите стоимость товара: ");
                                double productPrice = Convert.ToDouble(Console.ReadLine());
                                Console.Write("Введите ко-во товара: ");
                                int productCount = Convert.ToInt32(Console.ReadLine());


                                while (!flagAdd)
                                {
                                    flagAdd = productD.TryAdd(n, Product.Add(productName, productPrice, productCount));
                                    n++;
                                }                                

                                break;
                            }
                        case "2":
                            {
                                Console.Clear();

                                foreach (var pair in productD)
                                {
                                    Console.WriteLine($"ID: {pair.Key}, Название: {pair.Value.ProductName}, Стоимость: {pair.Value.ProductPrice}, Ко-во: {pair.Value.ProductCount}");
                                }

                                break;
                            }
                        case "3":
                            {
                                Console.Clear();

                                Console.Write("Введите ID товара: ");
                                int id = Convert.ToInt32(Console.ReadLine());

                                if (productD.TryGetValue(id, out Product product))
                                    Console.WriteLine($"Найден продукт с ID {id}:\nНазвание: {product.ProductName}, Стоимость: {product.ProductPrice}, Ко-во: {product.ProductCount}");
                                else
                                    Console.WriteLine("Продукт отсутствует в  списке");

                                break;
                            }
                        case "4":
                            {
                                Console.Clear();

                                Console.Write("Введите ID товара: ");
                                int id = Convert.ToInt32(Console.ReadLine());

                                if (productD.TryGetValue(id, out Product product))
                                {
                                    Console.WriteLine($"Найден продукт с ID {id}:\nНазвание: {product.ProductName}");

                                    Console.Write("Изменить цену? (Y|N) ");
                                    switch (Console.ReadLine().ToString().ToUpper())
                                    {
                                        case "Y":
                                            {
                                                Console.Write("Новая цена: ");
                                                product.ProductPrice = Convert.ToDouble(Console.ReadLine());

                                                break;
                                            }
                                        default:
                                            break;
                                    }

                                    Console.Write("Изменить ко-во? (Y|N) ");
                                    switch (Console.ReadLine().ToString().ToUpper())
                                    {
                                        case "Y":
                                            {
                                                Console.Write("Новое ко-во: ");
                                                product.ProductCount = Convert.ToInt32(Console.ReadLine());

                                                break;
                                            }
                                        default:
                                            break;
                                    }

                                    Console.WriteLine($"Продукт с ID {id} изменен:\nНазвание: {product.ProductName}, Стоимость: {product.ProductPrice}, Ко-во: {product.ProductCount}");

                                }                                    
                                else
                                    Console.WriteLine("Продукт отсутствует в списке");

                                break;
                            }
                        case "5":
                            {
                                Console.Clear();

                                Console.Write("Введите ID товара: ");
                                int id = Convert.ToInt32(Console.ReadLine());

                                if (productD.Remove(id))
                                    Console.WriteLine("Продукт удален из списка");
                                else
                                    Console.WriteLine("Продукт отсутствует в списке");

                                break;
                            }
                        case "q":
                            {
                                exitFlag = true;

                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Неверный номер операции (от 1 до 5 или 'q')!");

                                break;
                            }
                    }

                }

                break;
            }
        case "3":
            {
                Console.WriteLine("ЗАДАНИЕ 3\n");

                List<int> list = new List<int>() { 1, 2, 3, 4, 4, 5 };
                HashSet<int> set = new HashSet<int>();

                Console.Write("Коллекция до изменения: ");
                foreach (var item in list)
                {
                    Console.Write(item + " ");
                    set.Add(item);
                }

                Console.Write("\nКоллекция после изменения: ");
                foreach(var item in set)
                    Console.Write(item + " ");

                Console.WriteLine();

                break;
            }
        case "4":
            {
                Console.WriteLine("ЗАДАНИЕ 4\n");

                Library library = new Library();

                bool exitFlag = false;

                while (!exitFlag)
                {
                    Console.Write($"-------------------\n1) Добавление книгу\n2) Добавление читателя\n3) Выдать книгу читателю\n4) Вернуть книгу в библиотеку\n5) Книги в библиотеке\n6) Читатели\nВведите номер операции: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            {
                                Console.Clear();

                                Console.Write("Введите название книги: ");
                                string title = Console.ReadLine();
                                Console.Write("Введите автора книги: ");
                                string author = Console.ReadLine();

                                Book book = new Book(title, author, Guid.NewGuid());
                                library.AddBook(book);

                                break;
                            }
                        case "2":
                            {
                                Console.Clear();

                                Console.Write("Введите ФИО читателя: ");
                                string name = Console.ReadLine();

                                Reader reader = new Reader(name, Guid.NewGuid());
                                library.AddReader(reader);

                                break;
                            }
                        case "3":
                            {
                                Console.Clear();

                                Console.Write("Введите название книги: ");
                                string book = Console.ReadLine();
                               
                                    foreach (var b in library.BookList)
                                        if (b.Title == book)
                                        {
                                            Console.Write("Введите ФИО читателя: ");
                                            string name = Console.ReadLine();

                                            foreach (var r in library.ReaderDictionary)
                                                if (r.Key.Name == name)
                                                    library.CheckOutBook(r.Key, b);
                                        }

                                break;
                            }
                        case "4":
                            {
                                Console.Clear();

                                Console.Write("Введите ФИО читателя: ");
                                string name = Console.ReadLine();

                                foreach (var r in library.ReaderDictionary)
                                    if (r.Key.Name == name)
                                    {
                                        Console.Write("Введите название книги: ");
                                        string book = Console.ReadLine();

                                        foreach (var b in library.BookList)
                                            if (b.Title == book)
                                                library.ReturnBook(r.Key, b);
                                    }

                                break;
                            }
                        case "5":
                            {
                                Console.Clear();

                                library.PrintBook();

                                break;
                            }
                        case "6":
                            {
                                Console.Clear();

                                library.PrintReader();

                                break;
                            }
                        default:
                            {
                                exitFlag = true; 
                                
                                break;
                            }
                            
                    }
                }
                
                break;
            }
        default:
            {
                Console.WriteLine("Не найден номер задачи. Повторите ввод номера (от 1 до 4)");

                break;
            }
    }
}