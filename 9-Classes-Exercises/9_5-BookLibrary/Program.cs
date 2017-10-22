using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5_BookLibrary
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var priceByAuthor = new Dictionary<string, double>();

            while (n-- > 0)
            {
                var input = Console.ReadLine().Split();
                Book book = new Book()
                {
                    Title = input[0],
                    Author = input[1],
                    Publisher = input[2],
                    ReleaseDate = DateTime.ParseExact(input[3],"dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = input[4],
                    Price = double.Parse(input[5])
                };

                // Remember authors and their books prices
                if (!priceByAuthor.ContainsKey(book.Author))
                {
                    priceByAuthor.Add(book.Author, book.Price);
                }
                else
                {
                    priceByAuthor[book.Author] += book.Price;
                }
            }

            priceByAuthor = priceByAuthor.OrderByDescending(a => a.Value).ThenBy(a => a.Key).ToDictionary(au => au.Key, pr => pr.Value);

            foreach (var a in priceByAuthor)
            {
                Console.WriteLine($"{a.Key} -> {a.Value:F2}");
            }

        }
    }
}
