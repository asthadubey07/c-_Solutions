
 

// 8.   Generate  Bill Details 

  

// -->  AMB Mall multiplex is developing application for its cafeteria. The application should be able to calculate the bill details for the following scenario. You bought pizzas, puffs and cool drinks.  

  

// Consider   the following prices : 

//     Rs.300/pizza 

//     Rs.50/puffs 

//     Rs.130/pepsi 

 

// Generate a bill. 

 

// a.  Read No. pizzas, puffs, pepsis from user 

// b.  The bill details must include the total cost of pizzas, total cost of puffs and total cost of pepsis.  

// c.   Calculate the grand total and display. 

// d.  Display the GST and CESS amount. GST is 9% and CESS is 9% of the total price. 

 

 

 

using System;  

class Program  

{  

    static void Main(string[] args)  

    {  

        int pizza,puff,pepsi;  

        int pizzaPrice = 300;  

        int puffPrice = 50;  

        int pepsiPrice = 130;  

        double totalPizzaprice, totalPuffprice,totalPepsiprice,totalprice; 

        double gst,cess,grandTotal; 

  

        Console.Write("Enter number of pizzas: ");  

        pizza = int.Parse(Console.ReadLine());  

  

        Console.Write("Enter number of puffs: ");  

        puff = int.Parse(Console.ReadLine());  

  

        Console.Write("Enter number of pepsis: ");  

        Pepsi = int.Parse(Console.ReadLine());  

  

  

        totalPizzaprice = pizza * pizzaPrice;  

        totalPuffprice = puff * puffPrice;  

        totalPepsiprice = pepsi * pepsiPrice;  

  

        totalprice, = totalPizzaprice, + totalPuffprice, + totalPepsiprice,;  

        gst = totalprice * 0.09;  

        cess= totalprice * 0.09;  

  

        grandTotal = totalprice + gst+ cess;  

  

        Console.WriteLine("Total cost of pizzas:"+ totalPizzaprice);  

        Console.WriteLine("Total cost of puffs:"+totalPuffprice);  

        Console.WriteLine("Total cost of pepsis:"+ totalPepsiprice);  

        Console.WriteLine("Total cost:"+ totalprice);  

        Console.WriteLine("GST amount:"+ gst);  

        Console.WriteLine("CESS amount:"+ cess);  

        Console.WriteLine("Grand total:"+ grandTotal);  

    }  

} 

 