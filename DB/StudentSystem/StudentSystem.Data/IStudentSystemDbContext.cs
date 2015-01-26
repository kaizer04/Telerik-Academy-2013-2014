﻿namespace StudentSystem.Data
{
    using System.Data.Entity;

    using StudentSystem.Model;
using System.Data.Entity.Infrastructure;

    public interface IStudentSystemDbContext
    {
        IDbSet<Student> Students { get; set; }

        IDbSet<Course> Courses { get; set; }

        IDbSet<Homework> Homeworks { get; set; }

        IDbSet<Test> Tests { get; set; }

        //copy from MSoft
        IDbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
