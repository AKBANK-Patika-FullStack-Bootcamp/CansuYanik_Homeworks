using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using DAL.Model;
using EFLibCore;
using MeetCatWebApi.Controllers;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;

namespace MeetCatWebApi.AddControllers
{

    [ApiController]
    [Route("[controller]")]

    public class AuthController : ControllerBase
    {

        Logger logger = new Logger();  //create a logger class
        List<Cat> CatProfileList = new List<Cat>();

        //db connection
        DBOperations dbOperation = new DBOperations();
        public static Login login = new Login();

        private readonly IConfiguration _configuration;
        private MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();


        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
           
        //add user into db
        [HttpPost("create")]
        public Result loginCreate(APIAuthority _user)
        {
            _user.Password = MD5Hash(_user.Password);
            dbOperation.CreateLogin(_user);

            Result result = new Result();
            result.HttpStatusCode = Ok().StatusCode; //Successfull operation.
            result.Message = "New user is added.";

            return result;
        }
        
        [HttpPost("login")]
        public async Task<ActionResult<string>> Login([FromHeader] LoginDto request)
        {
            APIAuthority tokenUser = new APIAuthority();
            tokenUser.Email = request.Email;
            tokenUser.Password = MD5Hash(request.Password);

            APIAuthority result = dbOperation.GetLogin(tokenUser);
            
            //If there is a user, create token
            if (result != null)
            {
                string token = CreateToken(login);
                Console.WriteLine(token);
                return Ok(token);

            }
            else
            {
                return BadRequest("Invalid user or password");
            }

        }
        
        private string CreateToken(Login login)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, login.Email),
                new Claim(ClaimTypes.Role, "Admin")
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            Console.WriteLine(jwt.ToString());
            return jwt;
        }
        

        //password hashing method
        public string MD5Hash(string _input)
        {

            //Since method needs to byte, string is converted into byte format
            byte[] str = Encoding.UTF8.GetBytes(_input);
            str = md5.ComputeHash(str);
            StringBuilder sb = new StringBuilder();
            //Convert byte hash into string
            foreach (byte ba in str)
            {
                //change into hexadecimal format
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
    }
}