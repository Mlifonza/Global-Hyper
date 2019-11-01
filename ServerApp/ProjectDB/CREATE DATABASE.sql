USE MASTER
GO

IF EXISTS (SELECT name FROM master.dbo.sysdatabases
			WHERE name = 'GlobalHyper')
			DROP DATABASE GlobalHyper
GO

CREATE DATABASE GlobalHyper
ON PRIMARY
(
	NAME = 'GlobalHyper_data',
	FILENAME = 'C:\Users\user\Documents\Visual Studio 2013\Projects\Global-Hyper\ServerApp\ProjectDB\GlobalHyper_data.mdf',
	SIZE = 5MB,
	FILEGROWTH = 10%
)
LOG ON
(
	NAME = 'GlobalHyper_log',
	FILENAME = 'C:\Users\user\Documents\Visual Studio 2013\Projects\Global-Hyper\ServerApp\ProjectDB\GlobalHyper_log.ldf',
	SIZE = 5MB,
	FILEGROWTH = 10% 
)
GO