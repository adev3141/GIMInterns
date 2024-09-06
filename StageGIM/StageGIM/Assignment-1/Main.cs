using System;
using System.Dynamic;
using LibraryManagementSystem;

namespace LibraryManagementSystem
{
    class MainWindow
    {
        static void Main(string[] args)
        {
            var library = new Library();
            var user = new User("Ruveyda", "2", "ruveyda@ruveyda.nl", "0");
            var pruser = new PremiumUser("Ruveyda", "2", "ruveyda@ruveyda.nl", "0", "1",library);
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
                    //Console.WriteLine("6. request to borrow  a book");
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
                            library.BorrowBook();
                            break;
                        case "4":
                            library.ReturnBook();
                            break;
                        case "5":
                            library.FindBook();
                            break;
                        case "6":
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

