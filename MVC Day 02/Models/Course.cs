using MVC_Day_02.CustomValidations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Day_02.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; } = string.Empty;
        [Range(50,100)]
        public int Degree { get; set; }
        [MinDegreeLessThanDegree]
        public int MinDegree { get; set; }
        [Range(10,100)]
        public decimal Hours { get; set; }

        // Navigation Properties and Forein Keys
        [ForeignKey(nameof(Department))]
      
        public int dept_id { get; set; }

        public List<Instructor> Instructors { get; set; } = new List<Instructor>();
        public List<crsResult> crsResults { get; set; } = new List<crsResult>();
        public Department? Department { get; set; }



    }
}
