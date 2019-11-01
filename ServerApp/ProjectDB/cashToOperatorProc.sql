USE GlobalHyper
GO

IF Exists(SELECT NAME FROM sys.procedures
  WHERE NAME = 'cashToOperator')
  DROP PROCEDURE cashToOperator
GO

CREATE PROC cashToOperator
@num FLOAT,
@username VARCHAR(50)
AS
BEGIN
	UPDATE WORKER
	SET cashTransfered = cashTransfered + @num
	WHERE position = 'Supervisor'
END
BEGIN
	UPDATE WORKER
	SET cashRecieved = cashRecieved + @num
	WHERE username = @username
END
GO

SELECT * FROM WORKER

EXEC cashToOperator 100, 'Lwazi'
