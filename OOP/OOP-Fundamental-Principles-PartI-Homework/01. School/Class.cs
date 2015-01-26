namespace School
{
    using System;
    using System.Collections.Generic;

    public class Class : IComments
    {
        private List<Teacher> teachers;
        private List<Student> students;
        private string textID;
        private string comments;

        public Class(string textID, params Teacher[] teachers)
        {
            this.TextID = textID;
            this.teachers = new List<Teacher>(teachers);
            this.students = new List<Student>();
        }


        public string TextID 
        {
            get
            {
                return this.textID;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Class Text Identifier can not be null or empty!");
                }
                this.textID = value;
            } 
        }

        public Teacher[] Teachers
        {
            get
            {
                return this.teachers.ToArray();
            }
        }

        public Student[] Students
        {
            get
            {
                return this.students.ToArray();
            }
        }

        public string Comments
        {
            get
            {
                if (this.comments == null)
                {
                    return "No comments yet";
                }
                return this.comments;
            }
            set
            {
                this.comments = value;
            }
        }
    }
}
