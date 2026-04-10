CREATE TABLE Country(
	Id INTEGER PRIMARY KEY IDENTITY,
	Name VARCHAR(200) NOT NULL,
	Language VARCHAR(200) NOT NULL,
	Continent NVARCHAR(100) NOT NULL
)
GO

INSERT INTO [dbo].[Country] ([Name],[Language] ,[Continent])
VALUES('Costa Rica', 'Español', 'América'),
('Argentina', 'Español', 'América'),
('Canada', 'Inglés/Frances', 'América'),
('Francia', 'Frances', 'Europa'),
('España', 'Español', 'Europa')
GO
