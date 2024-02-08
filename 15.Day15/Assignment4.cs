/*4.  Implement the following requirements using Lambda Expressions. 	

			a.  Consider the products collections:
							Props :   ProductId, Name, Quantity, UnitPrice, Category
							
						i.  Get the product based on the product id
						ii. Get the products based on the category
						iii. Find out how many products are out of stock (means quantity is zero)
						iv.  Display the products which price is under 2000 
						v.  Display the products which name starts with "A"
						vi.  Display the products which price is under 2000  and in specific category */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Products
{
    public int ProductId { get; set; }
    public string? ProductName { get; set; }
    public int Quantity { get; set; }
    public int UnitPrice { get; set; }
    public string? Category { get; set; }
}

internal class Program
{
    public static void Main(string[] args)
    {
        List<Products> products = new List<Products>(){
            new Products{ProductId= 101, ProductName = "Iphone", Quantity = 0,UnitPrice = 500000000,Category = "Electronic"},
            new Products{ProductId= 201, ProductName = "mobile", Quantity = 6,UnitPrice = 3000065,Category = "Electronic"},
            new Products{ProductId= 301, ProductName = "Chair", Quantity = 8,UnitPrice = 10000,Category = "Furniture"},
            new Products{ProductId= 401, ProductName = "car", Quantity = 1,UnitPrice = 500000770,Category = "whicle"},
            new Products{ProductId= 501, ProductName = "bike", Quantity = 2,UnitPrice = 1250000,Category = "whicle"},
            new Products{ProductId= 601, ProductName = "Bed", Quantity = 0,UnitPrice = 500,Category = "Furniture"},
            new Products{ProductId= 701, ProductName = "jeans", Quantity = 10,UnitPrice = 45000,Category = "Cloth"},
            new Products{ProductId= 801, ProductName = "sari", Quantity = 3,UnitPrice = 180000,Category = "Cloth"},
            new Products{ProductId= 901, ProductName = "Deo", Quantity = 2,UnitPrice = 20000,Category = "Beauty"},
            new Products{ProductId= 1001, ProductName = "Eyeliner", Quantity = 2,UnitPrice = 8000,Category = "EBeauty"}
        };



        Console.WriteLine("Enter the Product Id: ");
        var id = int.Parse(Console.ReadLine());
        var productId = products.Where(item => item.ProductId == id);
        foreach (var item in productId)
        {
            Console.WriteLine("Product ID: {0}\nProduct Name: {1}\nQuantity:{2}\nUnit price:{3}\nCategory: {4}\n", item.ProductId, item.ProductName, item.Quantity, item.UnitPrice, item.Category);
        }




       
       Console.WriteLine("Enter the Product Category: ");
       var category = Console.ReadLine();
       var productByCategory = products.Where(item => item.Category == category);
       foreach (var item in productByCategory)
        {
            Console.WriteLine("Product ID: {0}\nProduct Name: {1}\nQuantity:{2}\nUnit price:{3}\nCategory: {4}\n", item.ProductId, item.ProductName, item.Quantity, item.UnitPrice, item.Category);
        }





        var Count = products.Count(item => item.Quantity <= 0);
        Console.WriteLine("\nTotal Products out of stock are: {0}", Count);




        var Price = products.Where(item => item.UnitPrice < 2000);
        Console.WriteLine("products which price is under 2000: \n");
        foreach (var item in Price)
        {
            Console.WriteLine("Product ID: {0}\nProduct Name: {1}\nQuantity:{2}\nUnit price:{3}\nCategory: {4}\n", item.ProductId, item.ProductName, item.Quantity, item.UnitPrice, item.Category);
        }





        var letter = products.Where(item => item.ProductName.StartsWith("A"));
        Console.WriteLine("Name of products start with A are: \n");
        foreach (var item in letter)
        {
            Console.WriteLine("Product ID: {0}\nProduct Name: {1}\nQuantity:{2}\nUnit price:{3}\nCategory: {4}\n", item.ProductId, item.ProductName, item.Quantity, item.UnitPrice, item.Category);
        }




        Console.WriteLine("Enter a category of product: ");
        string Category = Console.ReadLine();

       
       
       
       
        var productByPriceAndCategory = products.Where(item => item.UnitPrice < 2000 && item.Category == Category);
        Console.WriteLine("Products with prices less than 2000 and specific Category:\n");
        foreach (var item in productByPriceAndCategory)
        {
            Console.WriteLine("Product ID: {0}\nProduct Name: {1}\nQuantity:{2}\nUnit price:{3}\nCategory: {4}\n", item.ProductId, item.ProductName, item.Quantity, item.UnitPrice, item.Category);
        }

    }
}
