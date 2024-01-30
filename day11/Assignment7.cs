/** 7.   Implement the following requirement using Semaphore :
	a. Read the thread count from the user based on that 
	b. Create number of Threads based on the count. 
		c.  Invoke the same method (From Task-2)  with each Thread
		d. Use Semaphore to implement Synchronization. */


using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;

class Program
{
    static Thread[] threads = new Thread[5];
    static Semaphore sem = new Semaphore(4, 4);
    static void PrintList()
    {
        List<string> list = new List<string>();
        listist.Add("bhopal");
        list.Add("katni");
        list.Add("jabalpur");
        list.Add("nagpur");

        Console.WriteLine("{0} is waiting in line.", Thread.CurrentThread.Name);
        sem.WaitOne();
        Console.WriteLine("{0} enters the list", Thread.CurrentThread.Name);
        Thread.Sleep(200);
        Console.WriteLine("{0} is leaving the list", Thread.CurrentThread.Name);
        sem.Release();

        foreach (string city in list)
        {
            Console.WriteLine(city);
            Thread.Sleep(500);
        }

    }
    static void Main(string[] args)
    {
        ThreadStart threadStart = new ThreadStart(PrintList);

        for (int i = 0; i < 5; i++)
        {
            threads[i] = new Thread(threadStart) { Name = "Thread_" + i };
            threads[i].Start();
        }

        Console.Read();
    }
}





