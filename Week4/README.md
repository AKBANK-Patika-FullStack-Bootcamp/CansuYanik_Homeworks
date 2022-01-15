## Week 4

In this week, The task given this week is to create database connection with the project and perform CRUD operations on the project using the Entity Framework Core library.

### What has been done:
- Logger class and operation is added
- Installing Entity.FrameworkCore
- Created a DAL (Data Access Layer) folder and moved the model into it.
- Created the Entity folder and created the UserContext class which the db connection is made.
- DB connection from server explorer.
- Generated gender and log classes (since there are tables in db)
- Connection string added to appsettings file

```
Ex:
"ConnectionStrings": {
     "UserDBEntities": "Server=DESKTOP-CST55KG\\SQLEXPRESS; Data Source=localhost;Database=MeetCatDB;integrated security=True;"
   },
```

- CRUD operations using Entitiy Framework Library


<h3>1. Get Method</h3>

Cat list is fetched from database.

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week4/Screenshots/get.PNG" />
</p>

-------------------------------------------

<h3>2. GetById Method</h3> 

A cat is fetched from database.

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week4/Screenshots/getById.PNG" />
</p>

-------------------------------------------

<h3>4. Error Post Operation </h3>

The cat is already exists.

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week4/Screenshots/ppst_alreadyExists.PNG" />
</p>

-------------------------------------------

<h3>5. Delete an Entry </h3>
Database after success delete operation

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week4/Screenshots/success_delete.PNG" />
</p>


