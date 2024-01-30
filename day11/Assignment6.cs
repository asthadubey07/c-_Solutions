/*(Refer the Task-2) .  Redesign the same code using Monitor Class to implement Thread Synchronization. */

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;


class Program
{
    static object _lock = new object();

    static void PrintList()
    {

        List<string> citiesList = new List<string>();
        Monitor.Enter(_lock);
        citiesList.Add("Hyd");
        citiesList.Add("Mumbai");
        citiesList.Add("Pune");
        citiesList.Add("Chennai");
        citiesList.Add("Goa");


        foreach (string city in citiesList)
        {
            System.Console.Write("  " + city);
            Thread.Sleep(TimeSpan.FromSeconds(5));

        }



        Console.WriteLine("Name: " + Thread.CurrentThread.Name);
        Console.WriteLine();
        Monitor.Exit(_lock);
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
        Console.ReadLine();

    }
}




