using CE_Data;
using CE_Domain;
using System;

namespace CE_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new CourseEnrollContext())
            {

                //var std = new Student()
                //{
                //    LastName = "Kafka",
                //    FirstMidName = "Franz",
                //    EnrollmentDate = DateTime.Now

                //};
                //context.Students.Add(std);

                //var crs = new Course()
                //{
                //    Title = "COMP3618",
                //    Credits = 4
                //};
                //context.Courses.Add(crs);

                //var enr = new Enrollment
                //{
                //    Course = crs,
                //    Student = std
                //};
                //context.Enrollments.Add(enr);


                context.SaveChanges();
            }







        }
    }
}
