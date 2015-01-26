namespace School
{
    
    using System;
    using System.Collections.Generic;

    public class School
    {
        private List<Class> classes;

        public School()
        {
            this.classes = new List<Class>();
        }

        public Class[] Classes
        {
            get
            {
                return this.classes.ToArray();
            }
        }

    }
}
