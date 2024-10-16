using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarayManagementSystem
{
    internal class Book
    {
        public string? Title { get; set; } = string.Empty;
        public string? Authour { get; set; } = string.Empty;
        public int PublishedYear { get; set; }
        public int Count {  get; set; }


        public override string ToString()
        {
            return $"Boot Title: {Title}, Authour: {Authour}, Count: " +
                $"{Count}, Published Year: {PublishedYear}";
        }
    }
}
