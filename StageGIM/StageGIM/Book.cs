using System;
using ManagementSystem.classes;

namespace ManagementSystem.classes
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
        public bool IsAvailable { get; set; }  // Changed to bool to reflect true/false availability

        // Constructor for Book
        public Book(string title, string author, string isbn, string genre, bool isAvailable)
        {
            this.Title = title;
            this.Author = author;
            this.ISBN = isbn;
            this.Genre = genre;
            this.IsAvailable = isAvailable;
        }
    }
}
