namespace _03.Animals
{
    using System;

    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, bool isMale) 
                : base(name, age, isMale)
        {
        }

        public void ProduceSound()
        {
            Console.WriteLine(this.Name + " says kvak-kvak...");
        }
            
    }
}
