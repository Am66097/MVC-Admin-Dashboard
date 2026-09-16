using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Day_02.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ImgURL { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public decimal Salary { get; set; }

        // Navigation Properties and Forein Keys
        [ForeignKey(nameof(Department))]
        public int dept_id { get; set; }

        [ForeignKey(nameof(Course))]
        public int crs_id { get; set; }

        public Department? Department { get; set; }
        public Course? Course { get; set; }


    }
}
