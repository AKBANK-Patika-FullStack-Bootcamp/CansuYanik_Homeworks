In this week, The task given this week is to create a database for our project and create a table for the log and model. In addition, it is asked to load the .bak extension file of the database we created in SQL.

<h3>All tables created</h3>

You can see the database and tables inside the db.

![tables](https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week3/DB_Screenshots/tables.PNG)

-------------------------------------------

<h3>Create Table</h3> 

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

<h3> Insert an Entry & Show Table </h3> 

![insertion](https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week3/DB_Screenshots/insertion.PNG)

-------------------------------------------

<h3> Insert & Update an Entry </h3> 


![ia](https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week3/DB_Screenshots/insert_update.PNG)

-------------------------------------------

<h3> Delete an Entry </h3> 

![d](https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week3/DB_Screenshots/table.PNG)

-------------------------------------------

<h3> To Connect Two Tables with Foreign Key</h3> 

![d](https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week3/DB_Screenshots/join.PNG)
