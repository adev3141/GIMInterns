using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.clases;


namespace LibraryManagementSystem.clases
{
    public class PremiumUser(string name, string userId, string email, string borrowedBooks, string membershipLevel, Library library) : User(name, userId, email, borrowedBooks)
    {
        public string MembershipLevel { get; } = membershipLevel;
        public Library Library { get; } = library;

        //Am to be able to use BorrowBook but need to be able to borrow more than one. 

        public override void RequestBorrowBook(Library Library)
        {//need to change that it can borrow more then one book
            Console.WriteLine("PremiumUser");
            base.RequestBorrowBook(Library);
          
        }

        public override void RequestAddBook(Library RequestAdd)//don't know if i need to use this for RequestBorrowBook
        {
            base.RequestAddBook(RequestAdd);
        }

    }
}

            


