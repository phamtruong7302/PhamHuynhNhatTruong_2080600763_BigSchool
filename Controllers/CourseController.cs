using BigSchool.Models;
using BigSchool.ViewModels;
using Microsoft.AspNet.Identity;
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
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CourseViewModel viewModel)
        {
            if(!ModelState.IsValid)
            {
                viewModel.Categories = _dbcontex.Categories.ToList();
                return View("Create",viewModel);
            }
            else 
            {
                var course = new Course
                {
                    LecturerID = User.Identity.GetUserId(),
                    DateTime = viewModel.getDateTime(),
                    CategoryID = viewModel.Category,
                    Place = viewModel.Place,
                };
                _dbcontex.Courses.Add(course);
                _dbcontex.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            
        }
    }
}