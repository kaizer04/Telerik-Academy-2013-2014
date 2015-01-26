/*Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.*/

namespace SubstringStringBuilder
{
    using System;
    using System.Text;

    public static class StringBuilderExtensions
    {
        //both startIndex and lenghth
        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
            return new StringBuilder(input.ToString().Substring(index, length));
        }

        //only startIndex
        public static StringBuilder Substring(this StringBuilder input, int index)
        {
            return new StringBuilder(input.ToString().Substring(index));
        }
    }

    public class StringBuilderExtensionsTester
    {
        static void Main()
        {

            var s = new StringBuilder( "Ivailo Kenov" );
            //s.Substring(08, 9);
            Console.WriteLine(s);
            
            var s1 = new StringBuilder();
            s1 = s.Substring(0, 6);
            Console.WriteLine(s1);

            Console.WriteLine(s.Substring(7));
            
            var strBuild = new StringBuilder();
            strBuild.Append("Ivo Kenov");
            Console.WriteLine(strBuild.Substring(0, 3));
        }
    }
}