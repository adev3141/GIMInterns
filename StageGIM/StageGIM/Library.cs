using System;
using System.Collections.Generic;


namespace ManagementSytem.clases
{
    public class Library
    {
        Book VarBook = new Book("Harry Potter", "J.k ", "422541", "Fantasy", "is available");
        Book VarBook2 = new Book("Harry Snotter", "J.k ", "422541", "Fantasy", "not available");

        private List<Book> BookList = new List<Book>();


        public void Proberen()    //this is for testing
        {
            Console.WriteLine("Book added to the list in proberen is the one under here:");
            BookList.Add(VarBook);
            
            foreach (var book in BookList)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Genre: {book.Genre}, Available: {book.IsAvailable}");
            }
        }



            //can change public and void later if needed
        public void AddBook()
        {
            Console.WriteLine("book added in AddBook is undere here");
            BookList.Add(VarBook2);  //it adds a book hard coded to the list then shows te list of books with the new book
            foreach (var book in BookList)
            {           //shows the book that has been aded. in this case VarBook2
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Genre: {book.Genre}, Available: {book.IsAvailable}");
            }
        }
        public void RemoveBook()
        {
            Console.WriteLine("start book removing");
            BookList.Remove(VarBook);
            foreach (var book2 in BookList)
            {           //shows the book that has been aded. in this case VarBook2
                Console.WriteLine($"Title: {book2.Title}, Author: {book2.Author}, ISBN: {book2.ISBN}, Genre: {book2.Genre}, Available: {book2.IsAvailable}");
            }
            Console.WriteLine("book has een removed");
        }

        public void BorrowBook()
        {

        }

        public void ReturnBook()
        {

        }
    }
}
