namespace StudentSystem.ConsoleClient
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    using StudentSystem.Data;
    using StudentSystem.Model;
    using StudentSystem.Data.Migrations;
    
    public class StudentSystemConsoleClient
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());
            var db = new StudentSystemDbContext();
            db.Database.Initialize(true);

            var student = new Student
            {
                Age = 30,
                FirstName = "Ivan",
                LastName = "Goshov",
                StudentStatus = StudentStatus.Online
            };

            student.Courses.Add(new Course
                {
                    Name = "Entity Framework Rocks!"
                });

            db.Students.Add(student);
            db.SaveChanges();

            var savedStudent = db.Students.First();

            Console.WriteLine(savedStudent.Id + ": " + savedStudent.FirstName + " " + savedStudent.LastName);
        }
    }
}
