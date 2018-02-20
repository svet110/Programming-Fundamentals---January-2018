namespace BookLibraryModification
{
    using System;
    using System.Linq;
    using System.Globalization;
    using System.Collections.Generic;    

    public class LibraryModification
    {
        public static void Main()
        {
            var library = ReadAllBooks();
            var books = library.Books;

            var dict = new Dictionary<string, DateTime>();
            string date = Console.ReadLine();
            DateTime comparisonDate = DateTime.ParseExact(date, "d.M.yyyy", CultureInfo.InvariantCulture);

            foreach (var item in books)
            {
                var title = item.Title;
                var releaseDate = item.ReleaseDate;
                if (!dict.ContainsKey(title))
                {
                    dict.Add(title, releaseDate);
                }
                else
                {
                    dict[title] = releaseDate;
                }
            }

            foreach (var item in dict.OrderBy(x => x.Value).ThenBy(y => y.Key))
            {
                var D = item.Value.Date;
                if (item.Value > comparisonDate)
                {
                    Console.WriteLine("{0} -> {1:d.MM.yyyy}", item.Key, D);
                }
            }
        }

        public static Book ReadBook()
        {
            var book = new Book();
            string[] args = Console.ReadLine().Split(' ');
            book.Title = args[0];
            book.ReleaseDate = DateTime.ParseExact(args[3], "d.M.yyyy", CultureInfo.InvariantCulture);
            return book;
        }

        public static Library ReadAllBooks()
        {
            var library = new Library();
            library.Books = new List<Book>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var book = ReadBook();
                library.Books.Add(book);
            }

            return library;
        }
    }
}
