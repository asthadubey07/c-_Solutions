/*
4. Create stored procedures that insert the data into emp table. Take all the required values as input parameters. 
*/
CREATE PROCEDURE usp_insertDetails
	@param_EmpNo INT,
	@param_EmpName VARCHAR(20),
	@param_Job VARCHAR(20),
	@param_Salary INT,
	@param_Deptno INT,
	@param_contactnumber INT,
	@param_DeptName VARCHAR(20)
As
BEGIN
	INSERT INTO Employee VALUES(@param_EmpNo, @param_EmpName, @param_Job, @param_Salary, @param_Deptno, @param_DeptName,@param_contactnumber)
END

EXEC usp_insertDetails 112,'pooja','c==',80040,20,'hbbj',56483548