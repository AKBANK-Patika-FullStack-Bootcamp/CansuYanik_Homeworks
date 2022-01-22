USE [MeetCatDB]
GO

INSERT INTO [dbo].[Gender]
           ([gender])
     VALUES
           ('male'),
		   ('female')
GO

SELECT * FROM Gender
GO

INSERT INTO [dbo].[Cat]
           ([userName]
           ,[breed]
           ,[genderId]
           ,[birth])
     VALUES
           ('Mia', 'Tabby', '2', '2019-07-01'),
		   ('Lexa', 'Burmilla', '2', '2020-10-20'),
		   ('Kajun', 'British Shorthair', '1', '2020-03-05')
GO

SELECT * FROM Cat
GO


