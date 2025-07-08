using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Views
{
    public class ProductView
    {
        public void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("=== Hardware Store - Product Management ===");
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. Delete product");
            Console.WriteLine("3. Update product");
            Console.WriteLine("4. List all products");
            Console.WriteLine("0. Exit");
            Console.Write("Option: ");
        }

        public Product RequestProductData(int newId)
        {
            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Price: ");
            decimal.TryParse(Console.ReadLine(), out var price);

            Console.Write("Stock: ");
            int.TryParse(Console.ReadLine(), out var stock);

            return new Product { Id = newId, Name = name, Price = price, Stock = stock };
        }

        public int RequestId(string message)
        {
            Console.Write(message);
            int.TryParse(Console.ReadLine(), out var id);
            return id;
        }

        public void ShowProducts(List<Product> products)
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No products found.");
            }
            else
            {
                foreach (var p in products)
                    Console.WriteLine(p);
            }
            Console.ReadLine();
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
            Console.ReadLine();
        }

        public int SelectFieldToUpdate()
        {
            Console.WriteLine("1. Change name");
            Console.WriteLine("2. Change price");
            Console.WriteLine("3. Change stock");
            Console.Write("Option: ");
            int.TryParse(Console.ReadLine(), out var opt);
            return opt;
        }

        public string RequestText(string field)
        {
            Console.Write($"New {field}: ");
            return Console.ReadLine();
        }

        public decimal RequestDecimal(string field)
        {
            Console.Write($"New {field}: ");
            decimal.TryParse(Console.ReadLine(), out var val);
            return val;
        }

        public int RequestInt(string field)
        {
            Console.Write($"New {field}: ");
            int.TryParse(Console.ReadLine(), out var val);
            return val;
        }
    }
}
