abstract class BankAccount
{
    public abstract double Deposit(double amount);
    public abstract double Withdraw(double amount);
}

class SavingsBankAccount: BankAccount
{
    public int accountNumber{get; set;}
    public string customerName{get; set;}
    public int balanceAmount{get; set;}

    public override double Deposit(double Amount)
    {
        return Amount;
    }
    public override double Withdraw(double Amount)
    {
        return Amount;
    }

    public void Showdetails()
    {
        if(balanceAmount < 5000)
        {
            Console.WriteLine("Balance is Low");
        }
        Console.WriteLine("account number : {0} , customerName : {1} , balanceAmount : {2}" , accountNumber , customerName , balanceAmount);
    }


}
internal class program
{
    public static void Main(string[] args)
    {
        SavingsBankAccount obj1 = new SavingsBankAccount();
        Console.WriteLine("Account Number: ");
        obj1.accountNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Customer Name :");
        obj1.customerName = Console.ReadLine();
        Console.WriteLine("Balance Account :");
        obj1.balanceAmount = int.Parse(Console.ReadLine());
        obj1.Showdetails();
    }

}