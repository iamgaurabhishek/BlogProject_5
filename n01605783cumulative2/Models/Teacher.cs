using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace n01605783cumulative2.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherEmployeeNumber { get; set; }

        public string TeacherFirstName { get; set; }

        public string TeacherLastName { get; set; }

        public DateTime TeacherHireDate { get; set; }

        public string TeacherSalary { get; set; }
    }
}