using LibraryManagementSystem;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using static LibraryManagementSystem.User;


namespace LibraryManagementSystem
{
   
    public class Library()
    {
        public enum MembershipLevel
        {
            User = 1,
            Premium = 2
        }

        public List<Book> BookList = new List<Book>();
        MembershipLevel MembershipLevelLibrary = new MembershipLevel();

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
            Console.Write("Enter the title of the book you want to remove: ");
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
            //it shows all the book currently in the Library
            Console.WriteLine("Books in the library:");
            foreach (var book in BookList)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Genre: {book.Genre}, Available: {book.IsAvailable}");
            }
        }


        public void BorrowBook(User user)
        {
            if (MembershipLevel.User == MembershipLevel.Premium)
            {

                BorrowBookPremium(user);
            }
            else
            {
                BorrowBookStandard();
            }
        }

        public virtual void BorrowBookStandard()
        {  // ask the user to enter the title of the book they want to Borrow

            //need to make it so that user can only borrow one and Premium user more then 0ne

            Console.Write("Enter the book title that you want to borrow: ");
            string? TitleBorrowBook = Console.ReadLine();

            // Find the book in the list with the matching title
            Book? BookToBorrow = BookList.FirstOrDefault(book => book.Title.Equals(TitleBorrowBook, StringComparison.OrdinalIgnoreCase));

            if (BookToBorrow == null)
            {//if the title is not in BookList it comes here
                Console.WriteLine($"There is no book with the title '{TitleBorrowBook}'in the Library");

            }
            else if (!BookToBorrow.IsAvailable)
            {//if the title is in BookList but Isavailable == fase it comes here
                Console.WriteLine($"The book with the title: '{TitleBorrowBook}'is currently not available");
            }
            else
            {//if title is in BookList and Isavailable == true it comes here
                BookToBorrow.IsAvailable = false;
                Console.WriteLine($"The book with the title:'{TitleBorrowBook}' has been succesfully borrowed ");
            }
        }

        public void BorrowBookPremium(User user)
        {
            if (MembershipLevel.User != MembershipLevel.Premium)
            {
                Console.WriteLine("You must be a premium user to borrow more than one book.");
                return;
            }

            Console.WriteLine("Give the number of books you want to borrow:");
            string AmountBookInput = Console.ReadLine();

            if (int.TryParse(AmountBookInput, out int AmountBooks) && AmountBooks > 0)
            {
                for (int counter = 0; counter < AmountBooks; counter++)
                {
                    BorrowBookStandard(); // Call the standard borrow method for each book
                }
            }
            else
            {
                Console.WriteLine("Invalid number of books");
            }
        }
    


    public void ReturnBook()
    {   //make it so that you can return a book that is not in BookList and then that book should go to BookList!
        // ask the user to enter the title of the book they want to return
        Console.Write("Enter the book title that you want to return: ");
        string? TitleReturnBook = Console.ReadLine();

        //do i need to use this?
        Book? BookToReturn = BookList.FirstOrDefault(book => book.Title.Equals(TitleReturnBook, StringComparison.OrdinalIgnoreCase));
        //   BookToReturn.IsAvailable = true;

        if (BookToReturn == null)
        {
            Console.WriteLine("Put in the information of the Book that you want to retun");
            AddBook();
        }
        else
        {
            BookToReturn.IsAvailable = true;
        }
    }

        public void FindBook()
        {
            Console.Write("Enter the title of the book you want to find: ");
            string? TitleFindBook = Console.ReadLine();
            Book? BookToBorrow = BookList.FirstOrDefault(book => book.Title.Equals(TitleFindBook, StringComparison.OrdinalIgnoreCase));

            //check if book was found
            if (BookToBorrow != null)
            {
               
                Console.WriteLine($"The book '{BookToBorrow.Title}' has been found.");
            }
            else
            {
                Console.WriteLine($"No book with the title '{BookToBorrow}' was found");

            }
            //it shows all the book currently in the Library
            Console.WriteLine("Books in the library:");
            foreach (var book in BookList)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}, Genre: {book.Genre}, Available: {book.IsAvailable}");
            }
        }
    }
}
