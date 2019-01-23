

using CE_Domain;
using Microsoft.EntityFrameworkCore;

namespace CE_Data
{
    public class CourseEnrollContext: DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server = DESKTOP-5MGN125; Database = CEData; Trusted_Connection = True;");
        }
    }
}
