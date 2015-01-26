/*We are given a school. In the school there are classes of students. Each class has a set of teachers. Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises. Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
	Your task is to identify the classes (in terms of  OOP) and their attributes and operations, encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.*/

//ЗДРАВЕЙ, НЯМАМ КЛАС ДИАГРАМА, ТЪЙ КАТО НЕ СЪМ С VSPRO. И ВСЕ НЕ ОСТАВА ВРЕМЕ ДА ИНСТАЛНА. АКО ИМАШ ВЪЗМОЖНОСТ МИ ПУСНИ ЕДНА КЛАС ДИАГРАМА НА ТВОЕТО VS  И МИ ПИШИ В КОМЕНТАРА ДАЛИ ИЗГЛЕЖДА ДОБРЕ. ЩЕ БЪДА МНОГО БЛАГОДАРЕН. АКО МОЖЕ МИ Я ПРАТИ НА kaizer0505@gmail.com  ЩЕ ПОЧЕРПЯ!

namespace School
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        //public static List<Discipline> listDisciplines = new List<Discipline> {
        //        new Discipline("Mathematics", 10, 5),
        //        new Discipline("Informatics", 4, 2, "high level"),
        //        new Discipline("Biology", 2, 0),
        //        };
        
        public static void Main()
        {
            //
            //Student ivan = new Student("Ivan", 345, "SOS");
            //ivan.Comments = "Qnko";
            //Console.WriteLine(ivan.Comments);
            //var math = new Discipline("Mathemathics", 3, 2);
            //Console.WriteLine(math.Name);
            //math.Comments = "ebati matematikata";
            //Console.WriteLine(math.Comments);
            //Console.WriteLine(ivan.Comments);
            //var inf = new Discipline("Informatics", 3, 2);

            var Stoyanov = new Teacher("Stoyanov", new Discipline("Mathematics", 10, 5), new Discipline("Biology", 2, 0, "low"));
            //Console.WriteLine(Stoyanov.Comments);
            foreach (var disc in Stoyanov.Disciplines)
            {
                Console.WriteLine(disc.Name + " " + disc.NumberOfExercises + disc.NumberOfLectures + disc.Comments);
            }

            
            Console.WriteLine(Stoyanov.Comments);
          
        }
    }
}
