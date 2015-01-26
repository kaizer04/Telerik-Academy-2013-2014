using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int testmachines = 0;
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Ivan");
            sb1.Append(" - ");
            sb1.AppendLine(testmachines == 0 ? "no machines" : testmachines.ToString() + (testmachines == 1 ? " machine" : " machines"));
            sb1.AppendLine("Kire");
            //sb1.AppendFormat(this.Name + " - " this.ma);
            //sb.AppendLine(this.MiddleName);
            //sb.AppendLine(this.LastName);
            Console.WriteLine(sb1.ToString());
        }
    }
}
