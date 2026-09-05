namespace Assignment11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> catalog = new()
            {
                new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 } ,
                new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25} ,
                new Product { Id = 3, Name = "T-shirt", Category = "Clothing", Price = 30, Stock = 100 } ,
                new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 } ,
                new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 } ,
                new Product { Id = 6, Name = "Coffe Beans", Category = "Food", Price = 15, Stock = 80 } ,
                new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 } ,
                new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 } ,
                new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 } ,
                new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 120, Stock = 15 }
            };

            #region Task 1
            //List<Product> Electronics = Product.SearchProducts(catalog, (product) => product.Category == "Electronics");
            //Console.WriteLine("--- Electronics ---");
            //Helper.print(Electronics);

            //Console.WriteLine();

            //List<Product> Under50 = Product.SearchProducts(catalog, (product) => product.Price < 50);
            //Console.WriteLine("--- Under $50 ---");
            //Helper.print(Under50);

            //Console.WriteLine();

            //List<Product> InStock = Product.SearchProducts(catalog, (product) => product.Stock > 0);
            //Console.WriteLine("--- In Stock ---");
            //Helper.print(InStock);

            //Console.WriteLine();

            //List<Product> ClothingUnder100 = Product.SearchProducts(catalog, (product) => product.Category == "Clothing" && product.Price<100);
            //Console.WriteLine("--- Clothing Under $100 ---");
            //Helper.print(ClothingUnder100); 
            #endregion

            #region Task 3.1

            //Console.WriteLine("--- Short Report ---");
            //Product.PrintReport(catalog, (Product) => Console.WriteLine($"{Product.Name} - ${Product.Price}"));

            //Console.WriteLine();

            //Console.WriteLine("--- Detailed Report ---");
            //Product.PrintReport(catalog, (Product) => Console.WriteLine($"[{Product.Category}] {Product.Name} | Price: ${Product.Price} | Stock: {Product.Stock}"));

            #endregion

            #region Task 3.2

            //Console.WriteLine("--- Summary List ---");
            //List<string> summary = Product.TransformProducts(catalog, (Product) => $"{Product.Name} (${Product.Price})");
            //foreach(string str in summary)
            //{
            //    Console.WriteLine(str);
            //}

            //Console.WriteLine();

            //Console.WriteLine("--- Price Labels ---");
            //List<string> Price = Product.TransformProducts(catalog, (Product) => { if (Product.Price > 100) return $"{Product.Name}: Expensive!"; else return $"{Product.Name}: Affordable"; });
            //foreach (string str in Price)
            //{
            //    Console.WriteLine(str);
            //}

            #endregion
        }
    }
}
