using System;
using System.Collections.Generic;
using System.IO;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public int Salary { get; set; }

    public override string ToString()
    {
        string str = string.Format("{0},{1},{2},{3}"Id, Name, Position, Salary);
        return str;
    }

}

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        WriteData();
        System.Console.WriteLine("---------------------------------");
        ReadData();
    }

    public static void WriteData()
    {
        List<Employee> list = new List<Employee>();
        for (int i = 0; i < 5; i++)
        {
            Employee empObj = new Employee();

            Console.WriteLine("Enter Id:");
            emp.Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name:");
            emp.Name = Console.ReadLine();

            Console.WriteLine("Enter position:");
            emp.Position = Console.ReadLine();

            Console.WriteLine("Enter Salary:");
            emp.Salary = int.Parse(Console.ReadLine());

            list.Add(empObj);
        }

        StreamWriter writer = new StreamWriter(@"C:FileData\EmpData.csv");
        foreach (Employee emplis in list)
        {
            writer.WriteLine(emplis.ToString());
        }
        writer.Close();
        Console.WriteLine("Employee data is present in EmpData.csv file.");
    }

    public static void ReadData()
    {
        StreamReader reader = new StreamReader(@"C:\FileData\EmpData.csv");
        string Str = reader.ReadToEnd();
        reader.Close();

        System.Console.WriteLine(Str);
        System.Console.WriteLine("opration is done");
    }
}