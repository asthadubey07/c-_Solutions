/*Write SQL Queries for the following requirements
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ 
1.  Create a table called customer with the following columns:
		customerId, name, address, contactnumber,  city,  age    		
		(Hint: You can reuse Day22 Assignment table)
		
2.  Generate xml data on the above table using :
				for xml auto, raw, explicit, path 
				

*/

USE ShoppingCartDb

CREATE TABLE Customer
(
	CustomerId INT PRIMARY KEY,
	Name VARCHAR(50) NOT NULL,
	Address VARCHAR(50) NOT NULL,
	contactnumber int NOT NULL check (ContactNumber>0),
	City VARCHAR(100) NOT NULL,
	age INT NOT NULL,
	
);

SELECT * FROM BankAccount
SELECT * FROM BankBranch
SELECT * FROM Customer



INSERT INTO Customer VALUES(1002, 'Gambardella', 'anand nagar',123456789,'katni',21);
INSERT INTO Customer VALUES(1121, 'Eva', 'gopal nagar',0987654321,'bhopal',21);
INSERT INTO Customer VALUES(1123, 'maani', 'indrapuri',0192837465,'bhopal',21);
INSERT INTO Customer VALUES(11131, 'sonam', 'kymore',098712345,'Hyderabad',21);

--xml auto
select * from Customer
for xml auto
select * from Customer
for xml auto, root('CustomerList') 

--raw
SELECT * FROM Customer
FOR XML RAW('Customer')

SELECT * FROM Customer
FOR XML RAW('Customer'),ELEMENTS

SELECT * FROM Customer
FOR XML RAW('Customer'), root('CustomerList')

SELECT * FROM Customer
FOR XML RAW('Customer'),ELEMENTS, root('CustomerList')

--explicit

SELECT
    1 AS Tag,
    NULL AS Parent,
    CustomerId  AS [Customer!1!CustomerId],    
    Name AS [Customer!1!Name] 
FROM Customer
FOR XML EXPLICIT


--path

SELECT    
      CustomerId,
      Name,
	  contactnumber
FROM Customer
FOR XML PATH



SELECT    
      CustomerId AS '@CustomerId',
      Name  As 'Name',
	  contactnumber   As 'contactnumber'
FROM Customer
FOR XML PATH



SELECT    
          CustomerId AS '@CustomerId',
      Name  As 'Name',
	  contactnumber   As 'contactnumber'
FROM Customer
FOR XML PATH
('CustomerList')



