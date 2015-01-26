/* 1. Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties. Override the standard methods, inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

 * 2. Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.
 
 * 3. Implement the  IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social security number (as second criteria, in increasing order).*/

namespace _01_03.Student
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Student ivan = new Student("Ivan", "Ivanov", "Ivanov", 8888444411, "Sofia", "+359877353443", "ivandi@abv.bg", 3,
                                    Speciality.Law, Faculty.Law, University.SU);
            Student goshko = new Student("Georgi", "Ivanov", "Ivanov", 8888444411, "Sofia", "+359877353443", "ivandi@abv.bg", 3,
                                    Speciality.Law, Faculty.Law, University.SU);
            //Console.WriteLine(ivan);
            //Student pesho = ivan;

            ////Console.WriteLine(Student.Equals(goshko, pesho));
            //bool isEqual;
            //if (ivan == pesho)
            //{
            //    isEqual = true;
            //}
            //else
            //{
            //    isEqual = false;
            //}
            //Console.WriteLine(isEqual);

            Student vesko = ivan.Clone();
            Console.WriteLine(vesko);

            Console.WriteLine(vesko.CompareTo(goshko));
        }
    }
}
