USE GlobalHyper
GO

IF Exists(SELECT NAME FROM sys.procedures
  WHERE NAME = 'cashToSupervisor')
  DROP PROCEDURE cashToSupervisor
GO

CREATE PROC cashToSupervisor
@num FLOAT,
@username VARCHAR(50),
@password VARCHAR(50)
AS
BEGIN
	UPDATE WORKER
	SET cashTransfered = cashTransfered + @num
	WHERE username = @username AND iPassword = @password
END
BEGIN
	UPDATE WORKER
	SET cashRecieved = cashRecieved + @num
	WHERE position = 'Supervisor'
END
GO

EXEC cashToSupervisor 50, @username='Lwazi', @password='lwazi'

SELECT * FROM WORKER
GO