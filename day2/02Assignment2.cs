
// 2. Write a C# Programs to implement the following requirements (using do...while): 

//  a. Generate series of numbers :  100    95    90  85  80   75 ..............0  

using System; 

class Assigbment
{

    static void Main()
    {

        int i = 100;

        do
        {

            Console.WriteLine(i);

            i -= 5;

        } while (i >= 0);

    }

} 

 

// b. Generate series of numbers :1   4 	9   16   25  36  ............   144 

using System; 

class Assignment
{

    static void Main()
    {

        int i = 1;

        do
        {

            Console.WriteLine(i * i);

            i++;

        } while (i <= 12);

    }

} 