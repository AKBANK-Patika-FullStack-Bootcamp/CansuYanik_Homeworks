using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using DAL.Model;
using EFLibCore;
using MeetCatWebApi.Controllers;
using Microsoft.AspNetCore.Authorization;
using MeetCatWebAPI;

namespace MeetCatWebApi.AddControllers
{

    [ApiController]
    [Route("[controller]")]

    public class UserOperationsController : ControllerBase
    {

        Logger logger = new Logger();  //create a logger class
        List<Cat> CatProfileList = new List<Cat>();

        //db connection
        DBOperations dbOperation = new DBOperations();


        /*HTTP get request methods*/
        [Authorize]
        [HttpGet]
        public List<CatDetail> GetCats()
        {
            /*sort cat profiles according to their catIds then convert to list type*/
            logger.createLog("Get operation: Cat list is fetched.");
            //return dbOperation.GetCatUser();
            return dbOperation.GetCatUserDetais();
        }


        [Authorize]
        //Get customers in smaller chunks
        [HttpGet("/UserOperations/GetCatPaging")]
        public IActionResult GetCatsPaging([FromQuery] PagingParameters paging)
        {

            //paging.PageNumber = 0;
            //paging.PageSize = 3;

            var owners = dbOperation.GetCatUser()  //All cats from db
           .Skip(paging.PageNumber) // From which record(page) , every page contains #"paging.pageSize" cats
           .Take(paging.PageSize) // How many cats to display
           .ToList();


            return Ok(owners);
        }


        /*get id from route*/
        //api/MeetCat/{id}
        [Authorize]
        [HttpGet("{id}")]
        public Cat GetById(int id)
        {
            //fetch the whole list from db
            List<Cat> userList = dbOperation.GetCatUser();

            Cat? resultObject = new Cat();
            resultObject = userList.Find(x => x.catId == id);
            if (resultObject == null)
                logger.createLog("Error GetById operation: There is no cat with " + id + " id");
            else
                logger.createLog("Success GetById operation: Cat with " + resultObject.catId + " is fetched.");
            return resultObject;
        }

        /*HTTP post request method*/
        [Authorize]
        [HttpPost]
        public Result AddProfile([FromBody] Cat newProfile)
        {

            Cat usr = dbOperation.FindCat(newProfile.userName);
            
            /*new profile is in the list already?*/
            bool userCheck = (usr != null) ? true : false;

            Result result = new Result();

            if (userCheck == false)
            {
                
                if (dbOperation.AddModel(newProfile) == true)
                {
                    /*If there is no same id in list, add new profile*/
                    result.HttpStatusCode = Ok().StatusCode; //Successfully added.
                    result.Message = "New cat with " + newProfile.catId + " id is added.";
                    logger.createLog("Success add operation: " + result.Message + "\tStatus Code: " + result.HttpStatusCode);
                }
                else
                {
                    /*If there is an error while adding*/
                    result.HttpStatusCode = BadRequest().StatusCode; //error code
                    result.Message = "Cat with " + newProfile.catId + " id cannot added.";
                    logger.createLog("Error add operation: " + result.Message + "\tStatus Code: " + result.HttpStatusCode);
                }

            }
            else
            {
                /*If this cat user already exists*/
                result.HttpStatusCode = BadRequest().StatusCode; //error code
                result.Message = "Cat with " + newProfile.catId + " id already exists.";
            }
            
            return result;
        }

        /*HTTP put request method*/
        [Authorize]
        [HttpPut("{id}")]
        public Result UpdateProfile(int id, [FromBody] Cat updatedProfile)
        {   
            Result result = new Result();

            //fetch the whole list from db
            List<Cat> userList = dbOperation.GetCatUser();

            //User Cat updated operation
            /*If desired profile is found from list, update it*/
            Cat? _oldValue = userList.Find(o => o.catId == id);
            if (_oldValue != null)
            {
                dbOperation.DeleteModel(id);
                dbOperation.AddModel(updatedProfile);

                result.HttpStatusCode = Ok().StatusCode; //Successfully updated.
                result.Message = "Cat with " + updatedProfile.catId + " is updated.";
                logger.createLog("Success update operation: " + result.Message + "\tStatus Code: " + result.HttpStatusCode);
            }
            else
            {
                result.HttpStatusCode = BadRequest().StatusCode; //error code
                result.Message = "There is no cat with " + id + " id.";
                logger.createLog("Error update operation: " + result.Message + "\tStatus Code: " + result.HttpStatusCode);
            }
            return result;
        }

        /*HTTP delete request method*/
        [Authorize]
        [HttpDelete("{id}")]
        public Result DeleteProfile(int id)
        {   
            Result result = new Result();

            /*If desired profile is found from list, delete it*/
            if (dbOperation.DeleteModel(id))
            {
                result.HttpStatusCode = Ok().StatusCode; //Successfully deleted
                result.Message = "Cat with " + id + " id is deleted.";

                logger.createLog("Success deletion operation: " + result.Message + "\tStatus Code: " + result.HttpStatusCode);
            }
            else
            {
                result.HttpStatusCode = BadRequest().StatusCode; //error code
                result.Message = "There is no cat with " + id + " id.";
                logger.createLog("Error deletion operation: " + result.Message + "\tStatus Code: " + result.HttpStatusCode);
            }
            return result;
        }
    }
}