/*1.  Create a table called customer with the following columns:
		customerId, name, address, contactnumber,  city,  age


4.  Use the following xml content and insert into sql server table using OPENXML concept. 

		<?xml version="1.0"?>
	<catalog>
		  <book id="bk101"  author="Gambardella, Matthew"  title="XML Developer's Guide"  genre="Computer"  price="44.95"     /> 
		 <book id="bk102"  author="Ralls, Kim"  title="Midnight Rain"  genre="Fantasy"  price="94.95"     /> 
		  <book id="bk103"  author=">Corets, Eva"  title="Maeve Ascendant"  genre="Fantasy"  price="64.95"     /> 
		<book id="bk104"  author="Randall, Matthew"  title="The Sundered Grail"  genre="Fantasy"  price="44.95"     /> 
	</catalog>

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


DECLARE @docId INT
DECLARE	@xmlDataStr VARCHAR(1000)

SET @XmlDataStr = '<CustomerList>
  <Customer CustomerId="101" Name="Gambardella" Address="katni" contactnumber="736856291" City="katni" age="31" />
  <Customer CustomerId="102" Name="Kim" Address="bhopal" contactnumber="123456789" City="katni" age="50" />
  <Customer CustomerId="103" Name="Eva" Address="indore" contactnumber="123456678" City="katni" age="55" />
  <Customer CustomerId="104" Name="Matthew" Address="mumbai" contactnumber="0987654321" City="katni" age="103" />
</CustomerList>';

EXEC sp_xml_preparedocument @docId OUTPUT, @xmlDataStr

INSERT INTO Customer
SELECT * FROM OPENXML(@docId, '/CustomerList/Customer')
WITH Customer

EXEC sp_xml_removedocument @docId

