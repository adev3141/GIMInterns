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
        {

            Console.WriteLine("Give the number of books you want to borrow");//asks for amount of books to borrow and keeps it in variable
            string AmountBookInput = Console.ReadLine();

            //A loop that goes through iy=t by the amount put in by the user in AmountBookInput if the amount is a number above 0
            if (int.TryParse(AmountBookInput, out int AmountBooks) && AmountBooks > 0)
            {
                for (int counter = 0; counter < AmountBooks; counter++)
                {
                    base.RequestBorrowBook(Library);
                }
            }
            else
            {//if the input is not a number or not above 0 it comes here
                Console.WriteLine("Invalid number of books");
            }
        }


    }
}


            


