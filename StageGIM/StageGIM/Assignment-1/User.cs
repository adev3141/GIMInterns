using System;
using LibraryManagementSystem;

namespace LibraryManagementSystem
{    
    public class User(string name, string userId, string email, string borrowedBooks): Library
    {
        // Private fields to store the properties of the user
        //I'm not using them for now :(
        private string Name = name;
        private string UserId = userId;
        private string Email = email;
        private string BorrowedBooks = borrowedBooks;


     
        public virtual void RequestBorrowBook(Library RequestBook)//now has all info from Library
        {

            RequestBook.BorrowBook();

        }

        public virtual void RequestAddBook(Library RequestAdd)
        {//not sure if I will need to use this
            RequestAdd.AddBook();
        }
    }
}

