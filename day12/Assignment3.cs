/*3.   Write a c# program to implement the following requirements:

		a.  Define three classes :  Student, Employee, Product 
		b. Add 3 properties in each class  (you can define any properties as your wish)
		c. Add 2 methods in each class  (you can choose methods as your wish)
		e. Display all property details and methods information for each class using Reflection*/


using System;
using System.Reflection;

public class Student
{
	public string Name { get; set; }
	public int Age { get; set; }
	public String CollegeName { get; set; }

	public void ShowStudentDetails()
	{

	}

	public void ShowStudentResult()
	{

	}
}

public class Employee : Student
{
	public int EmpId { get; set; }
	public string Job { get; set; }
	public string Post { get; set; }


	public void ShowEmployeeDetails()
	{

	}

	public void showEmployeeProgress()
	{

	}


}

public class Product : Employee
{
	public string Category { get; set; }
	public String Name { get; set; }
	public int UnirPrice { get; set; }

	public void ShowProductDetails()
	{

	}

	public void UpdateProductPrize()
	{

	}


}

class Program
{
	private static void Main(string[] args)
	{
		Console.Clear();



		Type typeObj = typeof(Product);
		System.Console.WriteLine("Type Name  : " + typeObj.Name);
		System.Console.WriteLine();

		MethodInfo[] methods = typeObj.GetMethods();
		System.Console.WriteLine("Properties in Product Class :" + methods.Length);

		foreach (MethodInfo method in methods)
		{
			System.Console.WriteLine(method);
		}


		System.Console.WriteLine("Properties in Product Class:");

		PropertyInfo[] properties = typeObj.GetProperties();



		foreach (PropertyInfo property in properties)
		{
			System.Console.WriteLine(property.Name);
		}
	}


}


