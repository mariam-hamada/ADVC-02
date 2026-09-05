using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment11
{
    public class Product
    {
        public  int Id { get; set; }
        public  string Name { get; set; }
        public  string Category { get; set; }
        public  double Price { get; set; }
        public  int Stock { get; set; }

        public static List<Product> SearchProducts(List<Product> products, Func<Product , bool> SearchDelegate)
        {
            // we use Func because it takes one paramenter of type product and return boolean , Predicate satisfies the conditions also 
            List<Product> result = new List<Product>();
            foreach (Product p in products) 
            { 
                if (SearchDelegate(p))
                    result.Add(p);
            }
            return result;
        }
    }
}
