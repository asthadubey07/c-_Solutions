/*2.   Write a program to implement the following requirements:
		 a. Create a method that Should display List<Strings>  values
		 b.Create 3 threads and  invokes the above method.*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;


class Program
{
    static void PrintList()
    {
        List<string> citiesList = new List<string>();

        citiesList.Add("Hyd");
        citiesList.Add("Mumbai");
        citiesList.Add("Pune");
        citiesList.Add("Chennai");
        citiesList.Add("Goa");


        foreach (string city in citiesList)
        {
            System.Console.Write("  " + city);
        }


        System.Console.WriteLine("Name  : " + Thread.CurrentThread.Name);
    }
    static void Main(string[] args)
    {
        ThreadStart threadStart = new ThreadStart(PrintList);
        Thread thread1 = new Thread(threadStart) { Name = "Thread-1" };
        Thread thread2 = new Thread(threadStart) { Name = "Thread-2" };
        Thread thread3 = new Thread(threadStart) { Name = "Thread-3" };
        thread1.Start();
        thread2.Start();
        thread3.Start();
    }
}



