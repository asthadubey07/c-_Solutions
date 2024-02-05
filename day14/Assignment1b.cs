/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    // Step1
    public delegate int  MyMathDelegate(int  x,  int y);


    public class MyMathClass
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }
    }

    internal class Program
    {      
        static void Main(string[] args)
        {
            Console.WriteLine("Working with Delegates in C#");

            MyMathClass  myMath = new MyMathClass();

          
            MyMathDelegate delegateObj1 = new MyMathDelegate(myMath.Sum);
            MyMathDelegate delegateObj2 = new MyMathDelegate(myMath.Multiply);

            
            int result  = delegateObj1(10,20);  // Invoke Sum() method
            Console.WriteLine("Sum  Result  : " +  result);

            result = delegateObj2(10, 20);  // Invoke Multiply() method
            Console.WriteLine("Multiply Result  : " + result);


            Console.ReadLine();
        }
    }
}

*/


/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    // Step1
    public delegate void MyTestDelegate();
	
    internal class Program
    {
        public static void Hello()
        {
            Console.WriteLine("Message from Hello Method");
        }

       
        static void Main(string[] args)
        {
            Console.WriteLine("Working with Delegates in C#");
            // Step2:
            MyTestDelegate delegateObj = new MyTestDelegate(Hello);

            // Step3:
            delegateObj();  // Invoke Hello() method

            Console.ReadLine();
        }
    }
}
*/