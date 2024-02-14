/*1.   Recreate the tables that are created in yesterday assignment: 

 		a. Create a table :   Products
				Columns and Constraints: 
						ProductId ---  Primary Key,
						Name   --   Not Null, 
						QuantityInStock ----   Not Null, Greater than Zero
						UnitPrice,   ----  Not null, Greater than Zero
						Category    ---  Not null
				
				
		b.  Create a table :  Cart
				Columns and  Constraints:  
						Id	---		Primary Key,  
						CartId  ----  NOT NULL, 
						ProductId  ---   Foreign Key with Products(ProductId), 
						Quantity   ---    Not Null,  Greater than zero 
				
		c.  Create a table :   Users
				Columns :  UserId , UserName, Password, ContactNumber, Address
				
				Hint :   No need to change Users table 
				
		d.   Create a table :  Orders
			Columns and  Constraints:  
				
					OrderId  ---  Primary Key,  
					CartId ---    Foreign Key with Cart(CartId), 
					OrderDate,   
					UserId   ---  Foreign Key with Users(UserId)
				
			   
 Note:
	1.  Try to insert valid and invalid records in the above tables. 
	2.  Try to verify with delete cascade and without delete cascade. 
	3.  Verify that all constrains are working properly. 
*/	
	
 
USE ShoppingCartDb

CREATE TABLE Products
(
	Id INT PRIMARY KEY,
	Name VARCHAR(50) NOT NULL,
	QuantityInStock int NOT NULL check (QuantityInStock >0),
	UnitPrice int NOT NULL check (UnitPrice >0),
	Category VARCHAR(100) NOT NULL	
	
);
INSERT INTO Products VALUES (10,'iphone',5,4345445,'electrical');
INSERT INTO Products VALUES (20,'eyeliner',0,4565856,'beauty');
INSERT INTO Products VALUES (30,'tab',8,456556,'electronic');
INSERT INTO Products VALUES (90,'liner',67894,456587,'beauty');



 

CREATE TABLE Carts
(
	Id INT PRIMARY KEY,
	CartId int Not NULL,
	ProductId int,
	CONSTRAINT  FK_Carts_Products  FOREIGN KEY (ProductId)
	REFERENCES Products(Id),
	Quantity int NOT NULL check (Quantity >0)
);
INSERT INTO Carts VALUES (111,100,10,5);
INSERT INTO Carts VALUES (222,200,20,5);
INSERT INTO Carts VALUES (333,300,90,76); 
INSERT INTO Carts VALUES (999,900,90,36);




CREATE TABLE Users
(
    UserId INT PRIMARY KEY,
	UserName VARCHAR(50),
	Password VARCHAR(50),
	ContactNumber VARCHAR(13),
	Address VARCHAR(500)
);
INSERT INTO Users VALUES (1001,'bebika','Bebika@123',1234567890,'katni');
INSERT INTO Users VALUES (1002,'muskaan','muskaan@123',1232067890,'jabalpur');







CREATE TABLE Orders
(
	OrderId INT PRIMARY KEY,
	CartId int,
	CONSTRAINT  FK_Orders_Carts  FOREIGN KEY (CartId)
	REFERENCES Carts(Id),
	OrderDate Datetime,
	UserId int,
	CONSTRAINT  FK_Orders_Users  FOREIGN KEY (UserId)
	REFERENCES Users(UserId)
);
INSERT INTO Orders VALUES (10001,111,10/05/23,1001);
INSERT INTO Orders VALUES (10002,222,20-05-23,1002);
	

SELECT * FROM Products
SELECT * FROM Carts
SELECT * FROM Users
SELECT * FROM Orders
