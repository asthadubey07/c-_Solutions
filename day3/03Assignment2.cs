//7. Write a C# program to merge the given two arrays into third array.
// b.After merging third array also should be in sorted order.

// Eg:

// Array1      -	1	6	10	25

// Array2      -	5	9	20	36	45	100

// Array3    -	    1, 5, 6, 9, 10, 20, 25...........


using System;

class Assignment
{
    public static void Main(string[] args)
    {
        int[] arr1 = new int[] { 1, 6, 10, 25 };

        int n1 = arr1.Length;

        int[] arr2 = new int[] { 5, 9, 20, 36, 45, 100 };

        int n2 = arr2.Length;

        int[] arr3 = new int[n1 + n2];

        mergeArrays(arr1, arr2, n1, n2, arr3);

        Console.WriteLine("Array after merging");

        for (int i = 0; i < n1 + n2; i++)

            Console.Write(arr3[i] + " ");
    }
}
