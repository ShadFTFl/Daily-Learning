using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FTFLUniversity.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { set; get; }
        public String FirstMidName  { get; set; }
        public DateTime EnrollmentDate { set; get; }
        public virtual ICollection<Enrollment> Enrollments { get; set; } 
    }
}