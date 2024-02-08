/*1.  Write a C# Program to implement the following requirement :  

	a . Create a class called BankDesk   
	b.  Create a property that holds the customer information if the form queue  :   Queue<Customer> 
	c.  Define the following methods :
				a.  AddCustomerToQueue()
				b.  RemoveCustomerFromQueue()
	d.  Also add events for OnAddCustomerToQueue  and OnRemoveCustomerFormQueue and prepare corresponding dependent delegates and eventargs classes.
	
	e.  In program class, create object for BankDesk class and perform the operations 
	
				-  add some customers in queue
				-  remove some customers from queue
				-  subscribe the events OnAddCustomerToQueue  and OnRemoveCustomerFormQueue with corresponding methods. */



using System;



class BankDesk
{
    public Queue<Customer> queue { get; set; }

    public Queue<Customer> CustomerQueue { get { return queue; } }

    public event CustomerAddDelegate OnAddCustomerToQueue;

    public event CustomerRemoveDelegate OnRemoveCustomerToQueue;

    public BankDesk()
    {
        queue = new Queue<Customer>();
    }
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public string? AccountNumber { get; set; }


    }

    public class AddCustomerEventArgs
    {
        public Customer? CustomerData { get; set; }
    }

    public delegate void CustomerAddDelegate(AddCustomerEventArgs e);
    public delegate void CustomerRemoveDelegate(RemoveCustomerEventArgs e);

    public class RemoveCustomerEventArgs
    {
        public Customer? CustomerData { get; set; }
    }

    public void AddCustomerToQueue(Customer customer)
    {
        queue.Enqueue(customer);
        if (OnAddCustomerToQueue != null)
        {
            AddCustomerEventArgs e = new AddCustomerEventArgs();
            e.CustomerData = customer;
            OnAddCustomerToQueue(e);

            // Console.WriteLine("Added customer {0} to the queue.\n",customer.CustomerName);

        }
    }

    public void RemoveCustomerFromQueue()
    {
        queue.Dequeue();
        if (OnRemoveCustomerToQueue != null)
        {
            RemoveCustomerEventArgs e1 = new RemoveCustomerEventArgs();
            OnRemoveCustomerToQueue(e1);
        }
    }

    public void ShowCustomer()
    {
        foreach (Customer customer in queue)
        {
            Console.WriteLine("Customer ID: {0}\nCustomer Name:{1}\nAccount Number: {2}\n", customer.CustomerId, customer.CustomerName, customer.AccountNumber);
        }
    }
}



internal class Program
{
    public static void Main(string[] args)
    {
        BankDesk bankDesk = new BankDesk();
        bankDesk.OnAddCustomerToQueue += new CustomerAddDelegate(SMS_CustomerAddEventMethod);
        bankDesk.OnRemoveCustomerToQueue += new CustomerRemoveDelegate(SMS_CustomerRemovedEventMethod);

        bankDesk.AddCustomerToQueue(new Customer { CustomerId = 100, CustomerName = "manisha", AccountNumber = "091283746501" });
        bankDesk.AddCustomerToQueue(new Customer { CustomerId = 200, CustomerName = "elvish", AccountNumber = "098765432112" });
        bankDesk.AddCustomerToQueue(new Customer { CustomerId = 300, CustomerName = "abhishek", AccountNumber = "123456789009" });

        bankDesk.ShowCustomer();


        bankDesk.RemoveCustomerFromQueue();
        Console.WriteLine("\nShow All customer after deletion\n");
        bankDesk.ShowCustomer();


    }
    public static void SMS_CustomerAddEventMethod(AddCustomerEventArgs e)
    {
        Console.WriteLine("[EMAIL Notification] New Customer Details are added to queue at : " + DateTime.Now.ToString());
        Console.WriteLine("New Customer Details : " + e.CustomerData.ToString());
        Console.WriteLine();
    }

    public static void SMS_CustomerRemovedEventMethod(RemoveCustomerEventArgs e)
    {
        Console.WriteLine("[SMS Notification]  Customer Details are removed from queue at : " + DateTime.Now.ToString());
    }
}