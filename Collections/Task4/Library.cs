using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Task4
{
    internal class Library
    {
        List<Book> bookList = new List<Book>();
        Dictionary<Reader, ISet<Book>> readerDictionary = new Dictionary<Reader, ISet<Book>>();

        public List<Book> BookList { get => bookList; }
        public Dictionary<Reader, ISet<Book>> ReaderDictionary { get => readerDictionary; }

        public void AddBook(Book book)
        {
            bookList.Add(book);
            Console.WriteLine("Книга успешно добавлена в библиотеку");
        }

        public void AddReader(Reader reader)
        {
            ISet<Book> books = new HashSet<Book>();
            readerDictionary.Add(reader, books);
            Console.WriteLine("Читатель добавлен в список");
        }

        public void CheckOutBook(Reader reader, Book book)
        {
            if (!book.AvailabilityBook)
                Console.WriteLine("Книга уже на руках");
            else
            {                
                readerDictionary.TryGetValue(reader, out ISet<Book> bookSet);
                bookSet.Add(book);
                book.AvailabilityBook = false;

                Console.WriteLine("Книга успешно выдана");
            }
        }

        public void ReturnBook(Reader reader, Book book)
        {               
                readerDictionary.TryGetValue(reader, out ISet<Book> bookSet);
                bookSet.Remove(book);
                book.AvailabilityBook = true;

                Console.WriteLine("Книга возвращена в библиотеку");
        }

        public void PrintBook()
        {
            foreach (var item in bookList)
            {
                Console.WriteLine($"Название: {item.Title}, Автор: {item.Author}, Идентификатор: {item.ISBN}, Доступность книги: {item.AvailabilityBook}");
            }
        }

        public void PrintReader()
        {
            foreach (var pair in readerDictionary)
            {
                Console.WriteLine($"ФИО: {pair.Key.Name}, Читательский билет №{pair.Key.LibraryCardNumber} \nКниги у читателя:");
                if (pair.Value != null)
                    foreach (var item in pair.Value)
                        Console.WriteLine($"Название: {item.Title}, Автор: {item.Author}, Идентификатор: {item.ISBN}");
                else Console.WriteLine("-");
            }
        }
    }
}
