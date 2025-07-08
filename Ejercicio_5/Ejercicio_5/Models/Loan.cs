using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Loan
    {
        public Book Book { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }

        public override string ToString() => $"Loan: {Book.Title} to {User.Name} on {Date.ToShortDateString()}";
    }
}
