/*5.   (Refer the Task-2) .  Redesign the same code using Mutex to implement Thread Synchronization. */

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;


class Program
{
    public static Mutex mt = new Mutex();
    static void PrintList()
    {
        string[] stringarr = { "bhopal ", "is ", "a", "good", "city." };

        mt.WaitOne();



        foreach (string str in stringarr)
        {
            System.Console.Write(str);
            
        System.Console.WriteLine("Name  : " + Thread.CurrentThread.Name);
            Thread.Sleep(500);
        }
        Console.WriteLine();

        mt.ReleaseMutex();

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





