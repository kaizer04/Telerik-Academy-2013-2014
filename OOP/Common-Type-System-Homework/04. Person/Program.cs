/*Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to display the information of a person and if age is not specified – to say so. Write a program to test this functionality.
*/

namespace _04.Person
{
    using System;

    public class Program
    {
        static void Main()
        {
            var pesho = new Person("Pesho");
            var ivan = new Person("Ivan", 34);
            Console.WriteLine(pesho);
            Console.WriteLine(ivan);
        }
    }
}
