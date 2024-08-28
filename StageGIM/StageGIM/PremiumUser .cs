using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.clases;

namespace LibraryManagementSystem.classes
{
    internal class PremiumUser(string name, string userId, string email, string borrowedBooks, string membershipLevel) : User(name, userId, email, borrowedBooks)
    {
        public string MembershipLevel { get; } = membershipLevel;
    }
}
