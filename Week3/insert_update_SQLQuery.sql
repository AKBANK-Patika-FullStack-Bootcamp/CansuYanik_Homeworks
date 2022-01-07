USE [MeetCatDB]
GO

INSERT INTO [dbo].[Cats]
           ([userName]
           ,[breed]
           ,[genderId]
           ,[bith])
     VALUES
           ('King', 'Angora', '1' , '2020-07-05')
GO

SELECT * FROM [MeetCatDB].[dbo].[Cats]

UPDATE [dbo].[Cats]
   SET [breed] = 'Angora Cat'
      ,[genderId] = 1
 WHERE catId = 7
GO

SELECT * FROM [MeetCatDB].[dbo].[Cats] WHERE catId = 7
GO

