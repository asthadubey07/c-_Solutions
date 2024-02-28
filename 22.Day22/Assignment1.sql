/*1.  Create a table called customer with the following columns:
		customerId, name, address, contactnumber,  city,  age

2.   INSERT 5 rows in the above table. */

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

SELECT * FROM Customer

INSERT INTO Customer VALUES(1002, 'Gambardella', 'anand nagar',123456789,'katni',21);
INSERT INTO Customer VALUES(1121, 'Eva', 'gopal nagar',0987654321,'bhopal',21);
INSERT INTO Customer VALUES(1123, 'maani', 'indrapuri',0192837465,'bhopal',21);
INSERT INTO Customer VALUES(11131, 'sonam', 'kymore',098712345,'Hyderabad',21);