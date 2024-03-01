/*
6.  How to add if...else in stored procedure?  Prepare an example.
*/
CREATE  PROCEDURE  usp_getEmpCount
@param_empCount INT OUTPUT
AS
begin
	SELECT Count(Name) AS EmpCount FROM Employee
WHERE Salary > (SELECT AVG(Salary) FROM Employee)
IF  (@param_empCount >AVG(Salary))
	PRINT 'your salary is below average';
ELSE
	PRINT 'your salary is not below average ';
end;

DECLARE @empCount INT
EXEC usp_getEmpCount @empCount OUTPUT
SELECT @empCount