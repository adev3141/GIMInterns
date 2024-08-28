using System;
using ManagementSytem.clases;

namespace ManagementSytem.classes
{
    class MainWindow
    {
        static void Main(string[] args)
        {
           

            var library = new Library();
            library.Proberen();
            library.AddBook();

            library.RemoveBook();

        }
    }
}

