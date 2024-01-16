//7. Write a C# program to merge the given two arrays into third array.

// a.Consider that two arrays in sorted order



using System;

class Assignment
{
    public static void mergeArrays(int[] arr1, int[] arr2, int n1, int n2, int[] arr3)
    {
        int i = 0;

        int j = 0;

        int k = 0;

        while (i < n1)
        {
            arr3[k++] = arr1[i++];
        }

        while (j < n2)
        {
            arr3[k++] = arr2[j++];
        }

        Array.Sort(arr3);
    }
}
