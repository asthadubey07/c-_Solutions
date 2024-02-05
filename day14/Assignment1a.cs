using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp7
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("{0},{1}", ID, Name);
        }
    }

    public class AddEmployeeEventArgs
    {
        public Employee EmployeeData { get; set; }

    }

    public delegate void EmployeeAddDelegate(AddEmployeeEventArgs e);




    public class EmployeesCollection
    {
        public List<Employee> Employees{ get; set; }

        public event EmployeeAddDelegate OnEmployeeAdded;

        public EmployeesCollection()
        {
            Employees  = new List<Employee>();   
        }

        public void AddEmployee(Employee obj)
        {
            Employees.Add(obj);

            if(OnEmployeeAdded != null)
            {
                AddEmployeeEventArgs e = new AddEmployeeEventArgs();
                e.EmployeeData = obj;

                OnEmployeeAdded(e);  //  This invokes that method 
            }
            
        }

        public void RemoveEmployee(Employee obj)
        {
            Employees.Remove(obj);
        }

        public void ShowEmployees()
        {
            foreach (Employee obj in Employees)
            {
                Console.WriteLine(obj.ToString());
            }
        }

    }

    class Program
    { 
        static void Main(string[] args)
        {

            EmployeesCollection  empCollection = new EmployeesCollection();
        //    empCollection.OnEmployeeAdded += new EmployeeAddDelegate(Email_EmployeeAddedEventMethod);
        //    empCollection.OnEmployeeAdded += new EmployeeAddDelegate(SMS_EmployeeAddedEventMethod);

            

            Employee e1 = new Employee() { ID = 10256, Name = "Scott" };
            Employee e2 = new Employee() { ID = 10255, Name = "Smith" };
            Employee e3 = new Employee() { ID = 10257, Name = "Sandy" };

            empCollection.AddEmployee(e1);
            empCollection.AddEmployee(e2);
            empCollection.AddEmployee(e3);
            Console.WriteLine("-------------------- Shows All Employees Details ------------------");
            empCollection.ShowEmployees();  
                         

            Console.ReadLine();

        }     
        

        public static  void Email_EmployeeAddedEventMethod(AddEmployeeEventArgs e)
        {
            Console.WriteLine("[EMAIL Notification] New Employee Details are added to collection at : " + DateTime.Now.ToString());
            Console.WriteLine("New Employee Details :  " + e.EmployeeData.ToString());
        }

        public static void SMS_EmployeeAddedEventMethod(AddEmployeeEventArgs e)
        {
            Console.WriteLine("[SMS Notification] New Employee Details are added to collection at : " + DateTime.Now.ToString());
            Console.WriteLine("New Employee Details :  " + e.EmployeeData.ToString());
        }

    }
}