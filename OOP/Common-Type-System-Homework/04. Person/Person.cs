namespace _04.Person
{
    using System;

    public class Person
    {
        private string name;
        private int? age;

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, int age) 
            : this(name)
        {
            this.Age = age;
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
                    System.Console.WriteLine("The name can not be empty");
                }
                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age can not be less than 0");
                }
                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}", this.Name, this.Age == null ? "Not specified" : this.Age.ToString());
        }
    }
}
