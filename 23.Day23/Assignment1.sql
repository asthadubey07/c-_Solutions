/*				
3.  Check the following requirements using query, value, exists methods:

	a.  consider the xml data that you generated in the above  query
	b.  display all customer details
	c.   display  customer details based on id
	d.   check the customer details exists are not based on id
	e.   get only age of the customer based on id 
	f.   display all city names
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



declare @XmlDataStr XML

SET @XmlDataStr = '<CustomerList>
  <Customer CustomerId="101" Name="Gambardella" Address="katni" contactnumber="736856291" City="katni" age="31" />
  <Customer CustomerId="102" Name="Kim" Address="bhopal" contactnumber="123456789" City="katni" age="50" />
  <Customer CustomerId="103" Name="Eva" Address="indore" contactnumber="123456678" City="katni" age="55" />
  <Customer CustomerId="104" Name="Matthew" Address="mumbai" contactnumber="0987654321" City="katni" age="103" />
</CustomerList>';



	--b.  display all customer details
	select @XmlDataStr As CustomerDetail
	--c.   display  customer details based on id
	select @XmlDataStr.query('/CustomerList/Customer[@CustomerId = 101]')

	--d.   check the customer details exists are not based on id
 SELECT @XmlDataStr.exist('/CustomerList/Customer[@CustomerId = 102]')
	--e.   get only age of the customer based on id 
	
	 SELECT @XmlDataStr.value('/CustomerList[1]/Customer[1]/@age', 'int') as Age
	--f.   display all city names  


	 SELECT  
    x.Rec.value('./@City', 'VARCHAR(100)') as City
FROM @XmlDataStr.nodes('/CustomerList/Customer') as x(Rec)