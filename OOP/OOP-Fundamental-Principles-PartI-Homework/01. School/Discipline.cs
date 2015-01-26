namespace School
{
    using System;

    public class Discipline : IComments
    {
        private string name;
        //private int numberOfLectures;
        //private int numberOfExercises;
        private string comments; 

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public Discipline(string name, int numberOfLectures, int numberOfExercises, string comments)
            : this(name, numberOfLectures, numberOfExercises)
        {
            this.Comments = comments;
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
                    throw new ArgumentException("Name can not be null or empty !");
                }
                this.name = value;
            }
        }

        public int NumberOfLectures { get; private set; }

        public int NumberOfExercises { get; private set; }

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
