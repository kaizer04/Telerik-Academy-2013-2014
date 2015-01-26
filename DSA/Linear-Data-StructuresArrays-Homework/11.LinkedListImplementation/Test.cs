namespace _11.LinkedListImplementation
{
    using System;
    using System.Linq;

    public class Test
    {
        public static void Main()
        {
            var test = new JLinkedList<int>();
            test.AddItem(7);
            test.AddItem(18);
            test.AddItem(22);
            Console.WriteLine(test);
            test.RemoveItem(181);
            Console.WriteLine(test);
        }
    }
}