using System;
using System.Collections.Generic;
using System.Text;

namespace CE_Domain
{
    public class Course
    {
        public Course()
        {
            Enrollments = new List<Enrollment>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public List <Enrollment> Enrollments { get; set; }
    }
}
