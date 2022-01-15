using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using DAL.Model;
using EFLibCore;
using MeetCatWebApi.Controllers;

namespace MeetCatWebApi.AddControllers
{

    [ApiController]
    [Route("[controller]")]

    public class MeetCatController : ControllerBase
    {

        Logger logger = new Logger();  //create a logger class
        List<Cat> CatProfileList = new List<Cat>();

        //db connection
        DBOperations DbOpp = new DBOperations();


        /*HTTP get request methods*/
        [HttpGet]
        public List<Cat> GetCats()
        {
            /*sort cat profiles according to their catIds then convert to list type*/
            logger.createLog("Get operation: Cat list is fetched."); 
            return DbOpp.GetCatUser();
        }

        /*get id from route*/
        //api/MeetCat/{id}
        [HttpGet("{id}")]
        public Cat GetById(int id)
        {   
            var cat = CatProfileList.Where(cat => cat.catId == id).SingleOrDefault();
            logger.createLog("GetById operation: Cat with " + cat.catId + " is fetched.");
            return cat;
        }

        /*HTTP post request method*/
        [HttpPost]
        public Result AddProfile([FromBody] Cat newProfile)
        {   
            Result result = new Result();
            /*If there is no same id in list, add new profile*/
            var cat = CatProfileList.SingleOrDefault(cat => cat.catId == newProfile.catId);
            if(cat is not null){
                result.HttpStatusCode = BadRequest().StatusCode; //error code
                result.Message = "Cat with " + cat.catId + " id already exists." ;
                logger.createLog("Error add operation: " + result.Message + "\tStatus Code: " + result.HttpStatusCode);
                return result;
            }
                 
            CatProfileList.Add(newProfile);

            result.HttpStatusCode = Ok().StatusCode; //Successfully added.
            result.Message = "New cat with " + newProfile.catId + " id is added." ;
            logger.createLog("Success add operation: " + result.Message + "\tStatus Code: " + result.HttpStatusCode);
            return result;
        }

        /*HTTP put request method*/
        [HttpPut("{id}")]
        public Result UpdateProfile(int id, [FromBody] Cat updatedProfile)
        {   
            Result result = new Result();
            /*If desired profile is found from list, update it*/
            var cat = CatProfileList.SingleOrDefault(cat => cat.catId == id);
            if(cat is null){
                result.HttpStatusCode = BadRequest().StatusCode; //error code
                result.Message = "There is no cat with " + id + " id." ;
                logger.createLog("Error update operation: " + result.Message + "\tStatus Code: " + result.HttpStatusCode);
                return result;    
            }
            
            /*If not default value, update*/
            cat.userName = updatedProfile.userName != default ? updatedProfile.userName : cat.userName;
            cat.breed = updatedProfile.breed != default ? updatedProfile.breed : cat.breed;
            cat.genderId = updatedProfile.genderId != default ? updatedProfile.genderId : cat.genderId;
            cat.birth = updatedProfile.birth != default ? updatedProfile.birth : cat.birth;

            result.HttpStatusCode = Ok().StatusCode; //Successfully updated.
            result.Message = "Cat with " + cat.catId + " is updated." ;
            logger.createLog("Success update operation: " + result.Message + "\tStatus Code: " + result.HttpStatusCode);
            return result;
        }

        /*HTTP delete request method*/
        [HttpDelete("{id}")]
        public Result DeleteProfile(int id)
        {   
            Result result = new Result();
            /*If desired profile is found from list, delete it*/
            var cat = CatProfileList.SingleOrDefault(cat => cat.catId == id);
            if(cat is null){
                result.HttpStatusCode = BadRequest().StatusCode; //error code
                result.Message = "There is no cat with " + id + " id." ;
                logger.createLog("Error deletion operation: " + result.Message + "\tStatus Code: " + result.HttpStatusCode);
                return result;
            }
            
            CatProfileList.Remove(cat); //deletion

            result.HttpStatusCode = Ok().StatusCode; //Successfully deleted
            result.Message = "Cat with " + cat.catId + " id is deleted." ;

            logger.createLog("Success deletion operation: " + result.Message + "\tStatus Code: " + result.HttpStatusCode);
            return result;
        }
    }
}