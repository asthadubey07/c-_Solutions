/*  Write a C# Program to implement the following requirement :  

	a.  Create an Employee class with following properties:
			empno, ename, job, salary, deptno
			
	b.  Use collection initializer and initialize with around 10 employees details
	
	c.   Perform the following operations:
				-- Display employee based on the given Job
				-- Display employee based on the given Deptno
				-- Find How many managers are there is the list  (Count need to display)
				-- Find How many leads are working in deptno 20  (Count need to display)
				
				
	Hint :  Use Object Initializer, Collection Initializer and Implicitly Typed Local Variables
    
    
    3.  Try to recreate the above task once again using Lambda Expressions. 
		[Hint : Do it by your own. ]
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
public class Employee
{
    public int empno { get; set; }
    public string ename { get; set; }
    public string job { get; set; }
    public double salary { get; set; }
    public int deptno { get; set; }
}
class Program
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>()
        {
        new Employee{empno=100,ename="manisha",job="manager",salary=200000,deptno=20},
        new Employee{empno=200,ename="pooja",job="Developer",salary=2006700,deptno=21},
        new Employee{empno=300,ename="jiya",job="Lead",salary=2000000,deptno=20},
        new Employee{empno=400,ename="aashika",job="manager",salary=2000008,deptno=20},
        new Employee{empno=500,ename="falaq",job="Developer",salary=2087000,deptno=20},
        new Employee{empno=600,ename="aaliya",job="Tester",salary=2000500,deptno=20},
        new Employee{empno=700,ename="palak",job="Lead",salary=20004,deptno=20},
        new Employee{empno=800,ename="bebika",job="Tester",salary=2000365,deptno=21},
        new Employee{empno=900,ename="aakaii",job="manager",salary=2000902,deptno=20},
        new Employee{empno=1000,ename="puneet",job="Lead",salary=20001,deptno=22}
        };


        Console.WriteLine("Enter the employee job: ");
        var empJob = Console.ReadLine();
        var empsByJob = employees.Where(item => item.job == empJob);
        foreach (var item in empsByJob)
        {
            Console.WriteLine("Emp no: {0}\nEmployee Name: {1}\nEmployee Job:{2}\nEmployee Salary:{3}\nEmployee Dept No: {4}\n", item.empno, item.ename, item.job, item.salary, item.deptno);
        }




        Console.WriteLine("Enter the employee dept No: ");
        var empDeptNo = int.Parse(Console.ReadLine());
        var empsByDeptno = employees.Where(item => item.deptno == empDeptNo);
        foreach (var item in empsByDeptno)
        {
            Console.WriteLine("Emp ID: {0}\nEmployee Name: {1}\nEmployee Job:{2}\nEmployee Salary:{3}\nEmployee Dept No: {4}\n", item.empno, item.ename, item.job, item.salary, item.deptno);
        }




        var count = employees.Count(item => item.job == "manager");
        Console.WriteLine("Total Managers are: {0}", count);



        var leadCount = employees.Count(item => item.job == "Lead" && item.deptno == 20);
        Console.WriteLine("Total lead in  dept no 20 are: " + leadCount);

    }
}




