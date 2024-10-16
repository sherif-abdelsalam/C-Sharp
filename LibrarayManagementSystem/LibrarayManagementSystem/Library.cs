using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarayManagementSystem
{
    internal class Library
    {
        private List<Book> books;
        private List<Book> borrowedBooks;
        public Library()
        {
            books = new List<Book>();
            borrowedBooks = new List<Book>();
        }

        public string BorrowBook(string book_name, int amount)
        {
            foreach (var item in books)
            {
                if (item.Title == book_name)
                {
                    if (item.Count >= amount)
                    {
                        item.Count -= amount;
                        if (item.Count == 0) books.Remove(item);
                        
                        borrowedBooks.Add(new Book() { Title = book_name,Authour = item.Authour, 
                            Count = amount,PublishedYear = item.PublishedYear});
                        return "Borrowed Done Succesfully :)";
                    }
                    else
                    {
                        return ("Book existed but the amount you want larger that the available ):");
                    }
                }
            }
            return ("The Book You Want Does Not Exist ):");
        }
        public string Add(Book book)
        {
            foreach (var item in books)
            {
                if (item.Title == book.Title)
                {
                    item.Count += book.Count;
                    return $"Book is Already Exists and the Count is Updated :)";
                }
            }

            books.Add(book);
            return $"Book => (Title: {book.Title}, Authour: {book.Authour}) Added Succesfully";
        }
        public string Remove(string removedBook, int removeBookCount)
        {
            foreach (Book book in books) { 
                if(book.Title == removedBook)
                {
                    if (removeBookCount > book.Count) 
                        return ("\tThe Number Of Books you Entered is larger than the exist ):");

                    book.Count -= removeBookCount;
                    if(book.Count==0) books.Remove(book);
                    return ("\tBooks Removed Succesfully :)");
                    
                }
            }
            return ("\tBook Does Not Exist ):");
        }
        public void Display()
        {
            foreach (Book book in books) {

                Console.WriteLine("\t" + book);
            }
        }
        public void BorrowdDisplay()
        {
            foreach (Book book in borrowedBooks)
            {
                Console.WriteLine("\t" + book);
            }
        }

    }
}
