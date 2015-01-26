namespace School
{
    public class Student : People, IComments
    {
        //private int classNumber;
        private string comments;

        public Student(string name, int classNumber)
            : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public Student(string name, int classNumber, string comments)
            : this(name, classNumber)
        {
            this.Comments = comments;
        }


        public int ClassNumber { get; set; }

        //public int ClassNumber 
        //{ 
        //    get
        //    {
        //        return this.classNumber;
        //    } 
        //    set
        //    {
        //        this.classNumber = value;
        //    }       
        //}

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
