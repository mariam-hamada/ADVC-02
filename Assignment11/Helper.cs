using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment11
{
    internal class Helper
    {
        public static void print(List<Product> list) 
        {
            foreach (Product item in list)
            {
                Console.WriteLine($"{item.Name} - ${item.Price} (Stock: {item.Stock})");
            }
        }

    }
}
