USE GlobalHyper
GO

IF Exists(SELECT NAME FROM sys.procedures
  WHERE NAME = 'cashFromSupervisor')
  DROP PROCEDURE cashFromSupervisor
GO

CREATE PROC cashFromSupervisor
@num FLOAT,
@username VARCHAR(50),
@password VARCHAR(50),
@empID INT
AS
BEGIN
	UPDATE WORKER
	SET cashRecieved = cashRecieved - @num
	WHERE username = @username AND iPassword = @password
END
BEGIN
	UPDATE WORKER
	SET balance = balance + @num
	WHERE username = @username AND iPassword = @password
END
BEGIN
	UPDATE WORKER
	SET cashTransfered = cashTransfered - @num
	WHERE position = 'Supervisor'
END
BEGIN
	UPDATE WORKER
	SET balance = balance - @num
	WHERE position = 'Supervisor'
END
GO

EXEC cashFromSupervisor 100, 'Lwazi', 'lwazi'

SELECT * FROM WORKER

DROP PROC cashFromSupervisor

