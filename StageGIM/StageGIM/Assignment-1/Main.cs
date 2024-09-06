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
            bool IsPremium = false;
            bool Running = true;

            // Ask if the user is a premium user
            Console.WriteLine("Are you a premium user? (yes/no): ");
            string? UserTypeInput = Console.ReadLine()?.Trim().ToLower();

            if (UserTypeInput == "yes")
            {
                IsPremium = true;
            }

            // Creating the user based on input
            User user;
            if (IsPremium)
            {
                user = new PremiumUser("Ruveyda", "2", "ruveyda@ruveyda.nl", "0", library);
            }
            else
            {
                user = new User("Ruveyda", "2", "ruveyda@ruveyda.nl", "0");
            }

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
                    Console.WriteLine("6. borrow multiple books (only premium users)");
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
                            // Only allow premium users to access this
                            if (IsPremium && user is PremiumUser premiumUser)
                            {
                                premiumUser.BorrowBookPremium(library);
                            }
                            else
                            {
                                Console.WriteLine("This option is only available to premium users.");
                            }
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

