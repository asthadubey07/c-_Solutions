/*
5.    Write a c# program to implement the following requirements:
			a.  Create classes  as follows:
						Employee, Student classes inherits from Person class
						FDAccount, SBAccount classes inherits from BankAccount class						
			b.  Load all the types that are available in the current project. 
			b.  Read a class name from the user and display the child classes of that. */



using System;
using System.Reflection;

public class Person
{
	public string Name { get; set; }
	public int Age { get; set; }
}

public class Student : Person
{
	public int StudentId { get; set; }
	public string CollegeName { get; set; }
}

public class Employee : Person
{
	public int EmployeeId { get; set; }
	public string Post { get; set; }
}

public class BankAccount
{

	public string Name { get; set; }
	public int Age { get; set; }
}

public class FDAccount : BankAccount
{

	public string Name { get; set; }
	public int Age { get; set; }
}

public class SBAccount : BankAccount
{

	public string Name { get; set; }
	public int Age { get; set; }
}






class Program
{
	private static void Main(string[] args)
	{
		Console.Clear();
		Assembly all = Assembly.GetExecutingAssembly();
		Type[] typeObj = all.GetTypes();

		Console.WriteLine("The existing projects are:");
		foreach (Type type in typeObj)
		{
			Console.WriteLine(type.Name);
		}

		Console.WriteLine("Enter a class:");
		string str = Console.ReadLine();

		if (str == "Person")
		{
			Type typeObj1 = typeof(Person);
			if (typeObj != null)
			{
				foreach (var object1 in typeObj)
				{
					if (object1.IsSubclassOf(typeObj1))
					{
						Console.WriteLine(object1.Name);
					}
				}
			}
		}

		else if (str == "BankAccount")
		{
			Type typeObj2 = typeof(BankAccount);
			if (typeObj != null)
			{
				foreach (var object2 in typeObj)
				{
					if (object2.IsSubclassOf(typeObj2))
					{
						Console.WriteLine(object2.Name);
					}
				}
			}
		}

		else

		{

			Console.WriteLine("Enter a valid class");

		}



	}


}