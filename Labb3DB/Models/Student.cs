﻿using System;
using System.Collections.Generic;

namespace Labb3DB.Models
{
    public partial class Student
    {
        public Student()
        {
            ClassStudents = new HashSet<ClassStudent>();
            StudentGrades = new HashSet<StudentGrade>();
        }

        public int StudentId { get; set; }
        public long Personnummer { get; set; }
        public string Fnamn { get; set; } = null!;
        public string Lnamn { get; set; } = null!;
        public string? Adress { get; set; }
        public string? Telefonnummer { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<ClassStudent> ClassStudents { get; set; }
        public virtual ICollection<StudentGrade> StudentGrades { get; set; }
    }
}
