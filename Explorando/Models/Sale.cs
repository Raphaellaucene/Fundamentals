using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Sale
    {
        //Constructor
        public Sale(int id, string prod, decimal price, DateTime dtSale)
        {
            Id = id;
            Product = prod;
            Price = price;
            DateSale = dtSale;
        }

        public int Id {get; set;}
        public string Product {get; set;}
        public decimal Price {get; set;}
        public DateTime DateSale {get; set;}
    }
}