/*3.  Create another program to implement the following requirement:
		a.   Consider the previous program(Task-2)
		b.   Insert some Sleep time using Sleep() method between the add items and remove items in the queue.
		c.   Run the code and observe the changes
		
		Hint :  Thread.Sleep() method to implement */



using System;
using System.Collections.Generic;

class Program2
{
	static Queue<string> Cities = new Queue<string>();
	public static void Main(string[] args)
	{
		System.Console.WriteLine("list of cities:");
		Cities.Enqueue("bhopal");
		Thread.Sleep(500);
		Cities.Enqueue("Rewa");
		Thread.Sleep(500);
		Cities.Enqueue("Katni");
		Thread.Sleep(500);
		Cities.Enqueue("jabalpur");


		foreach (var city in Cities)
		{
			System.Console.WriteLine(city);
		}



		Cities.Dequeue();
		Thread.Sleep(500);
		Cities.Dequeue();
		Console.WriteLine("List after Dequeue");

		foreach (var details in Cities)
		{
			System.Console.WriteLine(details);
		}
		

	}

}
