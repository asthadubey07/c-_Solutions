/*1. Write a C# program to process customer details:  
		Class Name :	Customer
		•	Class should allow the following parameters in constructor
				Customer c1  = new Customer();
				Customer c2  = new Customer(10256);
				Customer c3  = new Customer(10256, “Scott”);
				Customer c4  = new Customer(10256, “Scott”, “Hyd”);

		•	Declare required number of variables in the class. 
		•	Method :  ShowDetails() to display all the values in single Line.
			Eg:	Customer Details  ::   Id : 10256, Name : Scott, City : Hyd */





using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
class Customer{
    private int _custno;
    private string _custname, _city;
    public Customer()
    {
        _custno = 0;
        _custname =  "";
        _city = "";
    }

    public Customer(int  custno)
    {       
        _custno = custno;
        _custname =  "";
        _city = "";
    }

     public Customer(int  custno, string custname)
    {       
        _custno = custno;
        _custname =  custname;
        _city = "";
    }
    public Customer(int  custno, string custname, string city)
    {       
        _custno = custno;
        _custname =  custname;
        _city = city;
    }
    public void ShowDetails()
    {
        Console.WriteLine("Customer :: Id :: {0}, Name :: {1}, City :: {2}",_custno,_custname,_city);
    }

    internal class Program{
        public static void Main(String[] args){

            Customer c1 = new Customer();
            Customer c2 = new Customer(10256);
            Customer c3 = new Customer(10256,"Scott");
            Customer c4 = new Customer(10256,"Scott","Hyd");
            c1.ShowDetails();
            c2.ShowDetails();
            c3.ShowDetails();
            c4.ShowDetails();
        }
    }
}


