﻿namespace KPK_Code_Formatting_CSharp
{
    using System;
    using System.Text;

    public class Event : IComparable
    {
        public DateTime date;
        public string title;
        public string location;

        public Event(DateTime date, String title, String location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public int CompareTo(object obj)
        {
            Event other = obj as Event;
            
            int byDate = this.date.CompareTo(other.date);
            int byTitle = this.title.CompareTo(other.title);
            int byLocation = this.location.CompareTo(other.location);
            
            if (byDate == 0)
            {
                if (byTitle == 0)
                {
                    return byLocation;
                }
                else
                {
                    return byTitle;
                }
            }
            else 
            { 
                return byDate;
            }
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            
            toString.Append(date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toString.Append(" | " + title);
            
            if (location != null && location != "")
            { 
                toString.Append(" | " + location);
            }

            return toString.ToString();
        }

    }
}
