using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
     class Library
    {
         List<User> accounts = new List<User>();
        List<Book> books = new List<Book>();
        List<Book> allLoanedBooks = new List<Book>();

        public List<User> Accounts { get => accounts; set => accounts = value; }
        internal List<Book> Books { get => books; set => books = value; }
        internal List<Book> AllLoanedBooks { get => allLoanedBooks; set => allLoanedBooks = value; }

        public void getBook(Library library, string chosenBook, User sessionUserObject) {

            foreach (Book i in library.Books)
            {
                if (i.BookName == chosenBook && i.Available)
                {
                    Console.WriteLine("Book found!");
                    library.Books[library.Books.IndexOf(i)].Available = false;
                    library.AllLoanedBooks.Add(i);
                            
                    Console.WriteLine("Book loaned!");
                    sessionUserObject.LoanedBooks.Add(i);


                }
                else if (i.BookName == chosenBook && !i.Available)
                {
                    Console.WriteLine("Book unavailable");

                }


            }

        }
        public void returnBook(User sessionUserObject, Library library, string bookChoice) {
            foreach (Book i in sessionUserObject.LoanedBooks)
            {
                if (i.BookName == bookChoice)
                {

                    sessionUserObject.LoanedBooks.Remove(i);
                    library.AllLoanedBooks.Remove(i);
                    library.Books[library.Books.IndexOf(i)].Available = true;
                    Console.WriteLine("Book returned.");
                    break;

                }


            }


        }
        public void RemoveAccount() { }




    }
}
