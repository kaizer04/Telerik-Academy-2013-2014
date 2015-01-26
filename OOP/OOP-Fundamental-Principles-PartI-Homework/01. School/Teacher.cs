namespace School
{
    using System;
    using System.Collections.Generic;


    public class Teacher : People, IComments
    {
        private List<Discipline> disciplines;
        private string comments;

        public Teacher(string name, params Discipline[] addDisciplines)
            : base(name)
        {
            this.disciplines = new List<Discipline>(addDisciplines);
            //disciplines = new List<Discipline>();
            //this.disciplines.AddRange(addDisciplines);
            //this.Comments = comments;
        }
        
        public Discipline[] Disciplines 
        { 
            get
            {
                return this.disciplines.ToArray();
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
