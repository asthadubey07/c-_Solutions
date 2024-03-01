/*
3.  Create stored procedures that return max salary based on the given job. Job as input. Max salary is output. 
*/

CREATE PROCEDURE usp_MaxSalary
@param_Job varchar(50),
@param_maxSalary INT OUTPUT
as
begin
SELECT MAX(Salary) AS MaxSalary FROM Employee WHERE Job =  @param_Job 
end;
DECLARE @empJob varchar(20) ='React';
DECLARE @maxSal INT;
EXEC usp_MaxSalary @empJob, @maxSal OUTPUT
SELECT @maxSal

DROP PROCEDURE usp_MaxSalary;

