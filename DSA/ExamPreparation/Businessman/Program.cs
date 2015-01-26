namespace Businessman
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long[] solutions = new long[71];
            solutions[0] = 1;
            for (int allPeople = 2; allPeople <= N; allPeople += 2)
            {
                for (int oneSidePeople = allPeople - 2; oneSidePeople >= 0; oneSidePeople -= 2)
                {
                    solutions[allPeople] += solutions[oneSidePeople] * solutions[allPeople - oneSidePeople - 2];
                }
            }

            //for (int i = 0; i < N; i += 2)
            //{
            //    Console.WriteLine(solutions[i]);
            //}

            Console.WriteLine(solutions[N]);
        }
    }
}
