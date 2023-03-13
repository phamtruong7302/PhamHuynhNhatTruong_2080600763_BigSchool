using BigSchool.Models;
using BigSchool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigSchool.Controllers
{
   
    public class CourseController : Controller
    {
        private readonly ApplicationDbContext _dbcontex;
        public CourseController()
        {
            _dbcontex = new ApplicationDbContext();
        }
        // GET: Course
        [Authorize]
        public ActionResult Create()
        {
            var ViewModel = new CourseViewModel
            {
                Categories = _dbcontex.Categories.ToList(),
            };
            return View(ViewModel);
        }
    }
}