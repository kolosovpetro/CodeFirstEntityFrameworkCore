USE [MoviesDb]
GO
DROP TABLE IF EXISTS dbo.starring
CREATE TABLE dbo.starring(
	actor_id INT NOT NULL,
	movie_id INT NOT NULL,
	CONSTRAINT FK_StarringId_MovieId FOREIGN KEY(movie_id)
	REFERENCES dbo.movies(movie_id)
	);