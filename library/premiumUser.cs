using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    class premiumUser : Book
    {
        public override void addBook(string name, string author, string genre, int isbn)
        {
            this.BookName = name;
            this.BookAuthor = author;
            this.BookGenre = genre;
            this.ISBN1 = isbn;
        }
    }
}
