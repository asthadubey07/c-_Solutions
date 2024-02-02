/*  4.   Update the above program by adding the following requirement using timer concept:
		a.  For every two seconds, we need to write the message in the file (Eg: CustomerQueue.txt) 
		b.  Message indicates no. of customers available in the queue. 
		c.   Implement this using Timer concept.  */



using System;
using System.Collections.Generic;

class Program2
{
	static Queue<string> Cities = new Queue<string>();
	  public static void OnTimerEvent(object sender, System.Timers.ElapsedEventArgs args)
    {
        StreamWriter write = new StreamWriter(@"C:\Filedata\Queue.txt",true);
        write.WriteLine("Number of Customers in queue" + Cities.Count);
        Console.WriteLine("Number of Customers in queue" + Cities.Count);
        write.Close();
    }
	public static void Main(string[] args)
	{
		 System.Timers.Timer timer1 = new System.Timers.Timer();
            timer1.Interval  = 20000;         
            timer1.Elapsed  += new System.Timers.ElapsedEventHandler(OnTimerEvent);
            timer1.Enabled = true;  
			Console.WriteLine("Press any key to stop the timer");
            Console.ReadLine();
			
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
