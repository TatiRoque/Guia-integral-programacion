using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Interfaces;

namespace Services
{
    public class InvoicePrinter
    {
        private readonly IPrintable _printer;

        public InvoicePrinter(IPrintable printer)
        {
            _printer = printer;
        }

        public void Print(Invoice invoice)
        {
            _printer.Print(invoice.ToString());
        }
    }
}
