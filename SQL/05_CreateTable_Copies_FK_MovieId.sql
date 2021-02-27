USE MoviesDb
GO
DROP TABLE IF EXISTS dbo.copies
CREATE TABLE dbo.copies(
	copy_id INT IDENTITY(1,1) PRIMARY KEY,
	available BIT NOT NULL,
	movie_id INT NOT NULL,
	CONSTRAINT FK_MovieId FOREIGN KEY (movie_id)
	REFERENCES dbo.movies(movie_id)
	);