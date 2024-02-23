/*3.   Prepare the multiple sets of group based results :

		Hint :   Prepare the groups based on city, course, both and all count, 

			a.  Using Union All
			b.  Using  Groping SEts
			c.   Using  Cube
			d.  Using Rollup*/

USE ShoppingCartDb

CREATE TABLE Student
(
	StudentId INT PRIMARY KEY,
	StudentName VARCHAR(50) NOT NULL,
	CourseName VARCHAR(50) NOT NULL,
	CityName VARCHAR(100) NOT NULL,
	ContactNumber int NOT NULL check (ContactNumber>0)
	
);

INSERT INTO Student VALUES(101,'manisha','Angular','Mumbai',1234567890);
INSERT INTO Student VALUES(102,'pooja','Angular','Pune',321456789);
INSERT INTO Student VALUES(103,'jiya','React','Pune',2134567890);
INSERT INTO Student VALUES(104,'palak','React','Mumbai',1234567098);
INSERT INTO Student VALUES(105,'bebika','Angular','Hyderabad',1234567908);
INSERT INTO Student VALUES(106,'aaliya','React','Mumbai',1234765890);
INSERT INTO Student VALUES(107,'falak','React','Hyderabad',1234675890);
INSERT INTO Student VALUES(108,'puneet','Angular','Mumbai',1235567890);
INSERT INTO Student VALUES(109,'Abishek','Angular','Pune',123446789);
INSERT INTO Student VALUES(1001,'avinaash','React','Hyderabad',923456789);


SELECT * FROM Student
  SELECT CityName, count(*)  As DETAILS FROM Student
GROUP BY CityName

UNION ALL
SELECT CourseName, count(*) As DETAILS FROM Student
GROUP BY CourseName

SELECT CityName, CourseName,count(*)  As DETAILS FROM Student 
Group By  
GROUPING SETS  
	   (
		(CityName, CourseName),
		(CityName),
		(CourseName),
		()
	   )
  ORDER BY GROUPING(CityName), GROUPING(CourseName),CityName

 SELECT CityName, CourseName, count(*) As DETAILS FROM Student 
Group By  CUBE(CityName, CourseName)
ORDER BY GROUPING(CityName), GROUPING(CourseName),CityName

SELECT CityName, CourseName,  count(*) As DETAILS FROM Student 
Group By  ROLLUP(CityName, CourseName)
ORDER BY GROUPING(CityName), GROUPING(CourseName),CityName