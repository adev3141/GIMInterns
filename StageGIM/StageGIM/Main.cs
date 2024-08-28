using System;
using ManagementSytem.clases;

namespace ManagementSytem.classes
{
    class MainWindow
    {
        static void Main(string[] args)
        {
            // Book MyBook = new Book("Harry Potter", "J.k ", "422541", "Fantasy", true);

            var library = new Library();
            library.Proberen();

            Console.WriteLine("Press any key to close...");
            Console.ReadKey();

        }
    }
}

