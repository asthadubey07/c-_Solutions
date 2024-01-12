
//Write a  Program to find sum of all even numbers. int[] ar = { 2,5,10,15,18,65,92,35,25,48,67,90}; 

 

using System;   

class Assignment
{

    static void Main(string[] args)

    {

        int[] arr = { 2, 5, 10, 15, 18, 65, 92, 35, 25, 48, 67, 90 };

        int even = 0;

        for (int i = 0; i < arr.Length; i++)

        {

            if (arr[i] % 2 == 0)

                even += arr[i];

        }



        Console.WriteLine("all even number sum is  "

                               + "sum: " + even);

    }

}
