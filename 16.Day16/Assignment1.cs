/*1.   Write a C# Program to implement the following requirements using LINQ:
	
		Take List<string>  customer names  and initialize with 10 names. 
 
		a.   Display All Names
		b.   Names starts with "S"
		c.   Names contains only four characters
		d.  Names contains "a" character any where in their names*/



using System;
using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        List<string> customerNames = new List<string>() { "astha", "manisha", "jiya", "aashika", "palak", "aaliya", "aakancha", "cyrus", "abhishek", "elvish" };

        var query1 = from Customer in customerNames
                     select Customer;

        System.Console.WriteLine("names of customers are:");
        foreach (var item in query1)
        {
            Console.Write(" {0} ", item);
        }


        var query2 = from Customer in customerNames
                     where customerNames.StartsWith("S")
                     select Customer;

        foreach (var i in query2)
        {
            System.Console.WriteLine(i);
        }



        var query3 = from Customer in customerNames
                      where customerNames.Length == 4
                     select Customer;

        foreach (var i1 in query3)
        {
            System.Console.WriteLine(i1);
        }




        var query4 = from Customer in customerNames
                       where customerNames.Contains("a") || customerNames.Contains("A")
                     select Customer;

        foreach (var i2 in query4)
        {
            System.Console.WriteLine(i2);
        }


    }
}

