﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace ExamSystem.Entities
{
    public partial class Exam
    {
        public Exam()
        {
            StudentAnswers = new HashSet<StudentAnswer>();
        }

        public int examID { get; set; }
        public int? courseID { get; set; }

        public virtual Course course { get; set; }
        public virtual ICollection<StudentAnswer> StudentAnswers { get; set; }
    }
}