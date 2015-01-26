namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsMain
    {
        public static List<Student> listStudents = new List<Student>(){
                    new Student("Ivan", "Stoyanov", "40623361","0267888099", "ivan@abv.bg", 3, 3, 3, 3, 5, 4, 2),
                    new Student("Stoyan", "Ganchev", "10511111", "+359297145123", "ganchoka@yahoo.com", 2, 2, 2, 2, 2),
                    new Student("Mira", "Radeva", "40620661","+359877543564", "radeva.mira@abv.bg", 2, 6, 6, 6, 3),
                    new Student("Ivaylo", "Kenov", "60810645","+359878232301", "ikenov@gmail.bg", 3, 6, 6, 6, 4, 6, 2),
                    new Student("Boris", "Beker", "84488888","073398756", "bbeker@abv.bg", 2, 2, 2, 3, 4),
                    new Student("Nora", "Paskaleva", "50614514","+35946656565", "kaizer@abv.bg", 2, 6, 6, 6, 4, 6, 2),
                    new Student("Kichka", "Bodurova", "60812345","+359888136384", "kaizer0505@gmail.bg", 2, 2, 3, 3, 4, 3, 2)
                };
        
        public static void Main()
        {
            Task9();

            Task10();

            Task11();

            Task12();

            Task13();

            Task14();

            Task15();

        }

        //private static void Task16()
        //{
        //    Console.WriteLine("Task 16:");

        //    List<Group> groups = new List<Group>()
        //    {
        //        new Group(1, "Physics"),
        //        new Group(2, "Arts"),
        //        new Group(3, "Mathematics"),
        //        new Group(4, "Law"),
        //        new Group(5, "Medicine"),
        //        new Group(6, "Biology"),
        //    };

        //    var StudentsFromGroupMathematics = from student in list
        //                                       join grp in groups on student.GroupNumber equals grp.GroupNumber
        //                                       where grp.DepartmentName == "Mathematics"
        //                                       select student;

        //    foreach (var student in StudentsFromGroupMathematics)
        //    {
        //        Console.WriteLine(student);
        //    }
        //}

        private static void Task15()
        {
            Console.WriteLine("Task 15:");

            var MarksFromStudentsEnrolledIn2006 = from student in listStudents
                                                  where student.FacultyNumber.ElementAt(4) == '0' && student.FacultyNumber.ElementAt(5) == '6'
                                                  select student.Marks;

            List<int> marks = new List<int>();

            foreach (var mark in MarksFromStudentsEnrolledIn2006)
            {
                marks.AddRange(mark);
            }

            Console.WriteLine(string.Join(", ", marks));
        }

        private static void Task14()
        {
            Console.WriteLine("Task 14:");

            List<Student> studentsFromWith2 = listStudents.GetListOfStudentsWithNumberOfMarks(2, 2);

            foreach (var student in studentsFromWith2)
            {
                Console.WriteLine(student);
            }
        }

        private static void Task13()
        {
            Console.WriteLine("Task 13:");

            var studentsWithAtLeastOneExcellent =
                        from student in listStudents
                        where student.Marks.Contains(6)
                        select new
                        {
                            //StudentName = string.Format("{0} {1}", student.FirstName, student.LastName),
                            FirstName = student.FirstName,
                            LastName = student.LastName,
                            Marks = student.Marks
                        };

            foreach (var student in studentsWithAtLeastOneExcellent)
            {
                //Console.WriteLine(student.StudentName + "'s marks: " + string.Join(", ", student.Marks));
                Console.WriteLine(student.FirstName + " " + student.LastName + "'s marks: " + string.Join(", ", student.Marks));
            }
        }

        private static void Task12()
        {
            Console.WriteLine("Task 12:");

            var StudentsWithPhonesInSofia = from student in listStudents
                                            where student.Telephone.StartsWith("+3592") || student.Telephone.StartsWith("02")
                                            select student;

            foreach (var student in StudentsWithPhonesInSofia)
            {
                Console.WriteLine(student);
            }

        }

        private static void Task11()
        {
            Console.WriteLine("Task 11:");

            var studentsWithMailInABV = from student in listStudents
                                        where student.Email.Substring(student.Email.LastIndexOf("@")) == "@abv.bg"
                                        select student;

            foreach (var student in studentsWithMailInABV)
            {
                Console.WriteLine(student);
            }
        }

        private static void Task10()
        {
            Console.WriteLine("Task 10:");

            List<Student> studentsFromGroup2 = listStudents.GetListOfStudentsInExactGroup(2);

            foreach (var student in studentsFromGroup2)
            {
                Console.WriteLine(student);
            }

        }

        private static void Task9()
        {
            Console.WriteLine("Task 9:");
            var groupNumber2Students =
                from student in listStudents
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            foreach (var student in groupNumber2Students)
            {
                Console.WriteLine(student);
            }
        }
    }
}