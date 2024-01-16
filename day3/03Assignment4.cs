// 9.  Write a program to perform following operations: 
 
//      Consider the string data "    C# Programming language is very user friendly      "  

//         a.   Remove extra spaces          b.   Split the string based on the spaces 
//          c.   Display the resulted items in uppercase format.   

using System;  

using System.Collections.Generic; 

class Assignment
{

    string str1 = "    C# Programming language is very user friendly.      ";

    str1 = str1.Trim();  

Console.WriteLine(str1);  

Console.WriteLine(); 

 Console.WriteLine(); 

 string str2 = "C# Programming language is very user friendly.";

    string[] strArray = str2.Split(' '); 

        foreach (string word in strArray){ 

            Console.WriteLine(word); 

        }

Console.WriteLine("UpperCase of First Result:  {0}", str1.ToUpper());

Console.WriteLine();

Console.WriteLine();

Console.WriteLine("UpperCase of Second Result:");

foreach (string word in strArray)
{

    Console.WriteLine(word.ToUpper());

} 
} 
