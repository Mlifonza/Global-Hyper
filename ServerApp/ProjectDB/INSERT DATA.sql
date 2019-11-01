USE GlobalHyper
GO

INSERT INTO WORKER
VALUES ('Lifa', 'Sibiya', 'Mlifonza', 'fori', 'Supervisor', 0, 0, 'false', null),
		('Nolwazi', 'Sithole', 'Lwazi', 'lwazi', 'Cashier', 0, 0, 'false', null),
		('Fanele', 'Biyela', 'Madabbz', 'madabbz', 'Cashier', 0, 0, 'false', null)
GO

--INSERT INTO HOURSWORKED
--VALUES (0, 1),
--		(0, 2),
--		(0, 3)
--GO

INSERT INTO PRODUCTS
VALUES ('bread', 12.99),
		('Pasta rice 10kg', 59.99),
		('Cooking oil 2l', 24.99),
		('Kerlogs 5kg', 39.99),
		('Raja soup', 6.99),
		('coca-cola', 19.99)
GO

INSERT INTO AVAILABLESTOCK
VALUES (20, 100),
		(25, 101),
		(14, 102),
		(60, 103),
		(31, 104),
		(52, 105)
GO
