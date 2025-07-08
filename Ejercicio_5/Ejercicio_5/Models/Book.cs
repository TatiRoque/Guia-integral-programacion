using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; } = true;


        public override string ToString() => $"{Title} by {Author} (ISBN: {ISBN}) - {(IsAvailable ? "Available" : "Loaned")}";
    }
}
