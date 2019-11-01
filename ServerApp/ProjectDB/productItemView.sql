USE GlobalHyper
GO

IF Exists(SELECT NAME FROM sys.views
  WHERE NAME = 'productInfo')
  DROP VIEW productInfo
GO

CREATE VIEW productInfo
AS
SELECT name, price, stock, AVAILABLESTOCK.proID
FROM PRODUCTS
JOIN AVAILABLESTOCK
ON PRODUCTS.proID = AVAILABLESTOCK.proID
GO

SELECT * FROM productInfo

UPDATE productInfo
SET name='bread-something'
WHERE name='bread'