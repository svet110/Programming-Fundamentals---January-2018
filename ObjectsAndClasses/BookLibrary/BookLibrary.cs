namespace BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class BookLibrary
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var library = new Library();
            var books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                Book book = ReadBooks();
                books.Add(book);
            }

            library.Books = books;
            PrintAuthorsList(library);
        }

        public static void PrintAuthorsList(Library library)
        {
            var authorsOrdered = library.Books
                .GroupBy(b => b.Author)
                .Select(g => new
                {
                    Author = g.Key,
                    Prices = g.Sum(s => s.Price)
                })
                .OrderByDescending(b => b.Prices)
                .ThenBy(b => b.Author)
                .ToList();

            foreach (var author in authorsOrdered)
            {
                Console.WriteLine($"{author.Author} -> {author.Prices:F2}");
            }
        }

        public static Book ReadBooks()
        {
            var booksData = Console.ReadLine().Split(' ');
            string bookTitle = booksData[0];
            string bookAuthor = booksData[1];
            string publisher = booksData[2];
            DateTime releaseDate = DateTime.ParseExact(booksData[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            string isbn = booksData[4];
            decimal price = decimal.Parse(booksData[5]);

            Book newBook = new Book
            {
                Title = bookTitle,
                Author = bookAuthor,
                Publisher = publisher,
                ReleaseDate = releaseDate,
                ISBN = isbn,
                Price = price
            };

            return newBook;
        }
    }
}
