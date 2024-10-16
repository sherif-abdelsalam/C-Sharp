using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarayManagementSystem
{
    internal class Libarian : User
    {
        public int EmpNumber { get; set; }
        public string AddBook(Book book,Library lib)
        {
            return lib.Add(book);
        }
        public string RemoveBook(string removedBookTitle, int removedBookCount, Library lib)
        {
            string feedback = lib.Remove(removedBookTitle, removedBookCount);
            return feedback;
            
        }

    }
}
