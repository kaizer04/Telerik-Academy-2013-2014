namespace StudentsByGroup
{
    using System;
    
    public class Student
    {
        private string name;
        private string groupName;

        public Student(string StudentName, string StudentGroup)
        {
            this.Name = StudentName;
            this.GroupName = StudentGroup;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name can not be null or empty!");
                }
                this.name = value;
            }
        }

        public string GroupName
        {
            get
            {
                return this.groupName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Group Name can not be null or empty!");
                }
                this.groupName = value;
            }
        }

        public override string ToString()
        {
            return this.Name + " is in group " + this.GroupName;
        }
    }
}
