## Week 3

The task given this week is to create a database for our project and create a table for the log and models. In addition, it is asked to load the .bak extension file of the database we created in SQL.

<h3>1. All tables created</h3>

You can see the database and tables inside the db.

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week3/DB_Screenshots/tables.PNG" />
</p>

-------------------------------------------

<h3>2. Create Table</h3> 

To create a table, the sql query given below can be written. I created a "Cats" table. catId is the primary key. genderId is the foreign key.

```
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
```

-------------------------------------------

<h3>3. Insert an Entry & Show Table </h3> 

```
INSERT INTO [dbo].[Cats]
           ([userName]
           ,[breed]
           ,[genderId]
           ,[bith])
     VALUES
           (<userName, nvarchar(50),>
           ,<breed, nvarchar(50),>
           ,<genderId, int,>
           ,<bith, datetime,>)
GO
```

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week3/DB_Screenshots/insertion.PNG" />
</p>

-------------------------------------------

<h3>4. Insert & Update an Entry </h3>

```
UPDATE [dbo].[Cats]
   SET [userName] = <userName, nvarchar(50),>
      ,[breed] = <breed, nvarchar(50),>
      ,[genderId] = <genderId, int,>
      ,[bith] = <bith, datetime,>
 WHERE <Search Conditions,,>
GO
```

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week3/DB_Screenshots/insert_update.PNG" />
</p>

-------------------------------------------

<h3>5. Delete an Entry </h3>

```
DELETE FROM [dbo].[Cats]
      WHERE <Search Conditions,,>
GO
```

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week3/DB_Screenshots/table.PNG" />
</p>

-------------------------------------------

<h3>6. To Connect Two Tables with Foreign Key</h3> 

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week3/DB_Screenshots/join.PNG" />
</p>
