using System;
using System.Collections.Generic;
using System.Text;


namespace Samplea.Models
{
    class Libaray
    {
        public string Name { get; set; }
        public string Location { get; set; }
        private List<Book> Books { get; set; }

        public Libaray(string name, string location)
        {
            Name = name;
            Location = location;
            Books = new List<Book>();

        }
        public void Addbook(string Book )
        {
            Books = new List<Book>();
        }
        public void PrintedBooks()
        {
            for (int i = 0; i < Books.Count; i++)
            {
                Console.WriteLine($"{i + 1}{Books[i].Title}{Books[i].Author}");
            }
        }

    }


}

