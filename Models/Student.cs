﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SofTechBlendUni.Models
{
    public class Student
    {

        
        public int StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstMidleName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
        

    }
}