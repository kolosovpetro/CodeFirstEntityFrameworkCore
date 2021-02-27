USE [MoviesDb]
GO
DROP TABLE IF EXISTS dbo.actors
CREATE TABLE dbo.actors(
	actor_id INT IDENTITY(1,1) PRIMARY KEY,
	first_name VARCHAR(50) NOT NULL,
	last_name VARCHAR(50) NOT NULL,
	birthday DATETIME NOT NULL
	);