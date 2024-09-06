using System;
using LibraryManagementSystem;

namespace LibraryManagementSystem
{
    public class Book(string title, string author, string isbn, string genre, bool isAvailable)
    {       //is this oke to be public?
        public string Title { get; set; } = title;
        public string Author { get; set; } = author;
        public string ISBN { get; set; } = isbn;
        public string Genre { get; set; } = genre;
        public bool IsAvailable { get; set; } = isAvailable;
    }
}
