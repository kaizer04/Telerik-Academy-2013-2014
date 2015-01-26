/*Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. Display them in the standard date format for Canada.*/


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class ExtractsDates
{
    static void Main()
    {
        Console.WriteLine("Extracting all dates that match the format DD.MM.YYYY");
        Console.Write("Enter a text: ");
        string s = Console.ReadLine();

        DateTime date;
        foreach (Match item in Regex.Matches(s, @"\b\d{2}.\d{2}.\d{4}\b"))
        {
            if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
        }


        //string buildS = " " + s + " ";
        //char[] chars = new char[] { ' ', ',', '.', '!', '?' };
        //string buildSub;
        //for (int i = 0; i < buildS.Length; i++)
        //{
        //    int firstIndexDot = buildS.IndexOf(".", i);
        //    if (firstIndexDot != -1)
        //    {
        //        int secondIndexDot = buildS.LastIndexOf(" ", indexAt);
        //        //Console.WriteLine(leftSpace);
        //        int rightSpace = buildS.IndexOf(" ", indexAt);
        //        buildSub = buildS.Substring(leftSpace, rightSpace - leftSpace).Trim(chars);
        //        if (leftSpace < indexAt - 1 && indexAt + 3 < rightSpace && buildSub.LastIndexOf(".", buildSub.Length - 3, 3) != -1)
        //        {
        //            Console.WriteLine(buildSub);
        //        }
        //        i = rightSpace;
        //    }
            
        //}
        
    }
}