/*
5.  Add try catch block into the above example.
*/
CREATE PROCEDURE usp_insertDetails
AS
begin
	 BEGIN TRY
	INSERT INTO Employee VALUES(112,'pooja','c==',80040,20,'hbbj',56483548)
 END TRY
  BEGIN CATCH
			DECLARE @ErrorMessage NVARCHAR(4000);
			DECLARE @ErrorSeverity INT;
			DECLARE @ErrorState INT;
			 SELECT @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE(); 
			SELECT @ErrorMessage
		
	 END CATCH
end;
