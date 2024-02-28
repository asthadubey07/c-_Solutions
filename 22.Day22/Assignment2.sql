/*1.  Create a table called customer with the following columns:
		customerId, name, address, contactnumber,  city,  age

3.  Generate XML data with  the above table using XML RAW option. 
	 Save the XML data in a file. Upload this file along the assignment documents.  

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
SELECT * FROM Customer

INSERT INTO Customer VALUES(1001, 'Gambardella', 'anand nagar',123456789,'katni',21);
INSERT INTO Customer VALUES(111, 'Eva', 'gopal nagar',0987654321,'bhopal',21);
INSERT INTO Customer VALUES(112, 'maani', 'indrapuri',0192837465,'bhopal',21);
INSERT INTO Customer VALUES(1113, 'sonam', 'kymore',098712345,'Hyderabad',21);

SELECT * FROM Customer
FOR XML RAW('Customer')

SELECT * FROM Customer
FOR XML RAW('Customer'),ELEMENTS

SELECT * FROM Customer
FOR XML RAW('Customer'), root('CustomerList')

SELECT * FROM Customer
FOR XML RAW('Customer'),ELEMENTS, root('CustomerList')