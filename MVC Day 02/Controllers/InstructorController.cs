using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Day_02.Models;
using MVC_Day_02.ViewModels;

namespace MVC_Day_02.Controllers
{
    public class InstructorController : Controller
    {
        AppDbContext context = new AppDbContext();

        #region Day 02
        public IActionResult Index()
        {
            var instructors = context.Instructors
                .Include(i => i.Department)
                .Include(i => i.Course)
                .ToList();

            return View(instructors);
        }

        public IActionResult Details(int id)
        {
            var instructor = context.Instructors
                .Include(i => i.Department)
                .Include(i => i.Course)
                .FirstOrDefault(i => i.Id == id);

            if (instructor == null)
            {
                return NotFound();
            }

            return View(instructor);
        }

        #endregion

        #region Day 03

        // Create [HTTP Get]
        public IActionResult Create()
        {
            var departments = context.Departments.ToList();
            var courses = context.Courses.ToList();

            var model = new InstructorCreateViewModel
            {
                Departments = departments,
                Courses = courses
            };
            return View(model);


        }


        // Create [HTTP Post]
        [HttpPost]
        public IActionResult Create(InstructorCreateViewModel modelVM)
        {
            var newInstructor = new Instructor()
            {
                Name = modelVM.Name,
                ImgURL = modelVM.ImgURL,
                Address = modelVM.Address,
                Salary = modelVM.Salary,
                dept_id = modelVM.dept_Id,
                crs_id = modelVM.crs_Id

            };

            context.Add(newInstructor);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        // Edit [Http Get]
        public IActionResult Edit(int id)
        {
            var instructor = context.Instructors.FirstOrDefault(i => i.Id == id);
            if (instructor == null)
                return NotFound();

            var departments = context.Departments.ToList();
            var courses = context.Courses.ToList();

            var UpdatedInstructor = new InstructorCreateViewModel
            {
                Id = instructor.Id,
                Departments = departments,
                Courses = courses,
                Name = instructor.Name,
                Address = instructor.Address,
                Salary = instructor.Salary,
                ImgURL = instructor.ImgURL,
                crs_Id = instructor.crs_id,
                dept_Id = instructor.dept_id
            };

            return View(UpdatedInstructor);

        }

        // Edit [Http Post
        [HttpPost]
        public IActionResult Edit(InstructorCreateViewModel modelVM)
        {
            var oldInstructor = context.Instructors.FirstOrDefault(o => o.Id == modelVM.Id);

            if (oldInstructor == null)
            {
                return NotFound();
            }

            oldInstructor.Name = modelVM.Name;
            oldInstructor.Address = modelVM.Address;
            oldInstructor.Salary = modelVM.Salary;
            oldInstructor.ImgURL = modelVM.ImgURL;
            oldInstructor.dept_id = modelVM.dept_Id;
            oldInstructor.crs_id = modelVM.crs_Id;

            context.SaveChanges();
            return RedirectToAction("Index");


        }


        #endregion




    }
}