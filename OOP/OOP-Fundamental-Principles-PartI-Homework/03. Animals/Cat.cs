namespace _03.Animals
{
    using System;

    public class Cat : Animal, ISound
    {
        public Cat(string name, int age, bool isMale) 
            : base(name, age, isMale)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine(Name + " says myau-myau...");
        }
    }
}
