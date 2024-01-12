
//4.Write a c# program to create an array with dynamic size, read numbers from the user and find out sum of the those numbers. 

 

using System;
class Assignment
{

    static void Main(string[] args)

    {

        int[] a = new int[100];

        int i, n, sum = 0;

        Console.Write("Input the number of elements :");

        n = int.Parse(Console.ReadLine());



        Console.WriteLine("Input {0} elements in the array :", n);

        for (i = 0; i < n; i++)

        {

            Console.Write("{0}: ", i);



            a[i] = int.Parse(Console.ReadLine());

        }



        for (i = 0; i < n; i++)

        {

            sum += a[i];

        }



        Console.Write("Sum of all elements stored in the array is : {0}", sum);

    }

}
