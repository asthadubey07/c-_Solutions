//Write a C# program to create an array of numbers and find out maximum and minimum numbers in that array.

using System;

class Assignment
{
    static void Main(string[] args)
    {
        int[] arr = { 2, 5, 10, 15, 18, 65, 92, 35, 25, 48, 67, 90 };

        int max = arr[0];

        int min = arr[0];

        for (int i = 0; i <= arr.Length - 1; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }

            if (arr[i] < min)
            {
                min = arr[i];
            }
        }

        Console.WriteLine(max);

        Console.WriteLine(min);
    }
}
