using Repository;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Views;

namespace Controllers
{
    public class LoanController
    {
        private readonly DataRepository _repo;
        private readonly LoanView _view = new();

        public LoanController(DataRepository repo)
        {
            _repo = repo;
        }

        public void LendBook(string isbn, string email)
        {
            var book = _repo.Books.FirstOrDefault(b => b.ISBN == isbn && b.IsAvailable);
            var user = _repo.Users.FirstOrDefault(u => u.Email == email);

            if (book == null || user == null)
            {
                _view.ShowMessage("Book or user not found, or book not available.");
                return;
            }

            book.IsAvailable = false;
            _repo.Loans.Add(new Loan { Book = book, User = user, Date = DateTime.Now });
            _view.ShowMessage("Book loaned successfully.");
        }

        public void ReturnBook(string isbn)
        {
            var loan = _repo.Loans.FirstOrDefault(l => l.Book.ISBN == isbn);
            if (loan == null)
            {
                _view.ShowMessage("Loan not found.");
                return;
            }

            loan.Book.IsAvailable = true;
            _repo.Loans.Remove(loan);
            _view.ShowMessage("Book returned successfully.");
        }

        public void ListLoans()
        {
            _view.ShowLoans(_repo.Loans);
        }
    }
}
