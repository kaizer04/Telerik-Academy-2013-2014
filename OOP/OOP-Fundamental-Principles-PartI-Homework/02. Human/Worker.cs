namespace Human
{
    using System;

    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string secondName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, secondName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Week Salary can not be a negative number");
                }
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Work Hours Per Day can not be a negative number");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            return this.weekSalary / 5 / this.workHoursPerDay;
        }
    }
}
