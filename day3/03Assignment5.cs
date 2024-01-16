// 10.Write a program to  reverse the words in the given string:    
//Input: C# Programming language is very user friendly
//  Output :   friendly user very is language Programming  C#



using System;

using System.Collections.Generic;

class Assignment
{
    public static void Main()
    {
        string line = " C# Programming language is very user friendly";

        Console.WriteLine("Original String:" + line);

        string result = "";

        List<string> wordsList = new List<string>();

        string[] words = line.Split(new[] { " " }, StringSplitOptions.None);

        for (int i = words.Length - 1; i >= 0; i--)
        {
            result += words[i] + " ";
        }

        wordsList.Add(result);

        foreach (String s in wordsList)
        {
            Console.WriteLine("Reverse String: " + s);
        }
    }
}
