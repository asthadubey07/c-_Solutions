/*1.   2.  Perform INSERT, UPDATE and DELETE commands on all the tables that you have created in the previous assignments (Day 17 and Day18)?*/	
	
 
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
INSERT INTO Products VALUES (40,'cream',678962,456557,'beauty');

UPDATE Products SET Name='shope' WHERE Id=40
UPDATE Products SET name='jeans', Category='cloth'  WHERE Id=90

DELETE FROM Products WHERE Id=40
SELECT * FROM Products

 




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
INSERT INTO Carts VALUES (222,200,30,5);
INSERT INTO Carts VALUES (333,300,90,76); 
INSERT INTO Carts VALUES (999,900,90,36);

UPDATE Carts SET ProductId = 30 WHERE Id=333
UPDATE Carts SET ProductId= 20, Quantity = 10 WHERE Id=222

DELETE FROM Carts WHERE Id=222
SELECT * FROM Carts



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
INSERT INTO Users VALUES (1003,'Kajal','Kajaln@123',1232067450,'Bhopal');

UPDATE Users SET ContactNumber =1230981237 WHERE UserId=1002
UPDATE Users SET Address= 'Mumbai', ContactNumber=0912873465  WHERE UserId=1001

DELETE FROM Users WHERE UserId=101
DELETE FROM Users WHERE UserId=102
SELECT * FROM Users







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
INSERT INTO Orders VALUES (10003,333,20-05-23,1003);

UPDATE Orders SET  OrderDate=20-04-23 WHERE UserId=1003

DELETE FROM Orders WHERE OrderId=10003
DELETE FROM Orders WHERE OrderId=102
SELECT * FROM Orders

