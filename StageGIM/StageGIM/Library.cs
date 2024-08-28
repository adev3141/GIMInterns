using System;
using System.Collections.Generic;


namespace ManagementSytem.clases
{
    public class Library
    {
        Book num = new Book("num", "jh", "534648", "kghg", true);

        private List<Book> BookList = new List<Book>();


        public void Proberen()
        {
            BookList.Add(num);
            Console.WriteLine("Book added to the list:");
            foreach (var book in BookList)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Genre: {book.Genre}, Available: {book.IsAvailable}");
            }
        }
    }
}
