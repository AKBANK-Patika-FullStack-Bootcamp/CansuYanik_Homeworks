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

Initial table from the database

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week4/Screenshots/table.PNG" />
</p>


-------------------------------------------

<h3>2. GetById Method</h3> 

A cat is fetched from database.

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week4/Screenshots/getById.PNG" />
</p>

-------------------------------------------

<h3>4. Post Operation </h3>

New cat profile is added. Id of the cat is incremented automatically.

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week4/Screenshots/afterAdd.PNG" />
</p>

New cat is added into database successfully.

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week4/Screenshots/afterAddTable.PNG" />
</p>

-------------------------------------------

<h4>Error Post Operation </h4>

The cat is already exists.

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week4/Screenshots/ppst_alreadyExists.PNG" />
</p>

-------------------------------------------

<h3>5. Put Operation </h3>

A cat profile is updated.

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week4/Screenshots/put.PNG" />
</p>

Database after successful put operation

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week4/Screenshots/afterPut.PNG" />
</p>

-------------------------------------------

<h3>5. Delete an Entry </h3>

A cat profile is deleted.

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week4/Screenshots/delete.PNG" />
</p>

Database after success delete operation

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week4/Screenshots/success_delete.PNG" />
</p>


