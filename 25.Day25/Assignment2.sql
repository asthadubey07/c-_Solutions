/*
2. Create stored procedures that get employees count who are having greater salary than the average of all salaries.  Output is employees count. 
*/

CREATE  PROCEDURE  usp_getEmpCount
@param_empCount INT OUTPUT
AS
begin
	SELECT Count(Name) AS EmpCount FROM Employee
WHERE Salary > (SELECT AVG(Salary) FROM Employee)
end;
DECLARE @empCount INT
EXEC usp_getEmpCount @empCount OUTPUT
SELECT @empCount

--DROP PROCEDURE usp_getEmpCount

