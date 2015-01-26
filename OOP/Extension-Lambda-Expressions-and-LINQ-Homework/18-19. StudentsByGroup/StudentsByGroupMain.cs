// Task18 Create a program that extracts all students grouped by GroupName and then prints them to the console. Use LINQ.

// Task 19 Rewrite the previous using extension methods.

namespace StudentsByGroup
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StudentsByGroupMain
    {
        public static List<Student> listStudents = new List<Student>(){
                    new Student("Ivan", "ComputerScience"),
                    new Student("Stoyan", "ComputerScience"),
                    new Student("Mira", "Law"),
                    new Student("Ivaylo", "ComputerScience"),
                    new Student("Boris", "Law"),
                    new Student("Nora", "ComputerScience"),
                    new Student("Kichka", "Maths"),
                    new Student("Ivana", "Law"),
                    new Student("Bobi", "Biology"),
                    new Student("Paskal", "Maths"),
                    new Student("Bek", "Biology"),
                    new Student("Kiril", "Biology"),
                    new Student("Radka", "Biology"),
                    new Student("Gancho", "Maths"),
                };

        public static void Main()
        {
            var groupedStudents = from st in listStudents
                                orderby st.GroupName
                                select st;

            Console.WriteLine("Task18: ");
            foreach (var student in groupedStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine("Extension Methods (Task19): ");
            Console.WriteLine();

            var orderedStudentsExtension = listStudents.OrderByGroupName();

            foreach (var student in orderedStudentsExtension)
            {
                Console.WriteLine(student);
            }
        }
    }
}
