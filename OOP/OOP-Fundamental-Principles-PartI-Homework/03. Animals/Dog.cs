namespace _03.Animals
{
    using System;

    public class Dog : Animal, ISound
    {
        public Dog(string name, int age, bool isMale) 
            : base(name, age, isMale)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine(Name + " says uaf-uaf...");
        }
    }
}
