using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views;

namespace Controllers
{
    public class BookController
    {
        private readonly DataRepository _repo;
        private readonly BookView _view = new();

        public BookController(DataRepository repo)
        {
            _repo = repo;
        }

        public void AddBook()
        {
            var book = _view.CreateBook();
            _repo.Books.Add(book);
        }

        public void ListAvailableBooks()
        {
            var available = _repo.Books.Where(b => b.IsAvailable).ToList();
            _view.ShowBooks(available);
        }
    }
}
