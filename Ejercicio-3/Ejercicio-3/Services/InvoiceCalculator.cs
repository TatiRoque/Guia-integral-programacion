using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services
{
    public class InvoiceCalculator
    {
        public Invoice CalculateInvoice()
        {
            decimal total = 1000;
            return new Invoice(total);
        }
    }
}
