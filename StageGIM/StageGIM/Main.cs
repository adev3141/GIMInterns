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

            library.AddBook();
            library.AddBook();
            library.BorrowBook();
            library.ReturnBook();
       //     library.RemoveBook();

        }
    }
}

