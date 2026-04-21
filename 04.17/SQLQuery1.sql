-- DATABASE yarat
CREATE DATABASE MusicDB;
GO

USE MusicDB;
GO

-- Artist Table
CREATE TABLE Artist (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    Nationality NVARCHAR(50)
);

-- Album Table
CREATE TABLE Album (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(100) NOT NULL,
    ReleaseYear INT,
    ArtistId INT NOT NULL,
    CONSTRAINT FK_Album_Artist FOREIGN KEY (ArtistId)
        REFERENCES Artist(Id)
        ON DELETE CASCADE
);

-- Track Table
CREATE TABLE Track (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Title NVARCHAR(100) NOT NULL,
    DurationSec INT,
    AlbumId INT NOT NULL,
    CONSTRAINT FK_Track_Album FOREIGN KEY (AlbumId)
        REFERENCES Album(Id)
        ON DELETE CASCADE
);

-- INSERT DATA

-- Artist
INSERT INTO Artist (Name, Nationality) VALUES ('Adele', 'British');
INSERT INTO Artist (Name, Nationality) VALUES ('Drake', 'Canadian');
INSERT INTO Artist (Name, Nationality) VALUES ('Tarkan', 'Turkish');
INSERT INTO Artist (Name, Nationality) VALUES ('Eminem', 'American');
INSERT INTO Artist (Name, Nationality) VALUES ('Arash', 'Iranian');

-- Album
INSERT INTO Album (Title, ReleaseYear, ArtistId) VALUES ('25', 2015, 1);
INSERT INTO Album (Title, ReleaseYear, ArtistId) VALUES ('Scorpion', 2018, 2);
INSERT INTO Album (Title, ReleaseYear, ArtistId) VALUES ('Karma', 2001, 3);
INSERT INTO Album (Title, ReleaseYear, ArtistId) VALUES ('Recovery', 2010, 4);
INSERT INTO Album (Title, ReleaseYear, ArtistId) VALUES ('Donya', 2008, 5);

-- Track
INSERT INTO Track (Title, DurationSec, AlbumId) VALUES ('Hello', 295, 1);
INSERT INTO Track (Title, DurationSec, AlbumId) VALUES ('Gods Plan', 198, 2);
INSERT INTO Track (Title, DurationSec, AlbumId) VALUES ('Kuzu Kuzu', 240, 3);
INSERT INTO Track (Title, DurationSec, AlbumId) VALUES ('Not Afraid', 259, 4);
INSERT INTO Track (Title, DurationSec, AlbumId) VALUES ('Boro Boro', 210, 5);


create view ArtistAlbums  as
select Artist.Name, Album.Title from Artist
join Album on Album.ArtistId = Artist.Id

select * from ArtistAlbums


CREATE PROCEDURE GetArtistAlbums2
	@ArtistName NVARCHAR(100)
AS
BEGIN
	SELECT Artist.Name, Album.Title FROM Album
	JOIN Artist ON Album.ArtistId = Artist.Id
	WHERE Artist.Name = @ArtistName
END;

EXEC GetArtistAlbums2 @ArtistName = 'Adele';

SELECT Artist.Name, Album.Title FROM Album
	JOIN Artist ON Album.ArtistId = Artist.Id
	WHERE Artist.Name = 'Adele'