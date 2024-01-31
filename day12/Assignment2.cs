/*1.   Write a c# program to implement the following requirements:
		a. Product class properties:   ProductId, Name, UnirPrice, Quantity, Category
		b. Display all property names of Product class using Reflection concept. 
		
		
		
		2.  Update the previous program to display property name and its data type also using Reflection. 
*/


using System;
using System.Reflection;

class Product
{
	private string _id;

	public int ProductId { get; set; }
	public string Name { get; set; }
	public string Category { get; set; }
	public int Quantity { get; set; }
	public int UnirPrice { get; set; }


	public String Id
	{
		get { return _id; }
		set	{_id = value;}
	}

}



class Program
{
	private static void Main(string[] args)
	{
		Console.Clear();
		Product obj = new Product();

		Type typeObj = obj.GetType();
		PropertyInfo[] properties = typeObj.GetProperties();
		Type type = typeof(Product);

		System.Console.WriteLine("Properties in Product Class");
		System.Console.WriteLine("----------------------------");

		foreach (PropertyInfo property in properties)
		{
			System.Console.WriteLine("{0} : {1}", property.Name, property.PropertyType.Name);
		}
	}
}


