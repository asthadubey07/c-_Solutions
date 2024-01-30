/*4.  Update the above assignment, by add more number of thread with different priority and invoke the same method and observe the output.  */

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
        static void Main(string[] args)
        {
            ParameterizedThreadStart threadStart = new ParameterizedThreadStart(ProductByCategory);
            Thread thread1 = new Thread(threadStart) { Name = "Thread 1" };
            Thread thread2 = new Thread(threadStart) { Name = "Thread 2" };
            Thread thread3 = new Thread(threadStart) { Name = "Thread 3" };
            thread1.Priority = ThreadPriority.Highest;
            thread2.Priority = ThreadPriority.Normal;
            thread3.Priority = ThreadPriority.Lowest;
            Console.WriteLine("Thread 1 Priority: {0}", thread1.Priority);
            Console.WriteLine("Thread 2 Priority: {0}", thread2.Priority);
            Console.WriteLine("Thread 3 Priority: {0}", thread3.Priority);


            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
    }
}


