/*4.  Create a c# program to Read List  of Product  details from the user and store in List<Product> class.  Try to catch the possible exceptions using try..catch block. Try to multiple catch blocks.  

	Throw the excpetion manually if the user eneter invalid data
	Eg:  			a.  Negative numbers for product id, quantity etc.. 
					b. Quantity should > 0  and  < 100
					c.  Product Name should not blank */




using System.Collections.Generic;

class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public int UnitPrice { get; set; }
    public int Quantity { get; set; }
    public string Category { get; set; }

}
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Product> productsList = new List<Product>();
        Product p1 = new Product();

        try
        {


            System.Console.WriteLine("Enter Product Id:");
            p1.ProductId = int.Parse(Console.ReadLine());

            if (p1.ProductId < 0)
            {

                throw new Exception("id should  not be negative");
            }


            System.Console.WriteLine("Enter Product Name:");
            p1.Name = Console.ReadLine();


            System.Console.WriteLine("Enter Product Unit Price:");
            p1.UnitPrice = int.Parse(Console.ReadLine());
            if (p1.UnitPrice < 0)
            {

                throw new Exception("price should  not be negative");
            }


            System.Console.WriteLine("Enter Product Quantity:");
            p1.Quantity = int.Parse(Console.ReadLine());
            if (p1.Quantity < 0)
            {

                throw new Exception("Quantity should  not be negative");
            }

            if (p1.Quantity > 100)
            {

                throw new Exception("Quntity should  not be grater than 100");
            }
            System.Console.WriteLine("Enter Product Category:");
            p1.Category = Console.ReadLine();


            productsList.Add(p1);


        }
        catch (FormatException e)
        {
            System.Console.WriteLine("Exception ocurred in the Application. Check the exception details below:");
            System.Console.WriteLine("Message : {0}", e.Message);

        }

        foreach (Product productObj in productsList)
        {
            System.Console.WriteLine("{0},{1},{2},{3},{4}", productObj.ProductId, productObj.Name, productObj.UnitPrice, productObj.Quantity, productObj.Category);
        }
    }
}