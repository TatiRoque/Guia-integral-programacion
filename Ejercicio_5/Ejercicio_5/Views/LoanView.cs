using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Views
{
    public class LoanView
    {
        public void ShowLoans(List<Loan> loans)
        {
            foreach (var loan in loans)
                Console.WriteLine(loan);
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
