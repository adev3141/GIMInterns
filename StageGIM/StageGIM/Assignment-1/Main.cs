using System;
using System.Dynamic;
using LibraryManagementSystem;
using static LibraryManagementSystem.User;

namespace LibraryManagementSystem
{
    class MainWindow
    {
        static void Main(string[] args)
        {
            var library = new Library();
            var user = new User("Ruveyda", "2", "ruveyda@ruveyda.nl","0");
            var pruser = new PremiumUser("Ruveyda", "2", "ruveyda@ruveyda.nl", "0", library);
            bool Running = true;

            while (Running)
            {
                if (Running)
                {
                    Console.WriteLine("Choose an option:");
                    Console.WriteLine("1. Add a book");
                    Console.WriteLine("2. remove a book");
                    Console.WriteLine("3. borrow a book");
                    Console.WriteLine("4. return a book");
                    Console.WriteLine("5. find a book");
                    Console.WriteLine("6. borrow a book for primium");
                    Console.WriteLine("7. Exit");

                    string Input = Console.ReadLine();

                    switch (Input)
                    {
                        case "1":
                            library.AddBook();
                            break;
                        case "2":
                            library.RemoveBook();
                            break;
                        case "3":
                            library.BorrowBook(user);
                            break;
                        case "4":
                            library.ReturnBook();
                            break;
                        case "5":
                            library.FindBook();
                            break;
                        case "6":
                            pruser.BorrowBookPremium(library);//this is for premium users need to make it so only they can use this
                            break;
                        case "7":
                            Running = false;
                            break;

                    }
                }
            }









               
          
            
           // pruser.RequestBorrowBook(library);
         //   
         //  user.RequestBorrowBook(library);
         //    library.BorrowBook();
         //
         //
        
        }
    }
}

