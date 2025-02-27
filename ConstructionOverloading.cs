using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCoding
{
    class ConstructionOverloading
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        // Default Constructor
        public ConstructionOverloading()
        {
            Title = "Unknown";
            Author = "Unknown";
            ISBN = "000-0000000000";
        }

        // Constructor with Title and Author
        public ConstructionOverloading(string title, string author)
        {
            Title = title;
            Author = author;
            ISBN = "000-0000000000";
        }

        // Constructor with Title, Author, and ISBN
        public ConstructionOverloading(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        public void Display()
        {
            Console.WriteLine($"\nBook Details:\nTitle: {Title}\nAuthor: {Author}\nISBN: {ISBN}");
        }
    }
}
