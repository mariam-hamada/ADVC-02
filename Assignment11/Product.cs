using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment11
{
    public class Product
    {
        #region properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        #endregion

        #region Methods
        public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> SearchDelegate)
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

        public static void PrintReport (List<Product> products , Action<Product> PrintProduct)
        {
            // we use Action because it takes one paramenter of type product and Doexn't return Anything .
            foreach (Product p in products)
            {
                PrintProduct(p);
            }
        }

        public static List<string> TransformProducts(List<Product> products, Func<Product, string> transform) 
        {
            // we use Func because it takes one paramenter of type product and return list of strings .
            List<string> result = new List<string>();
            foreach (Product p in products)
            {
                result.Add(transform(p));
            }
            return result;

        }

        public static List<Product> FilterProducts (List<Product> products , Predicate<Product> filter)
        {
            // we use Predicate because it takes one paramenter of type product and return bool .
            List<Product> result = new List<Product>();
            foreach (Product p in products)
            {
                if (filter(p))
                    result.Add(p);
            }
            return result;
        }

        #endregion

    }
}
