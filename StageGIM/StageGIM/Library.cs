using ManagementSystem.classes;
using System;
using System.Collections.Generic;


namespace ManagementSytem.clases
{
    public class Library()
    {
        private List<Book> BookList = new List<Book>();

            //can change public and void later if needed
        public void AddBook()
        {
            // Prompt the user for book details
            Console.Write("Enter the book title: ");
            string? title = Console.ReadLine();

            Console.Write("Enter the book author: ");
            string? author = Console.ReadLine();

            Console.Write("Enter the book ISBN: ");
            string? isbn = Console.ReadLine();

            Console.Write("Enter the book genre: ");
            string? genre = Console.ReadLine();

            Console.Write("Is the book available? (true/false): ");     //takes string input and makes it bool
            bool isAvailable = bool.TryParse(Console.ReadLine(), out bool availability) ? availability : false;

            // Create a new Book object with the provided details
            Book? newBook = new Book(title, author, isbn, genre, isAvailable);

            // Add the new book to the list
            BookList.Add(newBook);

            //shows the books in the list
            Console.WriteLine("Books in the library:");
            foreach (var book in BookList)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Genre: {book.Genre}, Available: {book.IsAvailable}");
            }

        }
        public void RemoveBook()
        {
            // ask the user to enter the title of the book they want to remove
            Console.Write("Enter the book title: ");
            string? TitleRemoveBook = Console.ReadLine();

            // Find the book in the list with the matching title
            Book? BookToRemove = BookList.FirstOrDefault(book => book.Title.Equals(TitleRemoveBook, StringComparison.OrdinalIgnoreCase));

            //check if book was found
            if (BookToRemove != null)
            {
                BookList.Remove(BookToRemove);
                Console.WriteLine($"The book '{BookToRemove.Title}' has been removed.");
            }
            else
            {
                Console.WriteLine($"No book with the title '{TitleRemoveBook}' was found");

            }
            Console.WriteLine("Books in the library:");
            foreach (var book in BookList)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Genre: {book.Genre}, Available: {book.IsAvailable}");
            }
        }
        public void BorrowBook()
        {
            // ask the user to enter the title of the book they want to Borrow
            Console.Write("Enter the book title that you want to borrow: ");
            string? TitleBorrowBook = Console.ReadLine();

            // Find the book in the list with the matching title
            Book? BookToBorrow = BookList.FirstOrDefault(book => book.Title.Equals(TitleBorrowBook, StringComparison.OrdinalIgnoreCase));
            
            //checking if the the book IsAvailable 
            if (BookToBorrow.IsAvailable != false)
            {   //it needs to change IsAvalable to false
                Console.WriteLine("borrowed");
                BookToBorrow.IsAvailable = false;

           
            }
            else
            {
                Console.WriteLine($"There is no book with the title: '{TitleBorrowBook}'in the Library");
            }

        }
        public void ReturnBook()
        {
            // ask the user to enter the title of the book they want to Borrow
            Console.Write("Enter the book title that you want to return: ");
            string? TitleReturnBook = Console.ReadLine();

            //do i need to use this?
            Book? BookToRetun = BookList.FirstOrDefault(book => book.Title.Equals(TitleReturnBook, StringComparison.OrdinalIgnoreCase));
            BookToRetun.IsAvailable = true;


           //     foreach (var book in BookList)
           //     {
           //         Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Genre: {book.Genre}, Available: {book.IsAvailable}");
          //      }

        }
    }
}
