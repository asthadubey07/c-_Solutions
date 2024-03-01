/*
1.  Create procedure for the following requirement:	
		a.  Need to update the salary based on the given empno
		b.  If  old salary is greater than 10000 , then update by adding  5000 
			  Else  Update by adding  7000 to old salary. 
*/


--a
CREATE procedure usp_UpdateSalary
	@param_Empno INT,
	@param_Salary INT OUTPUT
AS
BEGIN
	UPDATE Employee SET Salary = @param_Salary WHERE EmployeeId = @param_Empno
END;

DECLARE @Empno INT= 20;
DECLARE @Salary INT = 50000;

EXEC usp_UpdateSalary @Ename, @Salary OUTPUT
SELECT @Empno, @Salary
DROP procedure usp_UpdateSalary
  


--b.
CREATE procedure usp_UpdSal
	@param_Sal INT OUTPUT
AS
BEGIN
		If @param_Sal > 10000
			BEGIN
				UPDATE Employee SET Salary = Salary + 5000
			END
		Else
			BEGIN
				UPDATE Employee SET Salary = Salary + 7000
			END
END;

DECLARE @Sal INT;
exec usp_UpdSal @Sal OUTPUT