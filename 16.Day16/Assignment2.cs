/*
2.   Write a C# Program to implement the following requirements using LINQ: 
			
			a.  Consider the products collections:
							Props :   ProductId, Name, Quantity, UnitPrice, Category  

							Take 
							
			b.    		i.  Display all the product names
						ii. Display the products based on the category
						iii. Display out of stock products (means quantity is zero)
						iv.  Display the products which price is under 2000 					 
						v.  Display the products which price is under 2000  and in specific category 
						vi. Sorting the products based on UnitPrice 
						*/


						
public class Product{
    public int ProductId{get; set;}
    public string  Name{get; set;}
	 public string Category{get;set;}
	     public double UnitPrice{get; set;}
    public int  Quantity{get; set;}

   
}


internal class Program
{
    
    private static void Main(string[] args)
    {

        Console.Clear();
       
   List<Product> ProductList = new List<Product>(){
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


    var query1 =  from Product in ProductList
                  select Product;

    foreach (var Product in query1)
    {
        System.Console.Write(" " + Product.Name);
    }

    System.Console.WriteLine("\n----------------------------------------------------------");
    var query2 =  from Product in ProductList
                  where Product.Category == "jeans"
                  select Product;

     foreach (var Product in query2)
    {
        System.Console.WriteLine("{0}, {1}", Product.Name, Product.Category);
    }

  System.Console.WriteLine("----------------------------------------------------------");
    var query3 =  from Product in ProductList
                  where Product.Quantity == 0
                  select Product;

     foreach (var Product in query3)
    {
        System.Console.WriteLine("out of stock");
    }

    System.Console.WriteLine("----------------------------------------------------------");
    var query4 =  from Product in ProductList
                  where Product.UnitPrice <=2000
                  select Product;

     foreach (var Product in query4)
    {
        System.Console.WriteLine("{0}, {1}, {2}", Product.Name, Product.Category, Product.UnitPrice);
    }

 System.Console.WriteLine("----------------------------------------------------------");
	
    var query5 =  from Product in ProductList
                  orderby Product.UnitPrice descending
                  select Product;

    foreach (var Product in query5)
    {
        System.Console.WriteLine(" {0},{1} ",Product.Name, Product.UnitPrice);
    }


    }
    
            
}