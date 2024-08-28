using System;
using ManagementSytem.clases;

namespace ManagementSytem.classes
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

