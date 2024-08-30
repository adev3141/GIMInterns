using System;
using System.Dynamic;
using LibraryManagementSystem.clases;

namespace LibraryManagementSystem.classes
{
    class MainWindow
    {
        static void Main(string[] args)
        {
            var library = new Library();
            var user = new User("Ruveyda", "2", "ruveyda@ruveyda.nl", "0");
           var pruser = new PremiumUser("Ruveyda", "2", "ruveyda@ruveyda.nl", "0", "1",library);
            
            //testing if the methods work
            library.AddBook();
            library.AddBook();
            pruser.RequestBorrowBook(library);
         //   user.BorrowBook();
         //  user.RequestBorrowBook(library);
         //    library.BorrowBook();
         //library.ReturnBook();
         //library.RemoveBook();

        }
    }
}

