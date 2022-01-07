USE [MeetCatDB]
GO

EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Cats', @level2type=N'COLUMN',@level2name=N'catId'
GO

/****** Object:  Table [dbo].[Cats]    Script Date: 1/7/2022 11:42:57 PM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Cats]') AND type in (N'U'))
DROP TABLE [dbo].[Cats]
GO

/****** Object:  Table [dbo].[Cats]    Script Date: 1/7/2022 11:42:57 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cats](
	[catId] [int] IDENTITY(1,1) NOT NULL,
	[userName] [nvarchar](50) NOT NULL,
	[breed] [nvarchar](50) NOT NULL,
	[genderId] [int] NOT NULL,
	[bith] [datetime] NULL,
 CONSTRAINT [PK_Cats] PRIMARY KEY CLUSTERED 
(
	[catId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Primary Key ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Cats', @level2type=N'COLUMN',@level2name=N'catId'
GO


