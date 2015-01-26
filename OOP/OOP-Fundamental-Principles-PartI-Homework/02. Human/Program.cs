/*Define abstract class Human with first name and last name. Define new class Student which is derived from Human and has new field – grade. Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper constructors and properties for this hierarchy. Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method). Initialize a list of 10 workers and sort them by money per hour in descending order. Merge the lists and sort them by first name and last name.*/

namespace Human
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            //SortStudentByGradeInAscendingOrder
            List<Student> listOfStudents = new List<Student>()
                    {
                        new Student("Ivan", "Stoyanov", 2),
                        new Student("Stoyan", "Ganchev", 2),
                        new Student("Mira", "Radeva", 3),
                        new Student("Ivaylo", "Kenov", 5),
                        new Student("Boris", "Beker", 4),
                        new Student("Nora", "Paskaleva", 6),
                        new Student("Kichka", "Bodurova", 6),
                        new Student("Katya", "Gancheva", 2),
                        new Student("Lora", "Danailova", 3),
                        new Student("Daniela", "Traeva", 2),
                        new Student("Miroslava", "Ivanova", 4),
                        new Student("Yordanka", "Mihova", 2),
                    };

            var SortStudentByGradeInAscendingOrder =
                        from student in listOfStudents
                        orderby student.Grade ascending
                        select student;
            
            Console.WriteLine("Sort Student By Grade In Ascending Order ");
            foreach (var item in SortStudentByGradeInAscendingOrder)
            {
                Console.WriteLine(item + "," + " Grade = " + item.Grade);
            }

            //SortWorkerByMoneyPerHourInDescendingOrder
            List<Worker> listOfWorkers = new List<Worker>()
                    {
                        new Worker("Ivan", "Stoyanov", 500, 8),
                        new Worker("Stoyan", "Ganchev", 6000, 8),
                        new Worker("Mira", "Radeva", 350, 4),
                        new Worker("Ivaylo", "Kenov", 50, 2),
                        new Worker("Boris", "Beker", 89, 3),
                        new Worker("Nora", "Paskaleva", 1800, 16),
                        new Worker("Kichka", "Bodurova", 250, 10),
                        new Worker("Katya", "Gancheva", 450, 9),
                        new Worker("Lora", "Danailova", 69.58M, 1),
                        new Worker("Daniela", "Traeva", 180, 6),
                        new Worker("Miroslava", "Ivanova", 875, 10),
                        new Worker("Yordanka", "Mihova", 750, 9),
                    };

            var SortWorkerByMoneyPerHourInDescendingOrder =
                        from worker in listOfWorkers
                        orderby worker.MoneyPerHour() descending
                        select worker;

            Console.WriteLine();
            Console.WriteLine("Sort Student By Money Per Hour In Descending Order ");
            foreach (var item in SortWorkerByMoneyPerHourInDescendingOrder)
            {
                Console.WriteLine(item + "," + " Money Per Hour = " + item.MoneyPerHour());
            }

            //Merge the lists and sort them by first name and last name - да не се чудите кво става - на двата листа са ми едни и същи имената, но не ми се набиваше наново :)
            List<Human> allHumans = new List<Human>();
            allHumans.AddRange(listOfStudents);
            allHumans.AddRange(listOfWorkers);
            
            var sortedAllHumans =
                        from human in allHumans
                        orderby human.FirstName, human.LastName
                        select human;
            
            Console.WriteLine();
            Console.WriteLine("Merge the lists and sort them by first name and last name ");
            foreach (var item in sortedAllHumans)
            {
                Console.WriteLine(item);
            }
        }
    }
}
