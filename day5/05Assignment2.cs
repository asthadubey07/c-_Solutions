/*2. Create a c# Program class to process product details:

	a.  Details :	 product id, product name, unit price, quantity
	b.  create required fields, properties
	c.   perform read and write operations using properties	
				-->  read data from user and assign to properties
				-->  display the details using properties


	Eg:    Product obj = new Product();	
			 obj.ProductId  =  int.Parse(Console.ReadLine());			
			Console.WriteLine("Product Id  : " + obj.ProductId);*/


using System;
public class ProductDetails
{ 
    private int _productid;
    public int ProductId
    {
        get { return _productid; }
        set { _productid = value; }
    }
     
    private string _productname;
    public string ProductName
    {
        get { return _productname; }
        set { _productname = value; }
    }
  
    private int _unitprice;
    public int UnitPrice
    {
        get { return _unitprice; }
        set { _unitprice = value; }
    }
  
    private int _quantity;
    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }  
}

public class Program
{
    static void Main(string[] args) 
    {
        ProductDetails obj = new ProductDetails();
        Console.WriteLine("Enter ProductId : ");   
        obj.ProductId = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter ProductName : ");   
        obj.ProductName = Console.ReadLine();
        Console.WriteLine("Enter unitPrice : ");   
        obj.UnitPrice = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Quantity : ");   
        obj.Quantity = int.Parse(Console.ReadLine());
	    Console.WriteLine("Product Id  : " + obj.ProductId);
        Console.WriteLine("product name : " + obj.ProductName);
        Console.WriteLine("unit price  : " + obj.UnitPrice);
        Console.WriteLine(" Quantity : " + obj.Quantity);
       
    }
}



            
