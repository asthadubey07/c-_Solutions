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
        double GrossSalary;
        GrossSalary = Basic + HRA + DA - IT - PF;
        Console.WriteLine("GrossSalary:"+ GrossSalary);
     }

    public void PrintDetails()
    {
        Console.WriteLine("Id:{0},Name:{1},Job:{2},Basic:{3}",Id,Name,Job,Basic);
    }

    
    public static void Main(string[] args)
    {
        Employee employee = new Employee();
        Console.WriteLine("Enter details:");
        employee.Id=int.Parse(Console.ReadLine());
        employee.Name=Console.ReadLine();
        employee.Job=Console.ReadLine();
        employee.Basic=int.Parse(Console.ReadLine());

        employee.HRA=employee.Basic*0.15;
        employee.DA=employee.Basic*0.08;
        employee.IT=employee.Basic*0.05;
        employee.PF=employee.Basic*0.10;
        
        employee.GetGrossSalary();
        employee.PrintDetails();

    } 

}