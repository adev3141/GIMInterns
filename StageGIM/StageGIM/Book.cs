using System;

namespace ManagementSytem.clases
{
    public class Book(string title, string author, string isbn, string genre, string isAvailable)
    {
        //might need to change so i can make it private
        public string Title = title;
        public string Author = author;
        public string ISBN = isbn;
        public string Genre = genre;
        public string IsAvailable = isAvailable;


       
    }
  
}

