using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Exercise12
{
    class BookInformation
    {
        private string title;
        private int pages;
        private string year;

        public BookInformation(string title, int pages, string year)
        {
            this.title = title;
            this.pages = pages;
            this.year = year;
        }
        public string Title()
        {
            return title;
        }
        public int Pages()
        {
            return pages;
        }
        public string GetYear()
        {
            return year;
        }
        public static string GetNameFromUser()
        {
            Console.WriteLine("Name (empty will stop):");
            return Console.ReadLine();
        }

        public static string GetYearFromUser()
        {
            Console.WriteLine("Publication year:");
            return Console.ReadLine();
        }

        public static bool BookExists(List<BookInformation> books, string name, string year)
        {
            foreach (BookInformation book in books)
            {
                if (book.Title() == name && book.GetYear() == year)
                {
                    return true;
                }
            }
            return false;
        }

        public static int GetPagesFromUser()
        {
            Console.WriteLine("Pages:");
            return int.Parse(Console.ReadLine());
        }

    }
}
