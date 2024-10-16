using System.Text;
namespace LibrarayManagementSystem;
class Program{

    public static void wait_or_clear(bool clear_screen = false)
    {
        Thread.Sleep(3000);
        if (clear_screen) Console.Clear();
    }
    public static void printline(string msg, bool end_line = true)
    {
        Console.WriteLine(msg + (end_line ? "\n" : "\t"));
    }
    public static void print_try_again()
    {
        printline("\n\aInvalid Choice Try Again!!!!!!!!", true);
        wait_or_clear(true);
        Intro("Welcome to the Library Management System");
    }
    public static void Intro(string mesasge)
    {
        Console.Clear();
        Console.WriteLine("\n\n\n");
        Console.WriteLine($"\t\t\t\t\t {mesasge} ");
        Console.WriteLine("\t\t\t\t\t ======================================== ");
    }


    ////////////////////////////////////////////////////////////////////////////


    public static Book AddBookLibarian()
    {
        Console.WriteLine("\t====================================\n");
        Console.Write("\tEnter Book Name : ");
        string? book_title = Console.ReadLine();
        Console.Write("\tEnter Book Authour : ");
        string? book_author = Console.ReadLine();
        Console.Write("\tEnter Book Published Year : ");
        int book_year = Convert.ToInt32(Console.ReadLine());
        Console.Write("\tEnter Number Of Books You Want to add: ");
        int book_count = Convert.ToInt32(Console.ReadLine());

        Book book = new Book()
        {
            Title = book_title,
            Authour = book_author,
            PublishedYear = book_year,
            Count = book_count
        };
        return book;
    }
    public static (string,int) RemoveBookLibarian()
    {
        Console.WriteLine();
        Console.Write("\tEnter Book Name : ");
        string book_title = Console.ReadLine();

        Console.Write("\tEnter Number of Books you want to remove: ");
        int count = Convert.ToInt32(Console.ReadLine());

        return (book_title,count);
    }
    public static void HandleLibarian(Library lib)
    {
        Console.Write("Enter Your name Please : ");
        string libarianName = Console.ReadLine();
        Console.Write("Enter Your Id Number Please : ");
        int libarianNumber = int.Parse(Console.ReadLine());
        Libarian libarian = new Libarian()
        {
            Name = libarianName,
            EmpNumber = libarianNumber
        };

        while (true)
        {
            Console.Clear();
            Console.Write($"\n\tWelcome Mr: {libarianName}");
            Console.WriteLine("   ==>   Please Selcect What you want to do.");
            Console.WriteLine("\t=============================================================");
            Console.WriteLine("\t1. Add Book");
            Console.WriteLine("\t2. Remove Book");
            Console.WriteLine("\t3. Display all books");
            Console.WriteLine("\t0. Return to the Previous Page");

            Console.Write("\n\tYour Choice : ");

            int choice = int.Parse(Console.ReadLine());
      
            switch (choice)
            {
                case 1:
                    Book newBook = AddBookLibarian();
                    string result = libarian.AddBook(newBook, lib);
                    Console.WriteLine("\n\t" + result);
                    break;
                case 2:
                    (string removedBookName, int removedBookCount) = RemoveBookLibarian();
                    Console.WriteLine(libarian.RemoveBook(removedBookName, removedBookCount, lib));
                    break;
                case 3:
                    Console.WriteLine();
                    libarian.DisplayBook(lib);
                    Console.Write("\n\n\tPress Any Key to return to the previous Page: ");
                    char key = Console.ReadLine()[0];
                    break;
                case 0:
                    return;
                default:
                    break;
            }
            Thread.Sleep(1500);
        }
    }

    public static (string,int) BorrowBookRegualarUser()
    {
        Console.Write("\tEnter the name of the book: ");
        string book_name = Console.ReadLine();

        Console.Write("\tEnter amount: ");
        int book_amount = int.Parse(Console.ReadLine());

        return (book_name, book_amount);
    }
    public static void HandleRegualarUser(Library lib)
    {
        Console.Write("Enter Your name Please : ");
        string userName = Console.ReadLine();
        Console.Write("Enter Your Card Number Please : ");
        int UserCardNumber = int.Parse(Console.ReadLine());
        LibraryUser user = new LibraryUser()
        {
            Name = userName,
            Card = new LibraryCard() { Number = UserCardNumber }
        };

        while (true)
        {
            Console.Clear();
            Console.Write($"\n\tWelcome Mr: {userName}");
            Console.WriteLine("   ==>   Please Selcect What you want to do.");
            Console.WriteLine("\t=============================================================");
            Console.WriteLine("\t1. Borrow Book");
            Console.WriteLine("\t2. Display all books");
            Console.WriteLine("\t3. Display Borrowd books");
            Console.WriteLine("\t0. Return to the Previous Page");

            Console.Write("\n\tYour Choice : ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    (string book_name, int book_amount) = BorrowBookRegualarUser();
                    string result = user.BorrowBook(book_name, book_amount, lib);
                    Console.WriteLine("\n\t" + result);
                    break;
                case 2:
                    Console.WriteLine();
                    user.DisplayBook(lib);
                    Console.Write("\n\n\tPress Any Key to return to the previous Page: ");
                    char key = Console.ReadLine()[0];
                    break;

                case 3:
                    Console.WriteLine();
                    user.DisplayBorrowdBooks(lib);
                    Console.Write("\n\n\tPress Any Key to return to the previous Page: ");
                    key = Console.ReadLine()[0];
                    break;
                case 0:
                    return;
                default:
                    break;
            }
            Thread.Sleep(1500);
        }
    }



    static void Main()
    {
        Library library = new Library();

        int switch_on = -1;
        Console.ForegroundColor = ConsoleColor.Yellow;
        Intro("Welcome to the Library Management System");
        Thread.Sleep(1500);

        while (switch_on != 0)
        {
            Console.Clear();
            Console.WriteLine("\nPlease Select => Are you: ");
            Console.WriteLine("1. Libarian");
            Console.WriteLine("2. Regualar User");
            Console.WriteLine("0. Quit");
            Console.WriteLine("===========================================");
            Console.Write("Enter your Choice : "); 
            switch_on = Convert.ToInt32(Console.ReadLine());

            switch (switch_on)
            {
                case 1:
                    Intro("    << Welocome to Libarians Page >>");
                    HandleLibarian(library);
                    break;

                case 2:
                    Intro(" << Welocome to Regular User Page >>");
                    HandleRegualarUser(library);
                    break;
                case 0:
                    Console.Write("\t\t\t\t\t      Thank You..........:) Good Bye.\n\n");
                    Environment.Exit(0);
                    break;
                default:
                    print_try_again();
                    break;
            }

        }

    }
}
