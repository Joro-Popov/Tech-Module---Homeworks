using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
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
        static Book ReadBook(string input)
        {
            List<string> Tokens = input.Split().ToList();

            string title = Tokens[0];
            string author = Tokens[1];
            string publisher = Tokens[2];
            DateTime releaseDate = DateTime.ParseExact(Tokens[3], "dd.MM.yyyy", null);
            int isbn = int.Parse(Tokens[4]);
            decimal price = decimal.Parse(Tokens[5]);

            Book book = new Book(title, author, publisher, releaseDate, isbn, price);

            return book;
        }
        static bool IsPresent(Book book, Library library)
        {
            bool isPresent = false;

            for (int i = 0; i <= library.Books.Count - 1; i++)
            {
                Book currentBook = library.Books[i];

                if (book.Author == currentBook.Author)
                {
                    isPresent = true;
                    break;
                }
            }

            return isPresent;
        }
        static void AddPrice(Book book, Library library)
        {
            for (int i = 0; i <= library.Books.Count - 1; i++)
            {
                Book currentBook = library.Books[i];

                if (book.Author == currentBook.Author)
                {
                    currentBook.Price += book.Price;

                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            Library library = new Library();

            string[] Input = File.ReadAllLines("Input.txt");

            for (int i = 1; i <= Input.Length-1; i++)
            {
                Book book = ReadBook(Input[i]);

                if (library.Books.Count == 0)
                {
                    library.Books.Add(book);
                }
                else
                {
                    if (!IsPresent(book, library))
                    {
                        library.Books.Add(book);
                    }
                    else
                    {
                        AddPrice(book, library);
                    }
                }
            }

            library.Books = library.Books
                .OrderByDescending(w => w.Price)
                .ThenBy(w => w.Author)
                .ToList();

            using (StreamWriter writer = new StreamWriter("Output.txt",true))
            {
                foreach (var book in library.Books)
                {
                    string author = book.Author;
                    decimal price = book.Price;

                    string result = ($"{author} -> {price:f2}");

                    writer.WriteLine(result);
                }
            }
        }
    }
}
