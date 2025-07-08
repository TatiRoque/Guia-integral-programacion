using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Printers
{
    public class DigitalPrinter : IPrintable
    {
        public void Print(string content)
        {
            Console.WriteLine("Generating digital file...");
            Console.WriteLine("Content: " + content);
        }
    }
}
