class Employee
{
   public int Id { get; set; }
    public string Name{ get; set; }
    
    public string Job{get; set;}

    public int Basic {get; set;}
    public double HRA{get; set;}
    public double DA{get; set;}
    public double IT{get; set;}
    public double PF{get; set;}

   
     public void GetGrossSalary()
    {
        double GrossSalary = Basic + HRA + DA - IT - PF;
        Console.WriteLine("GrossSalary:"+ GrossSalary);
        
    }
    public void PrintDetails()
    {
        Console.WriteLine("Id:{0},Name:{1},Job:{2},Basic:{3}",Id,Name,Job,Basic);
    }
    class ContractEmployee : Employee{
    public float Duration{ get; set; }

    public override void PrintDetails(){
        Console.WriteLine("Id: {0}, Name:{1},Job:{2},Basic:{3},Duration:{4}", Id, Name, Job, Basic, Duration);
    }

    public override void GrossSalary(){
        double GrossSalary = Basic + HRA + DA - IT;
        Console.WriteLine("GrossSalary:"+ GrossSalary);
    }
}
    public static void Main(string[] args)
    {
       ContractEmployee contract = new ContractEmployee();
        Console.WriteLine("Enter details:");
        contract .Id=int.Parse(Console.ReadLine());
        contract .Name=Console.ReadLine();
        contract .Job=Console.ReadLine();
        contract .Basic=int.Parse(Console.ReadLine());

        contract .HRA=contract .Basic*0.15;
        contract .DA=contract .Basic*0.08;
        contract .IT=contract .Basic*0.05;
        contract .PF=contract .Basic*0/10;
        
        contract .GetGrossSalary();
        contract .PrintDetails();

    } 

}
