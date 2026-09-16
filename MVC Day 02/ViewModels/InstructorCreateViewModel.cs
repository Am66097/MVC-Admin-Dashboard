using MVC_Day_02.Models;

namespace MVC_Day_02.ViewModels
{
    public class InstructorCreateViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ImgURL { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public int dept_Id { get; set; }
        public int crs_Id { get; set; }

        public List<Department> Departments { get; set; } = new List<Department>();
        public List<Course> Courses { get; set; } = new List<Course>();




    }
}
