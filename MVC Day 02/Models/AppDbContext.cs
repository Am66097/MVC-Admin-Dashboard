using Microsoft.EntityFrameworkCore;

namespace MVC_Day_02.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<crsResult> CrsResults { get; set; }
        public DbSet<Trainee> Trainees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.;Database=MVCDay02;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.dept_id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<crsResult>()
                .HasOne(r => r.Course)
                .WithMany(c => c.crsResults)
                .HasForeignKey(r => r.crs_id)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}