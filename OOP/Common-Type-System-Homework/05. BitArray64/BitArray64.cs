namespace _05.BitArray64
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray64 : IEnumerable<int>
    {
        //private ulong number;

        //public ulong Number { get { return this.number; } set { this.number = value; } }

        public ulong Number { get; private set; }

        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Index must be in range [0, 63].");
                }

                return (int)((this.Number >> index) & 1);
            }
            //set
            //{
            //    if (index < 0 || index > 31)
            //    { 
            //        throw new IndexOutOfRangeException(String.Format("Index {0} is invalid!", index));
            //    }
            //    if (value < 0 || value > 1)
            //    {
            //        throw new ArgumentException(String.Format("Value {0} is invalid!", value));
            //    }
            //    // Clear the bit at position index
            //    value &= ~((int)(1 << index));
            //    // Set the bit at position index to value
            //    value |= (int)(value << index);
            //}

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // Call the generic version of the method
            return this.GetEnumerator();
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 63; i >= 0; i--)
            {
                yield return this[i];
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 63; i >= 0; i--)
            {
                sb.Append(this[i]);
            }
            return sb.ToString();
        }

        public static bool operator ==(BitArray64 array1, BitArray64 array2)
        {
            return BitArray.Equals(array1, array2);
        }

        public static bool operator !=(BitArray64 array1, BitArray64 array2)
        {
            return !(BitArray64.Equals(array1, array2));
        }

        public override bool Equals(object obj)
        {
            if (obj as BitArray64 == null)
            {
                return false;
            }
            BitArray64 arr2 = obj as BitArray64;

            return this.Number == arr2.Number;
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }
        
    }
}
