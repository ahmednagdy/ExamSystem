﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace ExamSystem.Entities
{
    public partial class Course
    {
        public Course()
        {
            DepartmentCourses = new HashSet<DepartmentCourse>();
            Exams = new HashSet<Exam>();
            InstructorCourses = new HashSet<InstructorCourse>();
            Questions = new HashSet<Question>();
            StudentCourses = new HashSet<StudentCourse>();
            Topics = new HashSet<Topic>();
        }

        public int courseID { get; set; }
        public string name { get; set; }
        public int duration { get; set; }
        public int courseGrade { get; set; }
        public int? NMCQ { get; set; }
        public int? NTF { get; set; }

        public virtual ICollection<DepartmentCourse> DepartmentCourses { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }
        public virtual ICollection<InstructorCourse> InstructorCourses { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
        public virtual ICollection<Topic> Topics { get; set; }
    }
}