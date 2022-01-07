USE [MeetCatDB]
GO

INSERT INTO [dbo].[Genders]
           ([gender])
     VALUES
           ('male'),
		   ('female')
GO

SELECT * FROM Genders
GO

INSERT INTO [dbo].[Cats]
           ([userName]
           ,[breed]
           ,[genderId]
           ,[bith])
     VALUES
           ('Mia', 'Tabby', '2', '2019-07-01'),
		   ('Lexa', 'Burmilla', '2', '2020-10-20'),
		   ('Kajun', 'British Shorthair', '1', '2020-03-05')
GO

SELECT * FROM Cats
GO


