/*Define a class BitArray64 to hold 64 bit values inside an ulong value. Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.*/

namespace _05.BitArray64
{
    using System;

    public class Program
    {
        public static void Main()
        {
            BitArray64 test = new BitArray64(4534543);
            BitArray64 test1 = new BitArray64(54545454545);
            Console.WriteLine(test);

            foreach (var bit in test)
            {
                Console.Write(bit);
            }
            Console.WriteLine();

            Console.WriteLine(test.Equals(test1));
            Console.WriteLine(test != test1);
            Console.WriteLine(test.GetHashCode());
            Console.WriteLine(test1.GetHashCode());
            
        }
    }
}
