using System;

namespace ManagementSytem.clases
{
    public class Book(string title, string author, string isbn, string genre, bool isAvailable)
    {
        // Private fields to store the properties of the book
        public string Title = title;
        public string Author = author;
        public string ISBN = isbn;
        public string Genre = genre;
        public bool IsAvailable = isAvailable;
    }

}

