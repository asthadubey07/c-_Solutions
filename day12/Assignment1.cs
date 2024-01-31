/*1.   Write a c# program to implement the following requirements:
		a. Product class properties:   ProductId, Name, UnirPrice, Quantity, Category
		b. Display all property names of Product class using Reflection concept. */


using System;
using System.Reflection;

class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public string Course { get; set; }
    public string Category { get; set; }
    public int Quantity { get; set; }
}




class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Product obj = new Product();

        Type typeObj = obj.GetType();

        System.Console.WriteLine("Type Name  : " + typeObj.Name);
        System.Console.WriteLine();
        PropertyInfo[] properties = typeObj.GetProperties();


        System.Console.WriteLine("Properties in Product Class");
        System.Console.WriteLine("----------------------------");

        foreach (PropertyInfo property in properties)
        {
            System.Console.WriteLine(property.Name);
        }
    }
}