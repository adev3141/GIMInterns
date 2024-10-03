using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal interface IUser
    {//not sure if I did this right
        void BorrowBook();

        void ReturnBook();
    }
}
