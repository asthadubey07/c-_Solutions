using System;
using System.Collections.Generic;
using System.IO;

class Program1
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();
        System.Console.WriteLine("The list of cities are:");

        list.Add("Katni");
        list.Add("Bhopal");
        list.Add("Rewa");
        list.Add("Dehli");
        list.Add("Kanpur");
        StreamWriter writer = new StreamWriter(@"C:\FileData\MyData.txt");
        foreach (string citys in list)
        {
            writer.WriteLine(citys);
        }
        writer.Close();

    }
}
