namespace _03.Animals
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public abstract class Animal
    {
        private int age;
        private string name;
        private bool isMale;

        protected Animal(string name, int age, bool isMale)
        {
            this.Name = name;
            this.Age = age;
            this.IsMale = isMale;
        }

        public int Age
        {
            get 
            { 
                return this.age; 
            }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Age must be at least 1 !");
                }
                this.age = value;
            }
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

        public bool IsMale
        {
            get 
            { 
                return this.isMale; 
            }
            set 
            {
				this.isMale = value; 
            }
        }
        
        public override string ToString()
        {
            return string.Format
                ("{0} is a {1}, {2} years old and a {3}"
                , this.name, this.GetType().Name, this.age, this.isMale ? "Male" : "Female");
        }

        public static double Average(Animal[] array)
        {
            var averageArray = (from animal in array
								select animal.Age).Average();
            return averageArray;
        }
    }
}
