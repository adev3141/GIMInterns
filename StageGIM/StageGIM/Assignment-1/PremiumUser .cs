using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem;


namespace LibraryManagementSystem
{
    public class PremiumUser(string name, string userId, string email, string borrowedBooks, Library library) : User(name, userId, email, borrowedBooks)
    {
      //  public string MembershipLevel { get; } = membershipLevel;
        public Library Library { get; } = library;

     

        public override void BorrowBookPremium(Library Library)
        {//borrows more then one book 

            

            Console.WriteLine("Give the number of books you want to borrow");//asks for amount of books to borrow and keeps it in variable
            string AmountBookInput = Console.ReadLine();

            //A loop that goes through iy=t by the amount put in by the user in AmountBookInput if the amount is a number above 0
            if (int.TryParse(AmountBookInput, out int AmountBooks) && AmountBooks > 0)
            {
                for (int counter = 0; counter < AmountBooks; counter++)
                {
                    base.BorrowBookPremium(Library);
                }
            }
            else
            {//if the input is not a number or not above 0 it comes here
                Console.WriteLine("Invalid number of books");
            }
        }


    }
}


            


