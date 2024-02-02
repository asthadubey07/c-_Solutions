/*6.   Write a C# program to implement  the following requirement:

		a.  Take List<Product> and initialize with some static data -- 5 objects. 
		b.  Getting data from List  and Write into xml files (ProductsData.xml)*/
 
using System;
using System.Xml;
using System.Collections.Generic;

public class Product
{
	public int ProductId { get; set; }
	public string Name { get; set; }
	public double UnitPrice { get; set; }
	public string Category { get; set; }
	public int Quantity { get; set; }
}

public class Program
{
	static void Write()
	{
		List<Product> list = new List<Product>()
		 {
		new Product{ ProductId = 100, Name = "Samsung", UnitPrice = 10000000, Category = "elctronic", Quantity = 7 },
		new Product{ ProductId = 101, Name = "iphone", UnitPrice = 1000000000000, Category = "elctronic", Quantity = 32},
		new Product{ ProductId = 102, Name = "oppo", UnitPrice = 9999999, Category = "elctronic", Quantity = 50 },
		new Product{ ProductId = 103, Name = "vivo", UnitPrice = 898888888, Category = "elctronic", Quantity = 34 },
		new Product{ ProductId = 104, Name = "narzo", UnitPrice = 565856, Category = "elctronic", Quantity = 1 },
	
		 };

		string fileName = @"C:\FileData\ProductsData.xml";
		XmlTextWriter writer = new XmlTextWriter(fileName, null);


		writer.Formatting = Formatting.Indented;
		writer.Indentation = 4;

		writer.WriteStartDocument();
		writer.WriteStartElement("Products");

		foreach (var products in list)
		{
			writer.WriteStartElement("Product");
			writer.WriteElementString("ProductId", products.ProductId.ToString());
			writer.WriteElementString("Name", products.Name);
			writer.WriteElementString("UnitPrice", products.UnitPrice.ToString());
			writer.WriteElementString("Category", products.Category);
			writer.WriteElementString("Quantity", products.Quantity.ToString());
			writer.WriteEndElement();
		}
		writer.WriteEndElement();
		writer.Close();

	}
	static void Main(string[] args)
	{
		Write();

		Console.WriteLine("Writeing is completed.");
		Console.WriteLine();
	}
}