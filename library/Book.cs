using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
     class Book
    {
        int ISBN;
        string bookName;
        string bookAuthor;
        string bookGenre;
        Boolean available = true;

        public int ISBN1 { get => ISBN; set => ISBN = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public string BookAuthor { get => bookAuthor; set => bookAuthor = value; }
        public string BookGenre { get => bookGenre; set => bookGenre = value; }

        public bool Available { get => available; set => available = value; }

        public virtual void addBook(string name, string author, string genre, int isbn) { 
            
            Console.WriteLine("You need premium to add a book..");

        }
       
    }
}
