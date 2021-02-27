USE [MoviesDb]
GO
DROP TABLE IF EXISTS dbo.movies
CREATE TABLE dbo.movies (
    movie_id INT IDENTITY(1,1) PRIMARY KEY,
	title VARCHAR(50) NOT NULL,
	year INT NOT NULL,
	age_restriction INT NOT NULL,
	price FLOAT NOT NULL
);