/*Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound. Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).*/

namespace _03.Animals
{
    using System;

    public class Program
    {
        public static void Main()
        {
            //Frog miew = new Frog("Dangleton", 3, false);
            //Console.WriteLine(miew);
            //miew.ProduceSound();
            //Dog Sharo = new Dog("Sharo", 1, true);
            //Console.WriteLine(Sharo);
            //Sharo.ProduceSound();

            Frog[] frogs =
            {
                new Frog("Frog1", 2, true),
                new Frog("Frog2", 3, false),
                new Frog("Frog3", 6, false),
                new Frog("Frog4", 7, true)
            };
            Dog[] dogs =
            {
                new Dog("Dog1", 4, true),
                new Dog("Dog2", 7, true),
                new Dog("Dog3", 8, true),
                new Dog("Dog4", 10, false)
            };
            Cat[] cats =
            {
                new Kitten("Cat1", 8),
                new Tomcat("Cat2", 5),
                new Kitten("Cat3", 2),
                new Tomcat("Cat4", 2)
            };

            //Console.WriteLine(frogs[3]);
            //frogs[3].ProduceSound();

            Console.WriteLine("Average age of dogs is" + Animal.Average(dogs));
            Console.WriteLine("Average age of frogs is" + Animal.Average(frogs));
            Console.WriteLine("Average age of cats is" + Animal.Average(cats));
        }
    }
}
