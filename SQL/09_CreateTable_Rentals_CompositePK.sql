USE [MoviesDb]
GO
DROP TABLE IF EXISTS dbo.rentals
CREATE TABLE dbo.rentals(
	copy_id INT NOT NULL,
	client_id INT NOT NULL,
	date_of_rental DATETIME NOT NULL,
	date_of_return DATETIME NULL,
	CONSTRAINT PK_Rentals PRIMARY KEY (copy_id, client_id),
	CONSTRAINT FK_RentalsCopyId FOREIGN KEY (copy_id)
	REFERENCES dbo.copies(copy_id),
	CONSTRAINT FK_RentalsClientId FOREIGN KEY (client_id)
	REFERENCES dbo.clients(client_id));