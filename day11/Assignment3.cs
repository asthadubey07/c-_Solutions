/*3.   Write a program to implement the following requirements  using Threading concept:

		a.   Create a method that takes category as parameter.
		b.   Method should store collection of Product Objects in List.
		c.   Each product should have these properties:  ProductId, Name, Category, UnitPrice
		d.   Method should find the products that are belongs to given category
		e.   Invoke that method using Thread from Main method.*/


using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;


class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public int UnitPrice { get; set; }

    public override string ToString()
    {
        string str = string.Format("{0},{1},{2},{3}"ProductId, Name, Category, UnitPrice);
        return str;
    }

}
class Program
{
    static void ProductByCategory(Object category)
    {
        List<Product> Products = new List<Product>();
        for (int i = 0; i < 5; i++)
        {
            Product productObj = new Product();

            Console.WriteLine("Enter Id:");
            productObj.ProductId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name:");
            productObj.Name = Console.ReadLine();

            Console.WriteLine("Enter Category:");
            productObj.Category = Console.ReadLine();

            Console.WriteLine("Enter UnitPrice:");
            productObj.UnitPrice = int.Parse(Console.ReadLine());

            list.Add(productObj);
        }

        foreach (Product list in Products)
        {
            if (list.Category == category)
            {
                System.Console.WriteLine{
                    System.Console.WriteLine("{0},{1},{2},{3},{4}", productObj.ProductId, productObj.Name, productObj.Category, productObj.UnitPrice);
                }
            else
                {
                    System.Console.WriteLine("product is not avilable");
                }
            }
        }
         Console.WriteLine("Thread Name: {0} ", Thread.CurrentThread.Name,);
        static void Main(string[] args)
        {
            ParameterizedThreadStart threadStart = new ParameterizedThreadStart(ProductByCategory);
            Thread thread = new Thread(threadStart);{ Name = "Thread 1" };

            thread.Start();
        }
    }
}