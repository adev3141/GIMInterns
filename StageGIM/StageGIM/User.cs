using System;
using LibraryManagementSystem.classes;

namespace LibraryManagementSystem.clases
{    
    public class User(string name, string userId, string email, string borrowedBooks)
    {
        // Private fields to store the properties of the user
        private string Name = name;
        private string UserId = userId;
        private string Email = email;
        private string BorrowedBooks = borrowedBooks;
    }
}

