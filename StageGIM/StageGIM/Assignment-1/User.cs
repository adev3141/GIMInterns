using System;
using LibraryManagementSystem;

namespace LibraryManagementSystem
{
   
    public class User
    {
       

        public string Name { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
        public string BorrowedBooks { get; set; }
        public bool IsPremium { get; set; } // Add a boolean to indicate if the user is premium
                                         
         // Constructor to initialize the user
        public User(string name, string userId, string email, string borrowedBooks)
        {
            Name = name;
            UserId = userId;
            Email = email;
            BorrowedBooks = borrowedBooks;
            //membershipLevel = membershipLevel;
        }

        public virtual void BorrowBookPremium(Library RequestBook)//now has all info from Library
        {
           
            RequestBook.BorrowBookStandard();

        }

        public virtual void RequestAddBook(Library RequestAdd)
        {//not sure if I will need to use this
            RequestAdd.AddBook();
        }
    }
}

