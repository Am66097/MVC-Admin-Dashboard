using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Day_02.Models
{
    public class crsResult
    {
        public int Id { get; set; }
        public int Degree { get; set; }

        // Navigation Properties and Forein Keys

        [ForeignKey(nameof(Course))]
        public int crs_id { get; set; }
        [ForeignKey(nameof(Trainee))]
        public int trainee_id { get; set; }

        public Course? Course { get; set; }
        public Trainee? Trainee { get; set; }

    }
}
