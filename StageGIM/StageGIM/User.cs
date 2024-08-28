using System;

namespace ManagementSytem.clases
{
    public class User
    {
        // Private fields to store the properties of the user
        private string Name;
        private string UserId;
        private string Email;
        private string BorrowedBooks;

        // Constructor to initialize the fields of the book
        public User(string name, string userId, string email, string borrowedBooks)
        {
            Name = name;
            UserId = userId;
            Email = email;
            BorrowedBooks = borrowedBooks;
        }

    }
}

