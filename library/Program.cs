using library;

public class Oefenen
{
    static void Main(string[] args)
    {
        // Create instances of User, Library, and Book classes
        User signUp = new User();
        Library library = new Library();
        Book books = new Book();

        // Initialize variables
        bool premium = false;
        string? keuze2 = "", loginUser = "", loginPass = "";
        int sessionID = 0;
        string sessionUser = "", sessionPass = "", boekKeuze = "";
        string booktitle = "";
        string bookPrice = "";
        int age = 0;
        premiumUser premium12 = new premiumUser();
        User sessionUserObject = new User();
        string password = "";
        string username = "";
        User accountInfo = new User();

        // Main loop for the program
        while (true)
        {
            // Display menu options
            Console.WriteLine("[1] Log in\n[2] Sign up\n[3] Get a book\n[4] Add book to library\n[5] Return book");
            int keuze = Convert.ToInt32(Console.ReadLine());

            // Handle user's menu choice
            switch (keuze)
            {
                case 1:
                    // Login process
                    Console.WriteLine("Username?");
                    loginUser = Console.ReadLine().ToLower();
                    Console.WriteLine("Password?");
                    loginPass = Console.ReadLine().ToLower();

                    // Check if user exists in the library's accounts
                    foreach (User i in library.Accounts)
                    {
                        if (i.Username == loginUser && i.Password == loginPass)
                        {
                            sessionPass = loginPass;
                            sessionUser = loginUser;
                            sessionID = i.Id;
                            sessionUserObject = i;

                            Console.WriteLine("Logged in " + sessionUser);
                        }
                    }
                    if (sessionPass == "")
                    {
                        Console.WriteLine("Account not found");
                    }
                    break;

                case 2:
                    // Sign up process
                    Console.WriteLine("Username?");
                    username = Console.ReadLine().ToLower();
                    Console.WriteLine("Password?");
                    password = Console.ReadLine().ToLower();
                    Console.WriteLine("Age?");
                    age = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Premium?\n[1] Yes\n[2] No");

                    if (Console.ReadLine() == "1")
                    {
                        premium = true;
                    }
                    else
                    {
                        premium = false;
                    }

                    // Confirm account creation
                    Console.WriteLine("Type 'Confirm' to make your account.");
                    keuze2 = Console.ReadLine().ToLower();

                    if (keuze2 == "confirm")
                    {
                        accountInfo.SignUp(username, password, age, premium);
                        library.Accounts.Add(accountInfo);
                        Console.WriteLine("Account made!");
                    }
                    break;

                case 3:
                    // Get a book process
                    if (sessionUser != "")
                    {
                        // List all books in the library
                        foreach (Book i in library.Books)
                        {
                            if (i.Available)
                            {
                                Console.WriteLine(i.BookName);
                            }
                            else
                            {
                                Console.WriteLine(i.BookName + " (Unavailable)");
                            }
                        }

                        // Ask user which book they want
                        Console.WriteLine("Which book would you like?");
                        string? chosenBook = Console.ReadLine();
                        chosenBook?.ToLower();
                        library.getBook(library, chosenBook, sessionUserObject);
                    }
                    else
                    {
                        Console.WriteLine("Log in first.");
                    }
                    break;

                case 4:
                    // Add a book to the library
                    Console.WriteLine("Book name?");
                    string bookName = Console.ReadLine().ToLower();
                    Console.WriteLine("Book author?");
                    string bookAuthor = Console.ReadLine().ToLower();
                    Console.WriteLine("Book genre?");
                    string bookGenre = Console.ReadLine().ToLower();
                    Console.WriteLine("Book ISBN?");
                    int ISBN = Convert.ToInt32(Console.ReadLine());
                    Book book = new Book();

                    if (sessionUserObject.Premium)
                    {
                        // Add book with premium user privileges
                        premium12.addBook(bookName, bookAuthor, bookGenre, ISBN);
                        library.Books.Add(premium12);
                    }
                    else
                    {
                        // Add book normally
                        book.addBook(bookName, bookAuthor, bookGenre, ISBN);
                    }
                    break;

                case 5:
                    // Return a book
                    foreach (Book i in sessionUserObject.LoanedBooks)
                    {
                        Console.WriteLine(i.BookName);
                    }

                    Console.WriteLine("What book would you like to return?");
                    string bookChoice = Console.ReadLine().ToLower();
                    library.returnBook(sessionUserObject, library, bookChoice);
                    break;

                case 6:
                    // No functionality assigned to case 6
                    break;
            }
        }
    }
}
    