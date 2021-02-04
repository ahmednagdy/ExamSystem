﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace ExamSystem.Entities
{
    public partial class Question
    {
        public Question()
        {
            Choices = new HashSet<Choice>();
        }

        public int questionID { get; set; }
        public string body { get; set; }
        public int modelAnswer { get; set; }
        public int grade { get; set; }
        public int type { get; set; }
        public int? courseID { get; set; }

        public virtual Course course { get; set; }
        public virtual ICollection<Choice> Choices { get; set; }
    }
}