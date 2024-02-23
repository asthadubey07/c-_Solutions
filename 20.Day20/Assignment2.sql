/*2. Write the sql queries for the following requirements  by using Group By concept:

	Hint :   -->   Create a table Called "Student"  table with the following columns:
							StudentId,  StudentName,  CourseName,  City Name, ContactNumber
					-->   Insert some 10 rows in the above table. 
	a.   Find out how many Students are joined for "Angular"  Course
	b.   Find out how many Students are joined from  "Hyderabad"  City
	c.    Display No. of Students are join from each  City based 	
			Sample Outupt:
						Hyderabad    10
						Mumbai   20
						Pune   5
						.....	
	d.    Display No. of Students are join from each  Course  based 
			Sample Outupt:
					Angular    10
					React       20
				    ......		
					
	e.     Display the counts  by grouping based on  city, course */

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
--a
	SELECT COUNT(StudentName) FROM Student  WHERE CourseName = 'Angular';	
--b
	SELECT COUNT(*) FROM Student  WHERE CityName = 'Hyderabad';	
--c
	SELECT CityName,COUNT(*) AS Datas FROM Student GROUP BY CityName ;	
--d 	
    SELECT CourseName,COUNT(*) AS Datas FROM Student GROUP BY CourseName;	
--e
	SELECT CityName,CourseName ,COUNT(*) AS Datas FROM Student GROUP BY CityName,CourseName ;	

