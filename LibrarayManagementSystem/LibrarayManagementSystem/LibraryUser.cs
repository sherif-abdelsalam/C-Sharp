using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarayManagementSystem
{
    internal class LibraryUser : User
    {
        LibraryCard card = new();

        public LibraryCard Card { get { return card; } set { card = value; } }


        public string BorrowBook(string book_name, int amount, Library lib)
        {
            string feedback = lib.BorrowBook(book_name, amount);
            return feedback;
        }
        public void DisplayBorrowdBooks(Library lib)
        {
            lib.BorrowdDisplay();
        }


    }


}
