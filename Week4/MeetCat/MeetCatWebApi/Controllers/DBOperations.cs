using EFLibCore;
using System;
using DAL.Model;

namespace MeetCatWebApi.Controllers
{
    public class DBOperations
    {
        private CatUserContext _context = new CatUserContext();

        public void AddModel(Cat _cat)
        {
            _context.CatUser.Add(_cat);
            _context.SaveChanges();
        }

        public List<Cat> GetCatUser()
        {   
            //fetch all cat profiles from db
            List<Cat> cats = new List<Cat>();
            cats = _context.CatUser.OrderBy(m => m.catId).ToList<Cat>();
            return cats;
        }
    }
}