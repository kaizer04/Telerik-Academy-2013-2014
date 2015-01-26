using System;
using System.Linq;
using System.Collections.Generic;

public class Student
{
    private string firstName;
    private string lastName;
    private IList<Exam> exams;

    public string FirstName
    {
        get 
        { 
            return this.firstName; 
        }
        private set
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Invalid first name!");
            }

            this.firstName = value;
        }
    }
    public string LastName
    {
        get 
        { 
            return this.lastName; 
        }
        private set
        {
            if (String.IsNullOrEmpty(value))
            { 
                throw new ArgumentException("Invalid last name!");
            }

            this.lastName = value;
        }
    }

    public IList<Exam> Exams
    {
        get 
        { 
            return this.exams; 
        }
        private set
        {
            this.exams = value ?? new List<Exam>();
        }
    }

    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public IList<ExamResult> CheckExams()
    {
        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        // results.this.Exams.Select(exam =>
        //    exam.Check()
        //).ToList();

        return results;
    }

    public double CalcAverageExamResultInPercents()
    {
        double[] examScore = new double[this.Exams.Count];
        IList<ExamResult> examResults = CheckExams();
        for (int i = 0; i < examResults.Count; i++)
        {
            examScore[i] = 
                ((double)examResults[i].Grade - examResults[i].MinGrade) / 
                (examResults[i].MaxGrade - examResults[i].MinGrade);
        }

        return examScore.Average();

        //return this.CheckExams().Average(res =>
        //    res.CalcInPercents()
        //);
    }
}
