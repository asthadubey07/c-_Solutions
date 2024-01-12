
// 3. Write a C# Programs to implement the following requirements (using for): 

//  a. Generate series of numbers :  1  1  2  3  5  8  13  21  34...........300	 



using System;

class Assignment
{

    static void Main()
    {

        int n = 300; int first = 1; int second = 1; int third;

        Console.Write("{0}  {1}", first, second);

        for (int i = 2; (third = first + second) <= n; i++)

        {
            Console.Write(" “+third);

first = second;
            second = third;

        }

    }
}







    // b.Generate series of numbers :1   3   7  15    31   63    127   255 

 

using System;   

class Assignment
{

    static void Main(string[] args)

    {

        int n = 7, i, pr = 0;

        for (i = 1; i <= n; i++)

        {

            pr = (pr * 2) + 1;

            Console.WriteLine(pr);



        }

    }



}
