USE [MoviesDb]
GO
DROP TABLE IF EXISTS dbo.employees
CREATE TABLE dbo.employees(
	first_name VARCHAR(50) NOT NULL,
	last_name VARCHAR(50) NOT NULL,
	city VARCHAR(50) NOT NULL,
	birthday DATETIME NOT NULL);