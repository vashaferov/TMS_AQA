using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Task4
{
    internal class Book
    {
        private string title;
        private string author;
        private Guid isbn;
        private bool availabilityBook;

        public Book(string title, string author, Guid isbn) 
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            availabilityBook = true;
        }

        public string Title { get =>  title;}
        public string Author { get => author; }
        public string ISBN { get => isbn.ToString(); }
        public bool AvailabilityBook { get => availabilityBook; set => availabilityBook = value; }
    }
}
