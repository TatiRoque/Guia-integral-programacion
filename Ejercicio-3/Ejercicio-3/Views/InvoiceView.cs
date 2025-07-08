using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Views
{
    public class InvoiceView
    {
        public void ShowInvoice(Invoice invoice)
        {
            Console.WriteLine("==== Invoice Summary ====");
            Console.WriteLine(invoice.ToString());
            Console.WriteLine("=========================");
        }
    }
}
