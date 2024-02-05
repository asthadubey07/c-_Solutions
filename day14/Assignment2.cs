using System;
using System.Reflection;
using System.Collections.Generic;
using System.IO;

public class Program
{
	public string FileName { get; set; }
	public int Size { get; set; }
	public string Creationdate { get; set; }




	public void WriteFileData()
	{

		static void WriteData()
		{
			string[] detailsArray = { "FileData", "10", DateTime.Now.ToString("T") };
			StreamWriter writer = new StreamWriter(@"C:\FileData.txt");

			foreach (string detail in detailsArray)
			{
				writer.WriteLine(detail);
			}

			writer.Close();
			System.Console.WriteLine(" data is write into the file");

		}

		static void ReadData()
		{
			StreamReader reader = new StreamReader(@"C:\FileData.txt");
			string str = reader.ReadToEnd();
			reader.Close();

			System.Console.WriteLine(str);
			System.Console.WriteLine("Read operation is completed.");
		}
	}
	public void ShowClassDetails()
	{

	}
}

class Assignment1
{
	private static void Main(string[] args)
	{
		Console.Clear();

		Type typeObj = typeof(Program);

		System.Console.WriteLine("Type Name  : " + typeObj.Name);
		System.Console.WriteLine();


		MethodInfo[] methods = typeObj.GetMethods();
		System.Console.WriteLine("No. of Methods : " + methods.Length);
		System.Console.WriteLine("------------------------------------");
		System.Console.WriteLine("Method Names in Student Class  : ");
		System.Console.WriteLine("------------------------------------");
		foreach (MethodInfo method in methods)
		{
			System.Console.WriteLine(method);
		}


	}
}