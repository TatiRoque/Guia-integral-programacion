using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Invoice
    {
        public decimal Amount { get; set; }

        public Invoice(decimal amount)
        {
            Amount = amount;
        }

        public override string ToString()
        {
            return $"Invoice - Total: ${Amount}";
        }
    }
}
