﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ExamSystem.Entities
{
    public partial class Users
    {
        public Users()
        {
            Instructor = new HashSet<Instructor>();
            Student = new HashSet<Student>();
        }

        [Required]
        [Column("username")]
        [StringLength(100)]
        public string Username { get; set; }
        [Required]
        [Column("password")]
        [StringLength(200)]
        public string Password { get; set; }
        [Required]
        [Column("type")]
        [StringLength(50)]
        public string Type { get; set; }
        [Key]
        [Column("userID")]
        public int UserId { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<Instructor> Instructor { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Student> Student { get; set; }
    }
}