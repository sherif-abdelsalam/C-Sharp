using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarayManagementSystem;

abstract class User
{

    private string name = string.Empty;
    public string Name { get { return name; } set { name = value; } }

    public void DisplayBook(Library lib)
    {
        lib.Display();
    }
}
