using Models;
using Printers;
using Services;
using Views;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Calculate invoice
            var calculator = new InvoiceCalculator();
            Invoice invoice = calculator.CalculateInvoice();

            // 2. Show on screen (view)
            var view = new InvoiceView();
            view.ShowInvoice(invoice);

            // 3. Print invoice (paper or digital)
            var printer = new InvoicePrinter(new PaperPrinter()); // or new DigitalPrinter()
            printer.Print(invoice);

            // 4. Save invoice
            var saver = new InvoiceSaver();
            saver.Save(invoice);

            Console.ReadLine();
        }
    }
}