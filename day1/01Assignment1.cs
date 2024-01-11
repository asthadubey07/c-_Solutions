// update the example with following conditions:	 

// Hint :  Required Values ---  id, name, price, qty  

// a.  If qty is greater than 10   ---    10% discount on total amount 

// b.  If qty is greater than 30   ---    20% discount on total amount  

// c.  If qty is greater than 50   ---    30% discount  on total amount 

 

           using System;   

           using System.Collections.Generic;    

           namespace Details {   

           internal class Program {   

static void Main (string [] args){   

  int id;   

 int price; 

 String name;   

 int quantity;   

int total; 

int discount; 

int newprice; 

 Console.WriteLine("enter product Id:");   

 id= int.Parse(Console.ReadLine());  

  Console.WriteLine("enter product price:");   

 price= int.Parse(Console.ReadLine());   

  Console.WriteLine("enter product name:");    

 name = Console.ReadLine();   

  Console.WriteLine("enter the quantity of product:");   

  quantity =int.Parse(Console.ReadLine());  

  total=price*quantity        

      if (quantity>50){ 

    discount=(total/100)*10; 

    newprice=total-discount; 

     Console.WriteLine("total price in rupee:"+total);  

     Console.WriteLine("new price in rupee:"+newprice); 

} 

 else if (quantity>30&& quantity<=50)  

  {        

   discount=(total/100)*20; 

    newprice=total-discount; 

     Console.WriteLine("total price:"+total);  

Console.WriteLine("new price in:"+newprice); 

} 

 else if(quantity>10 &&quantity<=30){ 

    discount=(total/100)*30; 

    newprice=total-discount; 

     Console.WriteLine("total price:"+total);  

     Console.WriteLine("new price:"+newprice); 

} 

 else{ 

     Console.WriteLine("total price:"+total);  

      } 

    } 

  }   

 }   

 

 

 
