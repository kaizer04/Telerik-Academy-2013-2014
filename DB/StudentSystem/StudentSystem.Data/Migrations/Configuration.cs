namespace StudentSystem.Data.Migrations
{
    using StudentSystem.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystem.Data.StudentSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.ContextKey = "StudentSystem.Data.StudentSystemDBContext";
        }

        protected override void Seed(StudentSystem.Data.StudentSystemDbContext context)
        {
            this.SeedStudents(context);
        }

        private void SeedStudents(StudentSystemDbContext context)
        {
            if (context.Students.Any())
            {
                return;
            }

            context.Students.Add(new Student
                {
                    Age = 15,
                    FirstName = "Seed",
                    LastName = "Seeded",
                    ContactInfo = new StudentContactInfo 
                    {
                        Email = "Seed@seed.com"
                    }
                });
        }
    }
}
