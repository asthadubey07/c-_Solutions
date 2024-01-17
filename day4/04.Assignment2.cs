//2.    Write a c# program to implement the following requirement:
using System;
class HelloWorld {

      static void Main(string[] args)
      {
          Console.Write("Enter the size of array: ");
          int size=int.Parse(Console.ReadLine());

          int []arr=new int[size];

          for(int i=0;i<size;i++)
          {
              Console.WriteLine("plese enter the number ");
                        arr[i]=int.Parse(Console.ReadLine());
                        
          }

          float result=average(arr,size);

          Console.Write(result);


      }

      static int average(int []arr,int size)
      {
         int sum=0;
         foreach(int i in arr)
         {
            sum=sum+i;


         }
         return sum/size;


      }

    }





//b.   Create  a method that takes array of strings. It should return the array that convert all the items in uppercase format. 
		
 using System;

class Program
{
    static void Main(string[] args)
    {
        string[] names = { "abhi","rahul","Anjali","Muskan","shrij" };
        
        Console.WriteLine("The Array is:-");
        
        foreach(string name in names)
        {
            Console.WriteLine(" " + name);
        }
        
        Console.WriteLine();
        
        Console.WriteLine("UpperCase of the array is:-");    
        upperNames(names);
    
    }
    
   static void upperNames(string[] strings)
    {
        for (int i = 0; i < strings.Length; i++)
        {
            strings[i] = strings[i].ToUpper();
            Console.WriteLine(" " + strings[i]);
        }
    }
}