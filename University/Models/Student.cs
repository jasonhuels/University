using System.Collections.Generic;
using System;

namespace University.Models
{
    public class Student
    {
        public Student()
        {
            this.Courses = new HashSet<Enrollment>();
        }

        public int StudentId { get; set; }
        public string Name { get; set; }
        public bool International {get; set;}
        public DateTime EnrollmentDate {get; set;}
        public string Level {get; set;}

        public ICollection<Enrollment> Courses { get;}
    }
}