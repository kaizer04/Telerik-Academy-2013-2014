using System;

public class SimpleMathExam : Exam
{
    private int problemsSolved = 0;

    public int ProblemsSolved
    {
        get 
        { 
            return this.problemsSolved; 
        }
        private set
        {
            if (!(0 <= value && value <= 2))
            { 
                throw new ArgumentOutOfRangeException("Problems solved");
            }

            this.problemsSolved = value;
        }
    }

    public SimpleMathExam(int problemsSolved)
    {
        this.ProblemsSolved = problemsSolved;
    }

    public override ExamResult Check()
    {
        if (this.ProblemsSolved == 0)
        {
            return new ExamResult(2, 2, 6, "Bad result: nothing done.");
        }
        else if (this.ProblemsSolved == 1)
        {
            return new ExamResult(4, 2, 6, "Average result: One problem solved.");
        }
        else if (this.ProblemsSolved == 2)
        {
            return new ExamResult(6, 2, 6, "Good result: Two problems solved.");
        }

        throw new ArgumentOutOfRangeException("The number of solved problems is invalid!");
    }
}
