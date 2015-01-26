
using System;
namespace GSM
{
    public class Display
    {
        private int size;
        private int colors;
 
        //Task5
        public int Size
        {
            get 
            { 
                return this.size; 
            }
            set 
            {
                if (value <= 0)
                {
                    throw new ApplicationException("Size must be > 0!");
                }
                this.size = value; 
            }
        }

        public int Colors
        {
            get 
            { 
                return this.colors; 
            }
            set 
            {
                if (value <= 0)
                {
                    throw new ApplicationException("Number of colors must be > 0!");
                }
                this.colors = value; 
            }
        }

        //Task2
        public Display()
        {
        }

        public Display(int size)
        {
            this.Size = size;
        }

        public Display(int size, int colors)
            : this(size)
        {
            this.Colors = colors;
        }

    }
}
