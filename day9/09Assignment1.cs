
using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.Write("Enter the size of array: ");
        int size = int.Parse(Console.ReadLine());

        int[] arr = new int[size];
        try
        {
            for (int i = 0; i < size; i++)
            {
                System.Console.WriteLine("Enter an element of array: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            foreach (int item in arr)
            {
                System.Console.Write("elements of array:{0} ", item);
            }

            System.Console.WriteLine();

        }
        catch (FormatException e)
        {
            System.Console.WriteLine("Exception ocurred in the Application. Check the exception details below:");
            System.Console.WriteLine("Message : {0}", e.Message);
            System.Console.WriteLine("Hint: Please enter numbers only.");
        }

    }
}