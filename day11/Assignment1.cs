/*1.   Write a program to invoke the method using Thread. 
		a. Create a method that prints numbers between 1 to 100
		b. Those umbers should be multiples of 3 and 5  (Eg:  15 30 .....)*/


using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;


class Program
{
    static void PrintNumber()
    {
        System.Console.WriteLine("multiples of 3 and 5 are:");
        for(int i=3; i<100;i++){
            if(i%3==0&&i%5==0){
            Console.WriteLine("" + i);
            }
        }

    }
    static void Main(string[] args)
    {
        ThreadStart threadStart = new ThreadStart(PrintNumber);
        Thread thread = new Thread(threadStart);
        thread.Start();      
    }
}