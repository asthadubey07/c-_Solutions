/*  6.   Write the exception  messages into the file  (ExceptionsLog.txt) . 
		a.  Consider the Task No. 4  in  Day-9 Assignments Exception Handling*/

using System;
using System.Collections.Generic;
using System.IO;


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


    public override string ToString()
    {
        string str = string.Format("{0},{1},{2},{3}{4}"ProductId, Name, UnitPrice, Quantity, Category);
        return str;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        WriteData();
        System.Console.WriteLine("---------------------------------");
        ReadData();
    }

    public static void WriteData()
    {
        List<Product> productsList = new List<Product>();
        Product p1 = new Product();
        for (int i = 0; i < 5; i++)
        {

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

             StreamWriter writer = new StreamWriter(@"C:FileData\ProductData.txt");
            foreach (Product products in list)
            {
                writer.WriteLine(products.ToString());
            }
            writer.Close();
            Console.WriteLine("Data is added");

        }
        public static void ReadData()
        {
            StreamReader reader = new StreamReader(@"C:\FileData\ProductData.txt");
            string Str = reader.ReadToEnd();
            reader.Close();

            System.Console.WriteLine(Str);
            System.Console.WriteLine("opration is done");
        }
    } catch(Exception e)
     {
          Console.WriteLine("Exception: " + e.Message);
      }
}


    

