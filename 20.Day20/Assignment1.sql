/*
Products :  ProductId, Name, QuantityInStock, UnitPrice, Category
 Cart   :  Id,  CartId, ProductId, Quantity
 
1. Write the sql queries for the following requirements  by using joins concept:

	a. Consider the Products table and Cart table 
	b. Write a Query to display the results from the above two tables:
			CardId,  ProductName, Quantity, UnitPrice
			
		Hint :  Quantity should takes from Cart table
			
	c.  Try to apply inner join,  right outer join , left outer join and full outer join on the above tables.
	*/

SELECT * FROM Products
SELECT * FROM Carts

-- INNER JOIN
SELECT CartId,Name,Quantity,UnitPrice
FROM  Products
INNER JOIN Carts
ON   Products.Id = Carts.ProductId



-- LEFT OUTER JOIN
SELECT CartId,Name,Quantity,UnitPrice
FROM Products
LEFT OUTER JOIN Carts
ON  Products.Id = Carts.ProductId


-- RIGHT OUTER JOIN
SELECT CartId,Name,Quantity,UnitPrice
FROM Products
RIGHT OUTER JOIN Carts
ON  Products.Id = Carts.ProductId



-- FULL OUTER JOIN
SELECT CartId,Name,Quantity,UnitPrice
FROM Products
FULL OUTER JOIN Carts
ON  Products.Id = Carts.ProductId



