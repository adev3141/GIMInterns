using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class User()
    {
        static int id = 0;
        int age;
        string password;
        int maxBookAmount = 3;
        string username;
        bool premium = false;
        List<Book> loanedBooks = new List<Book>();
        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public string Password { get => password; set => password = value; }
        public string Username { get => username; set => username = value; }
        public bool Premium { get => premium; set => premium = value; }
        internal List<Book> LoanedBooks { get => loanedBooks; set => loanedBooks = value; }

        public List<string> SignUp(string username, string password, int age, bool premium)
        {
            Id++;
            List<string> accountInfo = new List<string>();
            id = id + 1;
            this.age = age;
            this.Premium = premium;
            this.password = password;
            this.username = username;

            return accountInfo;
        }

    }
}
