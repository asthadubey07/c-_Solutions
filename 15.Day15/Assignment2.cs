/*2.  Write a C# Program to implement the following requirement :  

	a.  Create an Employee class with following properties:
			empno, ename, job, salary, deptno
			
	b.  Use collection initializer and initialize with around 10 employees details
	
	c.   Perform the following operations:
				-- Display employee based on the given Job
				-- Display employee based on the given Deptno
				-- Find How many managers are there is the list  (Count need to display)
				-- Find How many leads are working in deptno 20  (Count need to display)
				
				
	Hint :  Use Object Initializer, Collection Initializer and Implicitly Typed Local Variables */


using System;
using System.Collections;
using System.Collections.Generic;

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
        Console.WriteLine("Enter the job of employee");
        var empJob = Console.ReadLine();
        foreach (var employee in employees)
        {
            if (employee.job == empJob)
            {
                Console.WriteLine("{0},{1},{2},{3},{4}", employee.empno, employee.ename, employee.job, employee.salary, employee.deptno);
            }
        }

        Console.WriteLine("Enter the deptno. of employee");
        var deptNo = int.Parse(Console.ReadLine());
        foreach (var employee in employees)
        {
            if (employee.deptno == deptNo)
            {
                Console.WriteLine("{0},{1},{2},{3},{4}", employee.empno, employee.ename, employee.job, employee.salary, employee.deptno);
            }
        }

        var count = 0;
        foreach (var i in employees)
        {
            if (i.job == "manager")
            {
                count = count + 1;

            }
        }
        Console.WriteLine("Total number of managers are: {0}", count);

        var leadCount = 0;
        foreach (var i in employees)
        {
            if (i.deptno == 20 && i.job == "Lead")
            {
                leadCount = leadCount + 1;
            }
        }
        Console.WriteLine("Total leads who is working on  dept no 20 are: " + leadCount);
    }
}
