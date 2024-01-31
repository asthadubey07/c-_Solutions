/*3.   Write a c# program to implement the following requirements:

		a.  Define three classes :  Student, Employee, Product 
		b. Add 3 properties in each class  (you can define any properties as your wish)
		c. Add 2 methods in each class  (you can choose methods as your wish)
		e. Display all property details and methods information for each class using Reflection



4.  Write a c# program to implement the following requirements:
		a.  Take the program in Task-3
		b.  Read the class name from user and display the property and method details using Reflection*/

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

public class Employee
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

public class Product
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
		string str;
		System.Console.WriteLine("enter the class name:");
		 str = Console.ReadLine();   

if(str == " "){
	System.Console.WriteLine("plese enter write class name");
}
		else if (str == "Student")
		{

			Type typeObj1 = typeof(Student);
			System.Console.WriteLine("Type Name  : " + typeObj1.Name);
			System.Console.WriteLine();



			MethodInfo[] methods1 = typeObj1.GetMethods();
			System.Console.WriteLine("Properties in Product Class :" + methods1.Length);

			foreach (MethodInfo method in methods1)
			{
				System.Console.WriteLine(method);
			}


			System.Console.WriteLine("Properties in Product Class:");

			PropertyInfo[] properties1 = typeObj1.GetProperties();



			foreach (PropertyInfo property in properties1)
			{
				System.Console.WriteLine(property.Name);
			}

		}

		else if (str == "Employee")
		{

			Type typeObj2 = typeof(Employee);
			System.Console.WriteLine("Type Name  : " + typeObj2.Name);
			System.Console.WriteLine();



			MethodInfo[] methods2 = typeObj2.GetMethods();
			System.Console.WriteLine("Properties in Product Class :" + methods2.Length);

			foreach (MethodInfo method in methods2)
			{
				System.Console.WriteLine(method);
			}


			System.Console.WriteLine("Properties in Product Class:");

			PropertyInfo[] properties2 = typeObj2.GetProperties();



			foreach (PropertyInfo property in properties2)
			{
				System.Console.WriteLine(property.Name);
			}
		}


		else if (str == "Product")
		{
			Type typeObj3 = typeof(Product);
			System.Console.WriteLine("Type Name  : " + typeObj3.Name);
			System.Console.WriteLine();



			MethodInfo[] methods3 = typeObj3.GetMethods();
			System.Console.WriteLine("Properties in Product Class :" + methods3.Length);

			foreach (MethodInfo method in methods3)
			{
				System.Console.WriteLine(method);
			}


			System.Console.WriteLine("Properties in Product Class:");

			PropertyInfo[] properties3 = typeObj3.GetProperties();



			foreach (PropertyInfo property in properties3)
			{
				System.Console.WriteLine(property.Name);
			}
		}

		else{
			Console.WriteLine("please enter one of them : product or student or Employee");
		}



	}
}




