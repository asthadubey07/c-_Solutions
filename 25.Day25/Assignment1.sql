/*
1.  CREATE a stored PROCEDUREs that will display the employee details bASed on the given dept name.  Dept name is the input for stored PROCEDURE.
*/ 

CREATE PROCEDURE usp_getEmpByDeptName
@param_deptname varchar(50)

AS
BEGIN
SELECT * FROM Employee WHERE DeptName = @param_deptname
END;

EXEC usp_getEmpByDeptName Angular

DROP PROCEDURE usp_getEmpByDeptNament

