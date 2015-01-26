﻿namespace _03.InvalidRangeException
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
        where T : IComparable<T>
    {
        //private T start;
        private T end;

        public InvalidRangeException(string message, T start, T end, Exception exception)
            : base(message, exception)
        {
            this.Start = start;
            this.End = end;
        }

        public InvalidRangeException(string message, T start, T end)
            : this(message, start, end, null) 
        { 
        
        }

        public InvalidRangeException(T start, T end)
            : this(null, start, end, null) 
        { 
        
        }

        public T Start { get; set; }
        //{
        //    get
        //    {
        //        return this.start;
        //    }
        //    set
        //    {
        //        this.start = value;
        //    }
        //}

        public T End
        {
            get
            {
                return this.end;
            }
            set
            {
                if (this.Start.CompareTo(value) > 0)
                {
                    throw new ArgumentException("End can not be before Start!");
                }
                this.end = value;
            }
        }
    }
}
