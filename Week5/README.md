## Week 4

The task given this week is adding user login operations, token generation and usage and paging operations in our project.

### What has been done:
- Header is used for security and access operations. Header must be filled if we want to login into a website. Body is used for post operation(for dynamic data).
- Login class and AuthController are created. APIAuthority table is created in the database.
- Access Token is used.
- MD5Hash method is used for hashing the passwords.
- Cryptography library is imported.
- JwtBearer, Swashbuckle.Filters libraries are added.
- Select Bearer Token on Postman Authorization Section.
- Create Token and use this token to be able to use GET HTTP method.


<h3>1. APIAuthority Table</h3>

APIAuthority Table is created to save users for login operation. Initially, table is empty.

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week5/Screenshots/authTable.PNG" />
</p>


-------------------------------------------

<h3>2. Create Login</h3> 

A user is created for login operation.

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week5/Screenshots/createLogin.PNG" />
</p>

APIAuthority table after successful "create login" operation:

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week5/Screenshots/tableAftercreateLogin.PNG" />
</p>

-------------------------------------------

<h3>4. Login User </h3>

Before the login operation, "Bearer Token" option is selected from "Postman Authorization" section.

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week5/Screenshots/bearerTokenSelection.PNG" />
</p>

Token is created after a successful login operation.

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week5/Screenshots/tokenCreated.PNG" />
</p>

If login operation is not successful (invalid operation), bad request and error message is sent.

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week5/Screenshots/invalid.PNG" />
</p>

-------------------------------------------

<h4>GetCat Request with Authontication </h4>

GetCat request and unauthorized response:

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week5/Screenshots/noAuth.PNG" />
</p>

Token is given to use Bearer Token Auth. Using Bearer Token Auth, response will be OK for GetCat operation.

<p align="center">
  <img src="https://github.com/AKBANK-Patika-FullStack-Bootcamp/CansuYanik_Homeworks/blob/main/Week5/Screenshots/getWithToken.PNG" />
</p>

-------------------------------------------


