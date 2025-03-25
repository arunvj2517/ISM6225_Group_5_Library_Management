using System;
namespace USFLibraryManagementSystem
{
    using System;
    using System.Collections.Generic;


    public class Library
    {
        private List<Book> books;
        private List<Person> patrons;

        public Library()
        {
            books = new List<Book>();
            patrons = new List<Person>();
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void AddPatron(Person person)
        {
            patrons.Add(person);
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Books in Library:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }

        public void DisplayPatrons()
        {
            Console.WriteLine("Patrons in Library:");
            foreach (var patron in patrons)
            {
                Console.WriteLine(patron.ToPatronString());
            }
        }

        public bool BorrowBook(string patronName, string bookTitle)
        {
            var patron = patrons.Find(p => p.Name == patronName);
            var book = books.Find(b => b.Title == bookTitle);

            if (patron == null || book == null)
            {
                return false;
            }

            return book.BorrowBook();
        }
    }

}