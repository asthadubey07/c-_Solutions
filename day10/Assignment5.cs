using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        StreamWriter First = new StreamWriter(@"C:\\MyData.txt");
        StreamWriter Second = new StreamWriter(@"C:\\EmpData.txt");

        StreamWriter Third = new StreamWriter(@"C:\\FileData.txt");
        String Chek;

        if (First == NULL || Second == NULL || Third == NULL)
        {
            Console.WriteLine("Data is not present in file");
            writer.Close();
        }
        File.Copy("MyData.txt", "FileData.txt", true);
        File.Copy("EmpData.txt", "FileData.txt", true);
        
        public static void ReadData()
    {
        StreamReader reader = new StreamReader(@"C:\\FileData.txt");
        string Str = reader.ReadToEnd();
        reader.Close();

        System.Console.WriteLine(Str);
        System.Console.WriteLine("file is merged");
    }
}


}
