using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int DecreaseWoodValue = 1;
            int value = 0;

            if (value > 0)
            {
                value -= DecreaseWoodValue;
                //value--;
            }

            Console.WriteLine(value);
        }
    }
}
