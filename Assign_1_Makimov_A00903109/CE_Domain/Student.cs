using System;
using System.Collections.Generic;
using System.Text;

namespace CE_Domain
{
    public class Student
    {
        public Student()
        {
            Enrollments = new List<Enrollment>();
        }
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public List<Enrollment> Enrollments { get; set; }
    }
}
