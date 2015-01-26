namespace _01_03.Student
{
    using System;
    using System.Text;
    using System.Reflection;

    public class Student : ICloneable, IComparable<Student>
    {
        //first, middle and last name, SSN, permanent address, mobile phone e-mail, course, , university, faculty
        private string firstName;
        private string middleName;
        private string lastName;
        private ulong ssn;
        private string address;
        private string mobilePhone;
        private string eMail;
        private int course;
        private Speciality speciality;
        private University university;
        private Faculty faculty;

        public Student(string firstName, string middleName, string lastName, ulong ssn, string address, string mobilePhone,
            string eMail, int course, Speciality speciality, Faculty faculty, University university)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = eMail;
            this.Course = course;
            this.Speciality = speciality;
            this.University = university;
            this.Faculty = faculty;
        }



        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The first name can`t be empty!");
                }
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The middle name can`t be empty!");
                }
                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The last name can`t be empty!");
                }
                this.lastName = value;
            }
        }

        public ulong SSN
        {
            get
            {
                return this.ssn;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("SSN must be a valid number!");
                }
                this.ssn = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The address can`t be empty!");
                }
                this.address = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The mobile phone number can not be null or empty!");
                }
                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get
            {
                return this.eMail;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The e-mail can not be empty!");
                }
                this.eMail = value;
            }
        }

        public int Course
        {
            get
            {
                return this.course;
            }
            set
            {
                if (value < 1 || value > 5)
                {
                    throw new ArgumentException("The course must be a valid number!");
                }
                this.course = value;
            }
        }

        public Speciality Speciality
        {
            get
            {
                return this.speciality;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Thhe speciality can not be empty!");
                }
                this.speciality = value;
            }
        }

        public University University
        {
            get
            {
                return this.university;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("The university can not be empty!");
                }
                this.university = value;
            }
        }

        public Faculty Faculty
        {
            get
            {
                return this.faculty;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentException("The faculty can not be empty!");
                }
                this.faculty = value;
            }
        }

        //public override string ToString()
        //{
        //    StringBuilder sb = new StringBuilder();

        //    sb.AppendLine(new string('-', 45));

        //    var properties = this.GetType().GetProperties();

        //    foreach (var prop in properties)
        //    {
        //        sb.AppendFormat("{0} : {1}", prop.Name.PadLeft(15), prop.GetValue(this));
        //        sb.AppendLine();
        //    }

        //    sb.Append(new string('-', 45));

        //    return sb.ToString();
        //}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.FirstName);
            sb.AppendLine(this.MiddleName);
            sb.AppendLine(this.LastName);
            sb.AppendLine(this.SSN.ToString());
            sb.AppendLine(this.Address);
            sb.AppendLine(this.MobilePhone);
            sb.AppendLine(this.Email);
            sb.AppendLine(this.Course.ToString());
            sb.AppendLine(this.Speciality.ToString());
            sb.AppendLine(this.university.ToString());
            sb.AppendLine(this.faculty.ToString());
            return sb.ToString();
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }

            if (!Object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }
            if (!Object.Equals(this.MiddleName, student.MiddleName))
            {
                return false;
            }
            if (!Object.Equals(this.LastName, student.LastName))
            {
                return false;
            }
            if (!Object.Equals(this.SSN, student.SSN))
            {
                return false;
            }
            if (!Object.Equals(this.Address, student.Address))
            {
                return false;
            }
            if (!Object.Equals(this.MobilePhone, student.MobilePhone))
            {
                return false;
            }
            if (!Object.Equals(this.Email, student.Email))
            {
                return false;
            }
            if (!Object.Equals(this.Course, student.Course))
            {
                return false;
            }
            if (!Object.Equals(this.University, student.University))
            {
                return false;
            }
            if (!Object.Equals(this.Faculty, student.Faculty))
            {
                return false;
            }
            if (!Object.Equals(this.Speciality, student.Speciality))
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override int GetHashCode()
        {
            return LastName.GetHashCode() ^ SSN.GetHashCode();
        }

        //Task2
        public Student Clone() //implements deep clone
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.MobilePhone, this.Email,
                                this.Course, this.Speciality, this.Faculty, this.University);
        }

        object ICloneable.Clone() //implicit interface implementation
        {
            return this.Clone();
        }

        //Task3

        public int CompareTo(Student student)
        {
            if (this.FirstName != student.FirstName)
            {
                return this.FirstName.CompareTo(student.FirstName);
            }
            if (this.MiddleName != student.MiddleName)
            {
                return this.MiddleName.CompareTo(student.MiddleName);
            }
            if (this.LastName != student.LastName)
            {
                return this.LastName.CompareTo(student.LastName);
            }
            return this.SSN.CompareTo(student.SSN);
        }
    }
}
