using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Day_02.Models;

namespace MVC_Day_02.Controllers
{
    public class CourseController : Controller
    {
       
        AppDbContext context = new AppDbContext();

        #region Day 04

        // Index Method [Get Method]
        public IActionResult Index()
        {
            var courses = context.Courses.Include(c => c.Department).ToList();

            return View(courses);

        }

        // Add Method [Get Method]
        public IActionResult Add()
        {
            var departments = context.Departments.ToList();
            ViewBag.Departments = departments;
            return View();
        }

        // Add Method [Post Method]
        [HttpPost]
        public IActionResult Add(Course newCourse)
        {

            context.Courses.Add(newCourse);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        #endregion

    }
}
