/*

    3. Create a c# program to Read Collection(5 items) of City Names from the user and store in ArrayList class.
       Try to catch the possible exceptions using try..catch block. Try to multiple catch blocks.

*/

using System;
using System.Collections;


internal class program
{

    public static void Main(string[] args)
    {

        ArrayList arrList = new ArrayList();

        Console.WriteLine("Enter the Size of ArrayList: ");
        int Size = int.Parse(Console.ReadLine());
        try
        {
            Console.WriteLine("Enter the Values of ArrayList: ");
            for (int i = 0; i < Size; i++)
            {

                string City = Console.ReadLine();
                arrList.Add(City);

            }

            foreach (string item in arrList)
            {
                System.Console.Write("Name of city are :{0} ", item);
            }

            System.Console.WriteLine();

        }

        catch (FormatException e)
        {
            System.Console.WriteLine("Exception ocurred in the Application. Check the exception details below:");
            System.Console.WriteLine("Message : {0}", e.Message);

        }


    }



}



/*4.  Create a c# program to Read List  of Product  details from the user and store in List<Product> class.  Try to catch the possible exceptions using try..catch block. Try to multiple catch blocks.  

	Throw the excpetion manually if the user eneter invalid data
	Eg:  			a.  Negative numbers for product id, quantity etc.. 
					b. Quantity should > 0  and  < 100
					c.  Product Name should not blank
                    
                    using user define class 




using System.Collections.Generic;

public class NegativeNumberException : ApplicationException
{
    public NegativeNumberException(string message) : base(message)
    {


    }
}

    public class QuantityException : ApplicationException
    {
        public QuantityException(string message) : base(message)
        {

        }
    }

    public class ProductNameNotBlank : ApplicationException
    {
        public ProductNameNotBlank(string message) : base(message)
        {

        }
    }
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

                    throw new NegativeNumberException("id should  not be negative");
                }


                System.Console.WriteLine("Enter Product Name:");
                p1.Name = Console.ReadLine();

                if (p1.Name == "")
                {

                    throw new ProductNameNotBlank("Product name should not be blank");
                }
                System.Console.WriteLine("Enter Product Unit Price:");
                p1.UnitPrice = int.Parse(Console.ReadLine());
                if (p1.UnitPrice < 0)
                {

                    throw new NegativeNumberException("price should  not be negative");
                }


                System.Console.WriteLine("Enter Product Quantity:");
                p1.Quantity = int.Parse(Console.ReadLine());
                if (p1.Quantity < 0)
                {

                    throw new NegativeNumberException("Quantity should  not be negative");
                }

                if (p1.Quantity > 100)
                {

                    throw new QuantityException("Quntity should  not be grater than 100");
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
            catch (OverflowException e)
            {
                System.Console.WriteLine("Exception ocurred in the Application. Check the exception details below:");
                System.Console.WriteLine("Message : {0}", e.Message);
                System.Console.WriteLine("Message: plese give value according to size");
    
            }

            foreach (Product productObj in productsList)
            {
                System.Console.WriteLine("{0},{1},{2},{3},{4}", productObj.ProductId, productObj.Name, productObj.UnitPrice, productObj.Quantity, productObj.Category);
            }
        }
    }
*/