USE GlobalHyper
GO

IF Exists(SELECT NAME FROM sys.procedures
  WHERE NAME = 'cashFromOperator')
  DROP PROCEDURE cashFromOperator
GO

CREATE PROC cashFromOperator
@num FLOAT,
@username VARCHAR(50)
AS
BEGIN
	UPDATE WORKER
	SET cashRecieved = cashRecieved - @num
	WHERE position = 'Supervisor'
END
BEGIN
	UPDATE WORKER
	SET balance = balance + @num
	WHERE position = 'Supervisor'
END
BEGIN
	UPDATE WORKER
	SET cashTransfered = cashTransfered - @num
	WHERE username = @username
END
BEGIN
	UPDATE WORKER
	SET balance = balance - @num
	WHERE username = @username
END
GO

SELECT * FROM WORKER

EXEC cashFromOperator 100, 'Lwazi'
