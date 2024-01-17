//a.  Create a method to find Cube of the given number

using System;
class Assignment{
  static void Main() {
    int number;
    double c;
    Console.WriteLine("write a number of your choise");
       number = int.Parse(Console.ReadLine()); 

       c=cube(number);
       Console.WriteLine("cube of given number is:"+c);
  }
           static double cube(int number)
     {
    return (number * number * number);
    }
}




 //b Create a method that returns total amount based on the given price and qty

using System;
class Assignment{
  static void Main() {
    int Price, qut;
    double total;

    Console.WriteLine("please enter the price");
     Price= int.Parse(Console.ReadLine());

     Console.WriteLine("please enter the quntity");
     qut= int.Parse(Console.ReadLine());

        total =calculate(Price, qut);
        Console.WriteLine("total price is "+total);

  }

  static double calculate(double x, double y)
     {
             return x * y;
     }

   
 }



//c.   Create a method that returns array of city names
using System;
class Assignment{
 
   private static void Main(string[] args)
    {
       string[]  Citys = GetCity();

       foreach (string product in Citys)
       {
        System.Console.Write(" {0} ", product);
       }


    }
   static string[]  GetCity()
    {	
        string[]   city =  { "Katni",  "Bhopal", "Rewa", "Vidisha",};
        return city;
    }
    
 }


//	d.  Create a method that takes array of numbers as parameter.  It should return average of the numbers in the array


using System;
class Assignment {

      static void Main(string[] args)
      {
        int totalprime;
          Console.Write("Enter the size of array: ");
          int size=int.Parse(Console.ReadLine());

          int []arr=new int[size];

          for(int i=0;i<size;i++)
          {

            Console.WriteLine("plese enter the number ");
                        arr[i]=int.Parse(Console.ReadLine());
                        
 
      }
      int n = arr.Length;
       totalprime= primeCount(arr, n);
        Console.WriteLine("total prime number are : "+totalprime);
          }

     static int primeCount(int []arr, int n)
    {
        int max_val = arr.Max();
        Boolean[] prime = new Boolean[max_val + 1];
        for (int i = 0; i < max_val + 1; i++)
        {
            prime[i] = true;
        }
        prime[0] = false;
        prime[1] = false;
        for (int p = 2; p * p <= max_val; p++)
        {
            if (prime[p] == true)
            {
                for (int i = p * 2; i <= max_val; i += p)
                {
                    prime[i] = false;
                }
            }
        }
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            if (prime[arr[i]])
            {
                count++;
            }
        }
        return count;
    }
 
  
}
