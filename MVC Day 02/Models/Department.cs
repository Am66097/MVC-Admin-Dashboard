namespace MVC_Day_02.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Manager { get; set; } = string.Empty;

        // Navigation Properties and Forein Keys

        public List<Trainee> Trainees { get; set; } = new List<Trainee>();
        public List<Instructor> Instructors { get; set; } = new List<Instructor>();
        public List<Course> Courses { get; set; } = new List<Course>();


    }
}
