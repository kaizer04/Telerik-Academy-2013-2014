namespace StudentSystem.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Student
    {
        private ICollection<Course> courses;
        private ICollection<Homework> homeworks;
        private ICollection<Test> tests;

        public Student()
        {
            this.ContactInfo = new StudentContactInfo();
            this.courses = new HashSet<Course>();
            this.homeworks = new HashSet<Homework>();
            this.tests = new HashSet<Test>();
        }
        
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        public string LastName { get; set; }

        
        public int Age { get; set; }

        public StudentStatus StudentStatus { get; set; }

        public StudentContactInfo ContactInfo { get; set; }

        public virtual ICollection<Course> Courses 
        { 
            get
            {
                return this.courses;
            }
            set
            {
                this.courses = value;
            }
        }

        public virtual ICollection<Homework> Homeworks
        {
            get
            {
                return this.homeworks;
            }
            set
            {
                this.homeworks = value;
            }
        }

        public virtual ICollection<Test> Tests
        {
            get
            {
                return this.tests;
            }
            set
            {
                this.tests = value;
            }
        }
    }
}
