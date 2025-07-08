using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Views
{
    public class BookView
    {
        public void ShowBooks(List<Book> books)
        {
            foreach (var book in books)
                Console.WriteLine(book);
        }

        public Book CreateBook()
        {
            Console.Write("Title: ");
            var title = Console.ReadLine();
            Console.Write("Author: ");
            var author = Console.ReadLine();
            Console.Write("ISBN: ");
            var isbn = Console.ReadLine();

            return new Book { Title = title, Author = author, ISBN = isbn };
        }

        public string GetISBN(List<Book> books)
        {
            ShowBooks(books);
            Console.Write("Enter ISBN: ");
            return Console.ReadLine();
        }
    }
}
