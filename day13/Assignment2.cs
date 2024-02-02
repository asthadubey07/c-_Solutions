/*		
2.  Write a C# program to implement  the following requirement:
	a.  Maintain the customers names in queue. 
	b   Declare Queue outside the Main()  as static variable
	c.  Perform some insert operations on Queue
	d.  Perform some delete operations on Queue
		
	Hint : No need to read from user. Add/Remove static data. */



using System;
using System.Collections.Generic;

class Program2
{
    static Queue<string> Cities = new Queue<string>();
    public static void Main(string[] args)
    {
        System.Console.WriteLine("list of cities:");
       Cities.Enqueue("bhopal");
       Cities.Enqueue("Rewa");
        Cities.Enqueue("Katni");
        Cities.Enqueue("jabalpur");
    

        foreach(var city in Cities)
        {
            System.Console.WriteLine(city);
        }
       
       

       Cities.Dequeue();
	   
       Cities.Dequeue();
	 Console.WriteLine("List after Dequeue");

        foreach(var details in Cities)
        {
            System.Console.WriteLine(details);
        }
        ;

    }
    
}