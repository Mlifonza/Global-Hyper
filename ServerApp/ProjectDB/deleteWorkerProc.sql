USE GlobalHyper
GO

IF Exists(SELECT NAME FROM sys.procedures
  WHERE NAME = 'deleteWorker')
  DROP PROCEDURE deleteWorker
GO

CREATE PROC deleteWorker
@empID INT
AS
BEGIN
	BEGIN
		BEGIN TRAN
		DELETE FROM WORKER 
		WHERE empID = @empID
		END COMMIT
	END
GO

EXEC deleteWorker 6
