﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public override string ToString()
        {
            return $"ID: {Id} | Name: {Name} | Price: ${Price} | Stock: {Stock}";
        }
    }
}
