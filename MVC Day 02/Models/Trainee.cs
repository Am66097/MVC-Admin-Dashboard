using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Day_02.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ImgURL { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Grade { get; set; } = string.Empty;

        // Navigation Properties and Forein Keys
        [ForeignKey(nameof(Department))]
        public int dept_id { get; set; } 

        public List<crsResult> crsResults { get; set; } = new List<crsResult>();
        public Department? Department { get; set; }

    }
}
