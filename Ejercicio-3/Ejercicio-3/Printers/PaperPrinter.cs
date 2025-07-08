using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Printers
{
    public class PaperPrinter : IPrintable
    {
        public void Print(string content)
        {
            Console.WriteLine("Printing on paper...");
            Console.WriteLine("Content: " + content);
        }
    }
}
