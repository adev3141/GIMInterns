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
        public Library Library { get; }

        public override void RequestBorrowBook()
        {

            base.RequestBorrowBook();
        }
    }
}

            


