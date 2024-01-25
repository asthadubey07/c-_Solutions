/*3.  Create C# Program to process product details using generic List.

		a. Product class properties:   ProductId, Name, UnitPrice, Quantity, Category
		b. Add 5 product objects to List class  
		c.  Iterate the List object and display the product details 

		Hint :  Use for loop to implement Step-a */
    



    using System.Collections.Generic;

class Product
{
  public int ProductId { get; set;}
  public string Name { get; set;}  
  public int  UnitPrice { get; set; }
  public int Quantity { get; set;}
  public string Category { get; set;}
  
}
class Program
{
    static void Main(string[] args)
    {
       
       List<Product> productsList = new List<Product>();

    
      Product p1 = new Product();
      p1.ProductId = 1021;
      p1.Name  = "Manisha";
      p1.UnitPrice = 35124;
      p1.Quantity =  6579;
      p1.Category= "jeans";

        Product p2 = new Product();
      p2.ProductId = 1022;
      p2.Name  = "Kirti";
      p2.UnitPrice = 7235469;
      p2.Quantity =  564578;
      p2.Category= "top";


        Product p3 = new Product();
      p3.ProductId = 1023;
      p3.Name  = "palak";
      p3.UnitPrice =45237;
      p3.Quantity =  56;
      p3.Category= "gifts";


        Product p4 = new Product();
      p4.ProductId = 1024;
      p4.Name  = "malan";
      p4.UnitPrice = 543648;
      p4.Quantity =  2;
      p4.Category= "cloth";


      productsList.Add(p1);
      productsList.Add(p2);
      productsList.Add(p3);
      productsList.Add(p4);
       

      foreach (Product productObj in productsList) 
      {
        System.Console.WriteLine("{0},{1},{2},{3},{4}", productObj.ProductId, productObj.Name,productObj.UnitPrice, productObj.Quantity,productObj.Category );
      }
    }
}


//taking valuse from customer 


    using System.Collections.Generic;

class Product
{
  public int ProductId { get; set;}
  public string Name { get; set;}  
  public int  UnitPrice { get; set; }
  public int Quantity { get; set;}
  public string Category { get; set;}
  
}
class Program
{
    static void Main(string[] args)
    {
       
       List<Product> productsList = new List<Product>();


 for(int i = 0; i < 5; i++ )
        {
            Product p1 = new Product();

            Console.WriteLine("Enter Product Id:");
            p1.ProductId  = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            p1.Name = Console.ReadLine();
            Console.WriteLine("Enter Product Unit Price:");
            p1.UnitPrice = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Quantity:");
            p1.Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Category:");
            p1.Category = Console.ReadLine();


            productsList.Add(p1);

        }

          foreach (Product productObj in productsList) 
      {
        System.Console.WriteLine("{0},{1},{2},{3},{4}", productObj.ProductId, productObj.Name,productObj.UnitPrice, productObj.Quantity,productObj.Category );
      }
    }
}
        

