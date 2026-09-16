using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Day_02.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Degree { get; set; }
        public int MinDegree { get; set; }
        public decimal Hours { get; set; }

        // Navigation Properties and Forein Keys
        [ForeignKey(nameof(Department))]
        public int dept_id { get; set; }

        public List<Instructor> Instructors { get; set; } = new List<Instructor>();
        public List<crsResult> crsResults { get; set; } = new List<crsResult>();
        public Department? Department { get; set; }



    }
}
