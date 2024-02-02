/*5.    Write a C# program to implement  the following requirement:

		a.  Read some 5 customers names from the user write in xml file 
		b.  Read the customer names from xml file and display on the screen. 
		c.  Create two separate metods for the above requirements and call them from main. */

using System;
using System.Xml;

public class Program
{
	static void Write()
	{
		string fileName = @"C:\FileData\CusData.xml";
		XmlTextWriter writer = new XmlTextWriter(fileName, null);


		writer.Formatting = Formatting.Indented;
		writer.Indentation = 4;

		writer.WriteStartDocument();

		writer.WriteStartElement("Customers");

		for (int i = 1; i <= 5; i++)
		{

			Console.WriteLine("Enter Coustomer Name:");
			string CustomerName = Console.ReadLine();

			writer.WriteStartElement("Customer");
			writer.WriteElementString("CustomerName:", CustomerName);
			writer.WriteEndElement();
		}
		writer.WriteEndElement();
		writer.Close();

	}

	static void Read()
	{
		string fileName = @"C:\FileData\CUsData.xml";
		XmlTextReader reader = new XmlTextReader(fileName);

		while (reader.Read())
		{
			if (reader.IsStartElement())
			{
				switch (reader.Name.ToString())
				{
					case "CustomerName":
						Console.WriteLine(" Customer Name : " + reader.ReadString());
						break;
				}
			}
		}
		reader.Close();
	}
	public static void Main(string[] args)
	{
		Write();

		Console.WriteLine("Writeing is completed.");
		System.Console.WriteLine();


		Console.WriteLine("Coustomer names are:");
		Read();
	}
}