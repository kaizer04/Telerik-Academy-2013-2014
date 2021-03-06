﻿namespace StudentSystem.Model
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    [Table("Exams")]
    public class Test
    {
        private ICollection<Student> students;

        public Test()
        {
            this.Id = Guid.NewGuid();
            this.students = new HashSet<Student>();
        }

        [ForeignKey("Course")]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        //[ForeignKey("Course")]
        //public Guid CourseId { get; set; }

        //public virtual Course Course { get; set; }

        public virtual ICollection<Student> Students
        {
            get 
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }
    }
}
