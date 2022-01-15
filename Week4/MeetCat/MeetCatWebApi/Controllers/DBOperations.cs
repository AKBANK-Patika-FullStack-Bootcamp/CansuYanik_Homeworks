using EFLibCore;
using System;
using DAL.Model;

namespace MeetCatWebApi.Controllers
{
    public class DBOperations
    {
        private CatUserContext _context = new CatUserContext();
        Logger logger = new Logger();
        public bool AddModel(Cat _cat)
        {
            try
            {
                _context.Cat.Add(_cat);
                _context.SaveChanges();
                
                return true;
            }
            catch (Exception exc)
            {
                //logger.createLog("Error add operation: " + exc.Message + "\tStatus Code: " + BadRequest().StatusCode);
                
                return false;
            }
        }

        public List<Cat> GetCatUser()
        {   
            //fetch all cat profiles from db
            List<Cat> cats = new List<Cat>();
            cats = _context.Cat.OrderBy(m => m.catId).ToList<Cat>();
            return cats;
        }

        public Cat FindCat(string UserName = "", int UserId = 0)
        {
            Cat? user = new Cat();
            if (!string.IsNullOrEmpty(UserName))
                user = _context.Cat.FirstOrDefault(m => m.userName == UserName);
            else if (UserId > 0)
            {
                user = _context.Cat.FirstOrDefault(m => m.catId == UserId);
            }
            return user;
        }

        public bool DeleteModel(int Id)
        {
            try
            {
                _context.Cat.Remove(FindCat("", Id));
                _context.SaveChanges();
                return true;
            }
            catch (Exception exc)
            {
                //logger.createLog("HATA " + exc.Message);
                return false;
            }
        }
    }
}