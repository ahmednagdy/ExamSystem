﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace ExamSystem.Entities
{
    public partial class StudentAnswer
    {
        public int studentID { get; set; }
        public int questionID { get; set; }
        public int examID { get; set; }
        public int? studentAnswer1 { get; set; }

        public virtual Exam exam { get; set; }
        public virtual Student student { get; set; }
    }
}