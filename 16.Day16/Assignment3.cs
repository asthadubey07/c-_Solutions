using System;
using System.Collections.Generic;

class Products
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public int UnitPrice { get; set; }
    public string Category { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<Products> products = new List<Products>()
        {
             new Product{ProductId= 100, Name = "top", Category = "cloth",UnitPrice = 32154.5, Quantity = 10 },
            new Product{ProductId= 200, Name = "croptop", Category = "cloth",UnitPrice = 42154.5, Quantity = 20 },
            new Product{ProductId= 300, Name = "cream", Category = "makeup",UnitPrice = 52154.5, Quantity = 30 },
            new Product{ProductId= 400, Name = "bike", Category = "electrical",UnitPrice = 654654.5, Quantity = 20 },
            new Product{ProductId= 500, Name = "car", Category = "electrical",UnitPrice = 32556.5, Quantity = 20 },
            new Product{ProductId= 600, Name = "phone", Category = "electrical",UnitPrice = 86554.5, Quantity = 30 },
            new Product{ProductId= 700, Name = "jeans", Category = "cloth",UnitPrice = 1654654.5, Quantity = 20 },
            new Product{ProductId= 800, Name = "powder", Category = "makeup",UnitPrice = 32156.5, Quantity = 20 },
            new Product{ProductId= 900, Name = "kurti", Category = "cloth",UnitPrice = 65454.5, Quantity = 10 },
            new Product{ProductId= 1000, Name = "kajal", Category = "makeup",UnitPrice = 658932.5, Quantity = 20 }
        };

        var query1 = from product in products
                     select new {product.UnitPrice, product.Name};
        
        foreach(var item in query1)
        {   
            Console.WriteLine("{0} {1}", item.Name, item.UnitPrice);
        }

        var query2 = from product in products
                     select new {product.Name, product.Category};

        foreach(var item in query2)
        {
            Console.WriteLine("{0} {1}", item.Name, item.Category);
        }

        var query3 = from product in products
                     group product by product.Category into groups
                     select groups;
        Console.WriteLine("Products based on category: ");
        foreach(var group in query3)
        {
            Console.WriteLine("Products under the category " + group.Key);
            foreach(var product in group)
            {
                Console.Write(product.Name + " ");
            }
        }
    }
}