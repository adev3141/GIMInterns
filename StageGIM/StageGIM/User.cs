using System;
using LibraryManagementSystem.classes;

namespace LibraryManagementSystem.clases
{    
    public class User(string name, string userId, string email, string borrowedBooks)
    {
        // Private fields to store the properties of the user
        private string Name = name;
        private string UserId = userId;
        private string Email = email;
        private string BorrowedBooks = borrowedBooks;

        public virtual void RequestBorrowBook()
        {//does not work beacause BookToBorrow = null in Library - BorrowBook()
            Library RequestBook = new Library();
            //shows the books in the list
            Console.WriteLine("Books in the library:");
            foreach (var book in RequestBook.BookList)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Genre: {book.Genre}, Available: {book.IsAvailable}");
            }

            Console.Write("Enter the book title that you want to borrow: ");
            string? TitleBorrowBook = Console.ReadLine();
            // Find the book in the list with the matching title
            Book? BookToBorrow = RequestBook.BookList.FirstOrDefault(book => book.Title.Equals(TitleBorrowBook, StringComparison.OrdinalIgnoreCase));


            Console.WriteLine("it does come here");//it doezs not :(
            //BookToBorrow in Library needs to get the input 

            RequestBook.BorrowBook();

        }
    }
}

