using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Book_Library_Modification
{
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }

    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ISBN { get; set; }
        public decimal Price { get; set; }

        public Book(string title, string author, string publisher, DateTime releaseDate, int isbn, decimal price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            ISBN = isbn;
            Price = price;
        }
    }

    class Program
    {
        static Book ReadBook()
        {
            List<string> Tokens = Console.ReadLine().Split().ToList();

            string title = Tokens[0];
            string author = Tokens[1];
            string publisher = Tokens[2];
            DateTime releaseDate = DateTime.ParseExact(Tokens[3], "dd.MM.yyyy", null);
            int isbn = int.Parse(Tokens[4]);
            decimal price = decimal.Parse(Tokens[5]);

            Book book = new Book(title, author, publisher, releaseDate, isbn, price);

            return book;
        }
        static void Main(string[] args)
        {
            Library library = new Library();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Book book = ReadBook();
                library.Books.Add(book);
            }

            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);

            library.Books = library.Books
                .Where(w => w.ReleaseDate.CompareTo(date) == 1)
                .OrderBy(w => w.ReleaseDate)
                .ThenBy(w => w.Title)
                .ToList();

            foreach (var book in library.Books)
            {
                string title = book.Title;
                string releaseDate = book.ReleaseDate.Date.ToString("dd.MM.yyyy");

                Console.WriteLine($"{title} -> {releaseDate}");
            }
        }
    }
}
