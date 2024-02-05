using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Name
{
	


 public class BankAccount
    {
        public double AccountNumber { get; set; }
        public string  CustomerName { get; set; }
		 public string PhoneNumber { get; set; }
		  public double BalanceAmount { get; set; }
	 




   public BankAccount(){
        double BalanceAmount = 2000;
    }


public void Deposit(double Amount)

        {

            double Amount += BalanceAmount;

        }
	}

	public class AddBankAccountEventArgs
    {
        public BankAccount BankAccountData { get; set; }

    }

	    public delegate void BankAccountAddDelegate(AddBankAccountEventArgs B);

		 public class BankAccountCollection
    {
        public List<BankAccount> Bankdata{ get; set; }

        public event BankAccountAddDelegate OnBankAccountAdded;

        public BankAccountCollection()
        {
          Bankdata  = new List<BankAccount>();   
        }


        public void customer(BankAccount obj)
        {
           Bankdata.Add(obj);

            if(OnBankAccountAdded != null)
            {
                AddBankAccountEventArgs B = new AddBankAccountEventArgs();
                B.BankAccountData = obj;

                OnBankAccountAdded(B);  //  This invokes that method 
            }
            
        }

      

        public void Showdetails()
        {
            foreach (BankAccount obj in Bankdata)
            {
                Console.WriteLine(obj.ToString());
            }
        }

    }



	 class Program
    { 
        static void Main(string[] args)
        {

           BankAccountCollection bankdetails = new BankAccountCollection();
          

             BankAccountCollection.OnBankAccountAdded += new BankAccountAddDelegate(Deposit_BankAccountAddedEventMethod);

             BankAccount B = new BankAccount() { AccountNumber = 10256736786, BalanceAmount = 548658 };
           
           BankAccountCollection.AddBankAccount(B);
          
            Console.WriteLine("account no.{1}, CREDIT withAMountRS.3500" +  DateTime.Now.ToString(),"Balance{3}",AccountNumber,BalanceAmount);
            bankdetails.Showdetails();  
                         

            Console.ReadLine();

        }     

		  public static  void Deposit_BankAccountAddedEventMethod(AddBankAccountEventArgs B)
        {
            Console.WriteLine("balance",Amount);
        }


	           
	}

}

