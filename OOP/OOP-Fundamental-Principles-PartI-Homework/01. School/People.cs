namespace School
{
    using System;

    public abstract class People //: IComments
    {
        private string name;
        //private string comments;

        protected People(string name)
        {
            this.Name = name;
        }

        //public People(string name, string comments) 
        //    : this(name)
        //{
        //    this.Comments = comments;
        //}

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
                    throw new ArgumentException("Name can not be null or empty !");
                }
                this.name = value;
            }
        }

        //public string Comments
        //{
        //    get
        //    {
        //        if (this.comments == null)
        //        {
        //            return "No comments yet";
        //        }
        //        return this.comments;
        //    }
        //    set
        //    {
        //        this.comments = value;
        //    }
        //}
    }
}