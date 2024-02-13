
USE ShoppingCartDb
/* 1.  On Product Table  
			a.   Display all Products
			b.   Display Products belongs to particular Category 
			c.   Display out of stock products (means quantity is zero)
			d.  Display the products which price between 1000 to 10000 
			e.  Display the product details based on the ProductId*/
--CREATE TABLE Product*/
--(
	--ProductId INT PRIMARY KEY,
	--ProductName VARCHAR(50),
	--QuantityInStock int,
	--UnitPrice int,
	--Category VARCHAR(50)
--);

SELECT * FROM Product
SELECT * FROM Product WHERE Category='electronic'
SELECT * FROM Product WHERE QuantityInStock<=0
SELECT * FROM Product WHERE ProductId=30








/*	iii.   On Users Table
			a. Display All users 
			b. Display user details based on ContactNumber
			c. Display user details based on UserId
*/
--CREATE TABLE Users
--(
	
   -- UserId INT PRIMARY KEY,
	----UserName VARCHAR(50),
	--Password VARCHAR(50),
	--ContactNumber VARCHAR(13),
	--Address VARCHAR(500)
--);

SELECT * FROM Users
SELECT * FROM Users WHERE ContactNumber='1234567890'
SELECT * FROM Users WHERE UserId = 101
	
	
	












	
	/*	ii.   On Cart Table:
			a.  Display data based on the given CartId
			b.  Check is there any products added in Cart based on the ProductId
    */
	
	--CREATE TABLE Cart
    -- (
	--Id INT PRIMARY KEY,
	--CartId int,
	--ProductId int,
	--Quantity int
    --  );	
	SELECT * FROM Cart WHERE CartId= 1
	SELECT * FROM Cart WHERE ProductId= 30
	
	








	
	
/*	iv.  On Orders table
			
		a.  Display OrderDetails based on OrderId
		b.  Display OrderDetails based on UserId
		b.  Display OrderDetails based on OrderDate*/
	--CREATE TABLE Orders
    --(
	--OrderId INT PRIMARY KEY,
	--CartId int,
	--OrderDate DateTime,
	--UserId int
    --);	
	
SELECT * FROM Orders WHERE OrderId = 1001
SELECT * FROM Orders WHERE UserId = 103
SELECT * FROM Orders WHERE OrderDate = 1899-12-14