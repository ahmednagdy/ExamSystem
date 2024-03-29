﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ExamSystem.Entities
{
    public partial class StudentAnswers
    {
        [Key]
        [Column("studentID")]
        public int StudentId { get; set; }
        [Key]
        [Column("questionID")]
        public int QuestionId { get; set; }
        [Key]
        [Column("examID")]
        public int ExamId { get; set; }
        [Column("studentAnswer")]
        public int? StudentAnswer { get; set; }

        [ForeignKey(nameof(ExamId))]
        [InverseProperty("StudentAnswers")]
        public virtual Exam Exam { get; set; }
        [ForeignKey(nameof(StudentId))]
        [InverseProperty("StudentAnswers")]
        public virtual Student Student { get; set; }
    }
}