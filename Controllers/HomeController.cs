using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigSchool.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbcontex;
        public HomeController()
        {
            _dbcontex = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var _CommingsoonCouse = _dbcontex.Courses.Include(a => a.Lecturer).Include(a => a.Category).Where(a => a.DateTime > DateTime.Now);
            return View(_CommingsoonCouse);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}