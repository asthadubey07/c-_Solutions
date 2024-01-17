		
/*3   Write a Program to create a method that takes array of numbers as parameter. 
		--->  It should return no. of prime numbers count in that array.     
		--->  Create separate method to check the prime or not*/

        using System;

class Program
{
    static void Main(string[] args)
    {
        string[] names = { "abhi","rahul","Anjali","Muskan","shrij" };
        
        Console.WriteLine("The Array is:-");
        
        foreach(string name in names)
        {
            Console.WriteLine(" " + name);
        }
        
        Console.WriteLine();
        
        Console.WriteLine("UpperCase of the array is:-");    
        upperNames(names);
    
    }
    
   static void upperNames(string[] strings)
    {
        for (int i = 0; i < strings.Length; i++)
        {
            strings[i] = strings[i].ToUpper();
            Console.WriteLine(" " + strings[i]);
        }
    }
}