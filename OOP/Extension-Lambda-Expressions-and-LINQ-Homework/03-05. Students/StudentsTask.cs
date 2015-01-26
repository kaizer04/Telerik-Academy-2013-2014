//(Task3) Write a method that from a given array of students finds all students
//whose first name is before its last name alphabetically. Use LINQ query operators.

//(Task4) Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

//(Task5) Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students
//by first name and last name in descending order. Rewrite the same with LINQ.(task5)

namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StudentsTask
    {
        public static void Main()
        {
            var students = new List<Student> 
            {
                new Student("Ivan", "Ivanov", 20) ,
                new Student("Stamat", "Petrov", 19),
                new Student("Stoyan", "Ivanov", 16),
                new Student("Iva" , "Avramova", 24),
                new Student ("Greta", "Petrova", 28),   
            };
            
            //task 3
            //var FirstNameBeforeLastNameAlphabetically = students.Where(st => st.FirstName.CompareTo(st.LastName) < 0);

            var FirstNameBeforeLastNameAlphabetically = 
                    from student in students
                    where student.FirstName.CompareTo(student.LastName) < 0
                    select student;

            Console.WriteLine("Students whose First Name is before Last Name alphabetically: ");
            
            foreach (var item in FirstNameBeforeLastNameAlphabetically)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            //task 4
            //var StudentsWithAgeBetween18and24 = students.Where(st => st.Age >= 18 && st.Age <= 24);

            var StudentsWithAgeBetween18and24 =
                    from student in students
                    where student.Age >= 18 && student.Age <= 24
                    select student;
            
            Console.WriteLine("Students between 18 and 24 age: ");        
            
            foreach (var item in StudentsWithAgeBetween18and24)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            //task 5
            Console.WriteLine("Sorted by FirstName and Last Name trough Lambda: ");
            
            var SortedStudentsFirstNameLastNameDescendingLambda =
                students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);

            foreach (var item in SortedStudentsFirstNameLastNameDescendingLambda)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }

            Console.WriteLine("Sorted by FirstName and Last Name trough Linq : ");
            
            var SortedStudentsFirstNameLastNameDescendingLINQ =
                            from student in students
                            orderby student.FirstName descending, student.LastName descending
                            select student;

            foreach (var item in SortedStudentsFirstNameLastNameDescendingLINQ)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
    }
}